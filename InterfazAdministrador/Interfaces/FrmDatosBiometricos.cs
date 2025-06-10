using AForge.Video.DirectShow;
using InterfazAdministrador.Data;
using InterfazAdministrador.Service;
using InterfazAdministrador.Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazAdministrador.Interfaces
{
    public partial class FrmDatosBiometricos : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;

        private readonly FaceDetectionService faceDetectionService = new FaceDetectionService();
        private readonly EmpleadoRepository empleadoRepository = new EmpleadoRepository();
        private readonly CaraRepository caraRepository = new CaraRepository();
        private Tool tool = new Tool();

        private Empleado empleadoSeleccionado = null;
        private List<Cara> caraList;
        private int caraIndex = 0;

        public FrmDatosBiometricos()
        {
            InitializeComponent();

            lblMostrarIniciandoCamara.Text = string.Empty;
            lblCantidadCaras.Text = string.Empty;
            btnAgregarCara.Enabled = false;
            btnEliminarCara.Enabled = false;
            btnSiguiente.Enabled = false;
            btnAnterior.Enabled = false;

            llenarDGVEmpleadosCaras(empleadoRepository.ListarEmpleados());
        }

        private void btnFiltrarPanelCara_Click(object sender, EventArgs e)
        {
            string buscar = txtFiltrarPanelCara.Text.ToLower();

            if (string.IsNullOrEmpty(buscar))
            {
                MessageBox.Show("Por favor, ingrese un nombre o apellido para filtrar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<Empleado> empleadosFiltrados = empleadoRepository.ListarEmpleados()
                .Where(emp => emp.nombreEmpleado.ToLower().Contains(buscar) || emp.apellidoEmpleado.ToLower().Contains(buscar))
                .ToList();

            llenarDGVEmpleadosCaras(empleadosFiltrados);
        }

        private void btnEliminarFiltro_Click(object sender, EventArgs e)
        {
            txtFiltrarPanelCara.Text = string.Empty;
            llenarDGVEmpleadosCaras(empleadoRepository.ListarEmpleados());
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            ActualizarImagenCara(--caraIndex);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            ActualizarImagenCara(++caraIndex);
        }

        private void btnAgregarCara_Click(object sender, EventArgs e)
        {
            if (empleadoSeleccionado == null)
            {
                MessageBox.Show("Por favor, seleccione un empleado antes de agregar una cara.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            RunCamara();
            lblMostrarIniciandoCamara.Text = "Cámara iniciada. Por favor, espere a que se muestre la imagen.";

            Task.Run(async () =>
            {
                while (videoSource == null || !videoSource.IsRunning)
                {
                    System.Threading.Thread.Sleep(100);
                }

                await Task.Delay(2000);

                Bitmap frameCopy = null;
                pbMostrarCaras.Invoke((MethodInvoker)delegate
                {
                    if (pbMostrarCaras.Image != null)
                        frameCopy = new Bitmap(pbMostrarCaras.Image);
                });
                StopCamera();
                if (frameCopy == null)
                {
                    Invoke(new Action(() =>
                    {
                        lblMostrarIniciandoCamara.Text = "No se pudo capturar la imagen de la cámara.";
                    }));
                    return;
                }

                var result = faceDetectionService.AgregarCaraEmpleado(empleadoSeleccionado.idEmpleado, frameCopy);

                if (result.Result)
                {
                    caraList = caraRepository.ListarCaras(empleadoSeleccionado.idEmpleado);
                    caraIndex = caraList.Count - 1;
                    Invoke(new Action(() =>
                    {
                        ActualizarImagenCara(caraIndex);
                        lblMostrarIniciandoCamara.Text = "Cara agregada exitosamente.";
                        llenarDGVEmpleadosCaras(empleadoRepository.ListarEmpleados());
                    }));
                }
                else
                {
                    Invoke(new Action(() =>
                    {
                        lblMostrarIniciandoCamara.Text = "Error al agregar la cara. Intente nuevamente.";
                    }));
                    LimpiarInterfazCaras();
                }
            });
        }

        private void btnEliminarCara_Click(object sender, EventArgs e)
        {
            lblMostrarIniciandoCamara.Text = "Eliminando cara seleccionada...";

            if (caraList == null || caraList.Count == 0)
            {
                Invoke(new Action(() =>
                {
                    lblMostrarIniciandoCamara.Text = "No hay caras para eliminar.";
                }));
                return;
            }
            var caraId = caraList[caraIndex].idCara;
            var result = caraRepository.EliminarCaraEmpleado(caraId);
            if (result)
            {
                caraList = caraRepository.ListarCaras(empleadoSeleccionado.idEmpleado);
                caraIndex = Math.Min(caraIndex, caraList.Count - 1);
                ActualizarImagenCara(caraIndex);
                lblMostrarIniciandoCamara.Text = "Cara eliminada exitosamente.";
                llenarDGVEmpleadosCaras(empleadoRepository.ListarEmpleados());
            }
            else
            {
                lblMostrarIniciandoCamara.Text = "Error al eliminar la cara. Intente nuevamente.";
            }
        }

        private void dgvEmpleadosCaras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblMostrarIniciandoCamara.Text = string.Empty;
            int fila = e.RowIndex;

            if (fila >= 0 && fila < dgvEmpleadosCaras.Rows.Count)
            {
                string nombreCompleto = dgvEmpleadosCaras.Rows[fila].Cells[0].Value.ToString();

                string idEmpleado = empleadoRepository.ListarEmpleados().Single(emp => $"{emp.apellidoEmpleado}, {emp.nombreEmpleado}".Equals(nombreCompleto)).idEmpleado;
                if (idEmpleado == null) MessageBox.Show("No se pudo encontrar el empleado seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                empleadoSeleccionado = empleadoRepository.ListarEmpleados().Single(emp => emp.idEmpleado.Equals(idEmpleado));
                caraList = caraRepository.ListarCaras(idEmpleado);

                if (caraList.Count > 0)
                {
                    ActualizarImagenCara(caraIndex);
                }
                else
                {
                    LimpiarInterfazCaras();
                }
            }
        }

        private void llenarDGVEmpleadosCaras(List<Empleado> empleados)
        {
            dgvEmpleadosCaras.Rows.Clear();
            foreach (var empleado in empleados)
            {
                dgvEmpleadosCaras.Rows.Add($"{empleado.apellidoEmpleado}, {empleado.nombreEmpleado}", caraRepository.tieneCaras(empleado.idEmpleado) ? "Si" : "No");
            }
        }

        private void ActualizarImagenCara(int index)
        {
            if (caraList == null || caraList.Count == 0)
            {
                LimpiarInterfazCaras();
                return;
            }

            if (index < 0 || index >= caraList.Count)
            {
                MessageBox.Show("Índice fuera de rango.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                caraIndex = index;

                if (pbMostrarCaras.Image != null)
                {
                    pbMostrarCaras.Image.Dispose();
                }

                pbMostrarCaras.Image = tool.Base64ToImage(caraList[index].caraBase64);
                pbMostrarCaras.SizeMode = PictureBoxSizeMode.Zoom;

                ActualizarEstadoBotones();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar la imagen: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarEstadoBotones()
        {
            if (caraList == null || caraList.Count == 0)
            {
                ActualizarBotones(false, false, true, false, false);
                return;
            }

            bool esElPrimero = caraIndex == 0;
            bool esElUltimo = caraIndex == caraList.Count - 1;
            bool hayMultiplesCaras = caraList.Count > 1;

            bool siguienteEnabled = !esElUltimo && hayMultiplesCaras;
            bool anteriorEnabled = !esElPrimero && hayMultiplesCaras;

            bool agregarEnabled = true;
            bool eliminarEnabled = caraList.Count > 0;
            bool mostrarTexto = caraList.Count > 0;

            ActualizarBotones(siguienteEnabled, anteriorEnabled, agregarEnabled, eliminarEnabled, mostrarTexto);
        }

        private void LimpiarInterfazCaras()
        {
            if (pbMostrarCaras.Image != null)
            {
                pbMostrarCaras.Image.Dispose();
                pbMostrarCaras.Image = null;
            }

            ActualizarBotones(false, false, true, false, false);
        }

        private void ActualizarBotones(bool siguiente, bool anterior, bool agregar, bool eliminar, bool texto)
        {
            btnSiguiente.Enabled = siguiente;
            btnAnterior.Enabled = anterior;
            btnAgregarCara.Enabled = agregar;
            btnEliminarCara.Enabled = eliminar;

            lblCantidadCaras.Text = texto ? $"{caraIndex + 1}/{caraList.Count}" : string.Empty;
        }

        private void RunCamara()
        {
            try
            {
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                if (videoDevices.Count == 0)
                {
                    MessageBox.Show("No se encontró ninguna cámara.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
                videoSource.NewFrame += VideoSource_NewFrame;
                videoSource.Start();

                pbMostrarCaras.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al inicializar la cámara: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                StopCamera();
            }
        }

        private void VideoSource_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            try
            {
                Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();

                if (pbMostrarCaras.InvokeRequired)
                {
                    pbMostrarCaras.BeginInvoke((MethodInvoker)delegate
                    {
                        try
                        {
                            var oldImage = pbMostrarCaras.Image;
                            pbMostrarCaras.Image = (Bitmap)bitmap.Clone();
                            oldImage?.Dispose();
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.Debug.WriteLine($"Error updating camera image: {ex.Message}");
                        }
                        finally
                        {
                            bitmap.Dispose();
                        }
                    });
                }
                else
                {
                    var oldImage = pbMostrarCaras.Image;
                    pbMostrarCaras.Image = (Bitmap)bitmap.Clone();
                    oldImage?.Dispose();
                    bitmap.Dispose();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in VideoSource_NewFrame: {ex.Message}");
            }
        }

        private void StopCamera()
        {
            try
            {
                if (videoSource != null && videoSource.IsRunning)
                {
                    videoSource.SignalToStop();
                    videoSource.WaitForStop();
                    videoSource.NewFrame -= VideoSource_NewFrame;
                }
                pbMostrarCaras.Image?.Dispose();
                pbMostrarCaras.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al detener la cámara: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
