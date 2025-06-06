using InterfazAdministrador.Data;
using InterfazAdministrador.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazAdministrador
{
    public partial class FrmMenu : Form
    {
        private readonly EmpleadoRepository empleadoRepository = new EmpleadoRepository();
        private readonly CaraRepository caraRepository = new CaraRepository();
        private Tool tool = new Tool();

        private List<Cara> caraList;
        private int caraIndex = 0;

        public FrmMenu()
        {
            InitializeComponent();

            lblMostrarIniciandoCamara.Text = string.Empty;

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

        private void llenarDGVEmpleadosCaras(List<Empleado> empleados)
        {
            dgvEmpleadosCaras.Rows.Clear();
            foreach (var empleado in empleados)
            {
                dgvEmpleadosCaras.Rows.Add($"{empleado.apellidoEmpleado}, {empleado.nombreEmpleado}", caraRepository.tieneCaras(empleado.idEmpleado) ? "Si" : "No");
            }
        }

        private void dgvEmpleadosCaras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;

            if (fila >= 0 && fila < dgvEmpleadosCaras.Rows.Count)
            {
                string nombreCompleto = dgvEmpleadosCaras.Rows[fila].Cells[0].Value.ToString();
                
                string idEmpleado = empleadoRepository.ListarEmpleados().Single(emp => $"{emp.apellidoEmpleado}, {emp.nombreEmpleado}".Equals(nombreCompleto)).idEmpleado;
                if (idEmpleado == null) MessageBox.Show("No se pudo encontrar el empleado seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
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

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            ActualizarImagenCara(--caraIndex);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            ActualizarImagenCara(++caraIndex);
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
    }
}
