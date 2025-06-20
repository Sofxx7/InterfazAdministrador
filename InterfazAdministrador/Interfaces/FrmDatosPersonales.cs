using InterfazAdministrador.Data;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace InterfazAdministrador.Interfaces
{
    public partial class FrmDatosPersonales : Form
    {
        private readonly EmpleadoRepository empleadoRepository = new EmpleadoRepository();
        private readonly RolRepository rolRepository = new RolRepository();
        private readonly TurnoRepository tenorRepository = new TurnoRepository();

        private Empleado empleadoSeleccionado;
        List<Empleado> empleados;
        private List<Rol> listRoles;
        private List<Turno> listTurnos;

        public FrmDatosPersonales()
        {
            InitializeComponent();

            empleados = empleadoRepository.ListarEmpleados();
            listRoles = rolRepository.ObtenerRoles();
            listTurnos = tenorRepository.ObtenerTurnos();

            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;

            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtDNI.Enabled = false;

            cmbRol.Enabled = false;
            cmbTurno.Enabled = false;

            cmbRol.DataSource = listRoles;
            cmbRol.DisplayMember = "nombreRol";
            cmbRol.ValueMember = "idRol";
            cmbRol.SelectedIndex = -1;

            cmbTurno.DataSource = listTurnos;
            cmbTurno.DisplayMember = "nombreTurno";
            cmbTurno.ValueMember = "idTurno";
            cmbTurno.SelectedIndex = -1;

            llenarDGVEmpleadosCaras(empleados);
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtDNI.Text = string.Empty;
            cmbRol.SelectedIndex = -1;
            cmbTurno.SelectedIndex = -1;
        }

        private void dgvEmpleadosCaras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;

            if (fila >= 0 && fila < dgvEmpleados.Rows.Count)
            {
                btnAgregar.Enabled = false;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;

                string nombreCompleto = dgvEmpleados.Rows[fila].Cells[0].Value.ToString();

                empleadoSeleccionado = empleados.Single(emp => $"{emp.apellidoEmpleado}, {emp.nombreEmpleado}".Equals(nombreCompleto));
                if (empleadoSeleccionado == null) MessageBox.Show("Error al obtener al empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtNombre.Text = empleadoSeleccionado.nombreEmpleado;
                txtApellido.Text = empleadoSeleccionado.apellidoEmpleado;
                txtDNI.Text = empleadoSeleccionado.idEmpleado;
                cmbRol.Text = listRoles.FirstOrDefault(r => r.idRol == empleadoSeleccionado.idRol).nombreRol ?? "No se pudo cargar";
                cmbTurno.Text = listTurnos.FirstOrDefault(t => t.idTurno == empleadoSeleccionado.idTurno).nombreTurno ?? "No se pudo cargar";
            }
        }

        private void btnEliminar_Click(object sender, System.EventArgs e)
        {
            if (empleadoSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un empleado para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show($"¿Está seguro de que desea eliminar al empleado {empleadoSeleccionado.nombreEmpleado} {empleadoSeleccionado.apellidoEmpleado}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                bool eliminado = empleadoRepository.EliminarEmpleado(empleadoSeleccionado.idEmpleado);
                if (eliminado)
                {
                    MessageBox.Show("Empleado eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    llenarDGVEmpleadosCaras(empleados);
                }
                else
                {
                    MessageBox.Show("Error al eliminar el empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LimpiarCampos();
                btnAgregar.Enabled = true;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }

        private void llenarDGVEmpleadosCaras(List<Empleado> empleados)
        {
            dgvEmpleados.Rows.Clear();
            foreach (var empleado in empleados)
            {
                dgvEmpleados.Rows.Add($"{empleado.apellidoEmpleado}, {empleado.nombreEmpleado}");
            }
        }

        private void btnEliminarFiltro_Click(object sender, System.EventArgs e)
        {
            txtFiltrar.Text = string.Empty;
            llenarDGVEmpleadosCaras(empleados);
        }

        private void txtFiltrar_TextChanged(object sender, System.EventArgs e)
        {
            string buscar = txtFiltrar.Text.ToLower();

            if (string.IsNullOrEmpty(buscar)) return;

            List<Empleado> empleadosFiltrados = empleados
                .Where(emp => emp.nombreEmpleado.ToLower().Contains(buscar) || emp.apellidoEmpleado.ToLower().Contains(buscar))
                .ToList();

            llenarDGVEmpleadosCaras(empleadosFiltrados);
        }
    }
}
