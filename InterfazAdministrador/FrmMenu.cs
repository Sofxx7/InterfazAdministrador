using InterfazAdministrador.Data;
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
                dgvEmpleadosCaras.Rows.Add($"{empleado.nombreEmpleado} {empleado.apellidoEmpleado}", caraRepository.tieneCaras(empleado.idEmpleado) ? "Si" : "No");
            }
        }
    }
}
