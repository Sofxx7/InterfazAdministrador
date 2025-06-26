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
        private readonly FaceDetectionService faceDetectionService = new FaceDetectionService();
        private readonly EmpleadoRepository empleadoRepository = new EmpleadoRepository();
        private readonly CaraRepository caraRepository = new CaraRepository();
        private readonly Tool tool = new Tool();

        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;

        private Empleado empleadoSeleccionado = null;
        private List<Cara> caraList;
        private int caraIndex = 0;
        private List<Empleado> empleadosCache = new List<Empleado>();

        public FrmDatosBiometricos()
        {
            InitializeComponent();

            lblMostrarIniciandoCamara.Text = string.Empty;
            lbl.Text = string.Empty;
            btnAgregarCara.Enabled = false;
            btnEliminarCara.Enabled = false;
            btnSiguiente.Enabled = false;
            btnAnterior.Enabled = false;

            pbLogo.Visible = true;

            this.Load += FrmDatosBiometricos_LoadAsync;
        }

        private async void FrmDatosBiometricos_LoadAsync(object sender, EventArgs e)
        {
            await CargarEmpleadosAsync();
        }

        private async Task CargarEmpleadosAsync()
        {
            empleadosCache = await Task.Run(() => empleadoRepository.ListarEmpleados());
            LlenarDGVEmpleadosCarasOptimizado(empleadosCache);
        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            txtFiltrar.Text = string.Empty;
            LlenarDGVEmpleadosCarasOptimizado(empleadosCache);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (caraList == null || caraList.Count == 0)
            {
                MessageBox.Show("No hay caras para mostrar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (caraIndex > 0)
                ActualizarImagenCara(--caraIndex);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (caraList == null || caraList.Count == 0)
            {
                MessageBox.Show("No hay caras para mostrar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (caraIndex < caraList.Count - 1)
                ActualizarImagenCara(++caraIndex);
        }

        private void btnAgregarCara_Click(object sender, EventArgs e)
        {
            if (empleadoSeleccionado == null)
            {
                MessageBox.Show("Por favor, seleccione un empleado antes de agregar una cara.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            pbLogo.Visible = false;
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
                pbCamara.Invoke((MethodInvoker)delegate
                {
                    if (pbCamara.Image != null)
                        frameCopy = new Bitmap(pbCamara.Image);
                });
                StopCamera();
                if (frameCopy == null)
                {
                    Invoke(new Action(() =>
                    {
                        MessageBox.Show("No se pudo capturar la imagen de la cámara. Asegúrese de que la cámara esté funcionando correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblMostrarIniciandoCamara.Text = string.Empty;
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
                        MessageBox.Show("Cara agregada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblMostrarIniciandoCamara.Text = string.Empty;
                        LlenarDGVEmpleadosCarasOptimizado(empleadosCache);
                    }));
                }
                else
                {
                    Invoke(new Action(() =>
                    {
                        MessageBox.Show("Error al agregar la cara. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblMostrarIniciandoCamara.Text = string.Empty;
                    }));
                    LimpiarInterfazCaras();
                }
            });
        }

        private void btnEliminarCara_Click(object sender, EventArgs e)
        {
            if (empleadoSeleccionado == null)
            {
                MessageBox.Show("Seleccione un empleado antes de eliminar una cara.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (caraList == null || caraList.Count == 0)
            {
                MessageBox.Show("No hay caras registradas para el empleado seleccionado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblMostrarIniciandoCamara.Text = string.Empty;
                return;
            }
            var caraId = caraList[caraIndex].idCara;
            var result = caraRepository.EliminarCaraEmpleado(caraId);
            if (result)
            {
                caraList = caraRepository.ListarCaras(empleadoSeleccionado.idEmpleado);
                caraIndex = Math.Min(caraIndex, caraList.Count - 1);
                ActualizarImagenCara(caraIndex);
                MessageBox.Show("Cara eliminada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblMostrarIniciandoCamara.Text = string.Empty;
                LlenarDGVEmpleadosCarasOptimizado(empleadosCache);
            }
            else
            {
                MessageBox.Show("Error al eliminar la cara. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvEmpleadosCaras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pbLogo.Visible = false;
            lblMostrarIniciandoCamara.Text = string.Empty;
            int fila = e.RowIndex;

            if (fila >= 0 && fila < dgvEmpleadosCaras.Rows.Count)
            {
                string nombreCompleto = dgvEmpleadosCaras.Rows[fila].Cells[0].Value.ToString();
                var empleado = empleadosCache.SingleOrDefault(emp => $"{emp.apellidoEmpleado}, {emp.nombreEmpleado}".Equals(nombreCompleto));
                if (empleado == null)
                {
                    MessageBox.Show("No se pudo encontrar el empleado seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                empleadoSeleccionado = empleado;
                caraList = caraRepository.ListarCaras(empleadoSeleccionado.idEmpleado);
                caraIndex = 0;

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

        private void LlenarDGVEmpleadosCarasOptimizado(List<Empleado> empleados)
        {
            dgvEmpleadosCaras.SuspendLayout();
            dgvEmpleadosCaras.Rows.Clear();
            if (dgvEmpleadosCaras.RowCount > 0)
                dgvEmpleadosCaras.RowCount = 0;
            var rows = new List<DataGridViewRow>();
            foreach (var empleado in empleados)
            {
                var row = new DataGridViewRow();
                row.CreateCells(dgvEmpleadosCaras, $"{empleado.apellidoEmpleado}, {empleado.nombreEmpleado}", caraRepository.tieneCaras(empleado.idEmpleado) ? "Si" : "No");
                rows.Add(row);
            }
            if (rows.Count > 0)
                dgvEmpleadosCaras.Rows.AddRange(rows.ToArray());
            dgvEmpleadosCaras.ResumeLayout();
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

                if (pbCamara.Image != null)
                {
                    pbCamara.Image.Dispose();
                }

                pbCamara.Image = tool.Base64ToImage(caraList[index].caraBase64);
                pbCamara.SizeMode = PictureBoxSizeMode.Zoom;

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
            if (pbCamara.Image != null)
            {
                pbCamara.Image.Dispose();
                pbCamara.Image = null;
            }

            ActualizarBotones(false, false, true, false, false);
        }

        private void ActualizarBotones(bool siguiente, bool anterior, bool agregar, bool eliminar, bool texto)
        {
            btnSiguiente.Enabled = siguiente;
            btnAnterior.Enabled = anterior;
            btnAgregarCara.Enabled = agregar;
            btnEliminarCara.Enabled = eliminar;

            lbl.Text = texto ? $"{caraIndex + 1}/{caraList.Count}" : string.Empty;
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

                pbCamara.Visible = true;
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

                if (pbCamara.InvokeRequired)
                {
                    pbCamara.BeginInvoke((MethodInvoker)delegate
                    {
                        try
                        {
                            var oldImage = pbCamara.Image;
                            pbCamara.Image = (Bitmap)bitmap.Clone();
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
                    var oldImage = pbCamara.Image;
                    pbCamara.Image = (Bitmap)bitmap.Clone();
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

                if (pbCamara.InvokeRequired)
                {
                    pbCamara.Invoke((MethodInvoker)delegate
                    {
                        pbCamara.Image?.Dispose();
                        pbCamara.Image = null;
                    });
                }
                else
                {
                    pbCamara.Image?.Dispose();
                    pbCamara.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al detener la cámara: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            string buscar = txtFiltrar.Text.ToLower();
            if (string.IsNullOrEmpty(buscar))
            {
                LlenarDGVEmpleadosCarasOptimizado(empleadosCache);
                return;
            }
            var empleadosFiltrados = empleadosCache
                .Where(emp => emp.nombreEmpleado.ToLower().Contains(buscar) || emp.apellidoEmpleado.ToLower().Contains(buscar))
                .ToList();
            LlenarDGVEmpleadosCarasOptimizado(empleadosFiltrados);
        }
    }
}
