using InterfazAdministrador.Data;
using System;
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
        private List<Empleado> empleados;
        private List<Rol> listRoles;
        private List<Turno> listTurnos;

        public FrmDatosPersonales()
        {
            InitializeComponent();
            this.Load += FrmDatosPersonales_Load;
        }

        private void FrmDatosPersonales_Load(object sender, EventArgs e)
        {
            empleados = empleadoRepository.ListarEmpleados();
            listRoles = rolRepository.ObtenerRoles();
            listTurnos = tenorRepository.ObtenerTurnos();

            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnAgregar.Enabled = true;

            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtDNI.Enabled = true;
            cmbRol.Enabled = true;
            cmbTurno.Enabled = true;

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

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
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

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void btnEliminarFiltro_Click(object sender, EventArgs e)
        {
            txtFiltrar.Text = string.Empty;
            llenarDGVEmpleadosCaras(empleados);
        }

        private void llenarDGVEmpleadosCaras(List<Empleado> empleados)
        {
            dgvEmpleados.Rows.Clear();
            foreach (var empleado in empleados)
            {
                dgvEmpleados.Rows.Add($"{empleado.apellidoEmpleado}, {empleado.nombreEmpleado}");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (empleadoSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un empleado para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) || string.IsNullOrWhiteSpace(txtDNI.Text) || cmbRol.SelectedIndex == -1 || cmbTurno.SelectedIndex == -1)
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.TryParse(txtDNI.Text, out int dni) == false)
            {
                MessageBox.Show("El DNI debe ser un número válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtDNI.Text.Length != 8)
            {
                MessageBox.Show("El DNI debe tener exactamente 8 dígitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            empleadoSeleccionado.nombreEmpleado = txtNombre.Text;
            empleadoSeleccionado.apellidoEmpleado = txtApellido.Text;
            empleadoSeleccionado.idEmpleado = txtDNI.Text;
            empleadoSeleccionado.idRol = listRoles.FirstOrDefault(r => r.nombreRol.Equals(cmbRol.Text)).idRol;
            empleadoSeleccionado.idTurno = listTurnos.FirstOrDefault(t => t.nombreTurno.Equals(cmbTurno.Text)).idTurno;

            empleadoRepository.ActualizarEmpleado(empleadoSeleccionado);
            MessageBox.Show("Empleado modificado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarCampos();
            llenarDGVEmpleadosCaras(empleados);
            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) || string.IsNullOrWhiteSpace(txtDNI.Text) || cmbRol.SelectedIndex == -1 || cmbTurno.SelectedIndex == -1)
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.TryParse(txtDNI.Text, out int dni) == false)
            {
                MessageBox.Show("El DNI debe ser un número válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtDNI.Text.Length != 8)
            {
                MessageBox.Show("El DNI debe tener exactamente 8 dígitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (empleadoSeleccionado == null)
            {
                empleadoSeleccionado = new Empleado();
            }

            empleadoSeleccionado.nombreEmpleado = txtNombre.Text;
            empleadoSeleccionado.apellidoEmpleado = txtApellido.Text;
            empleadoSeleccionado.idEmpleado = txtDNI.Text;
            empleadoSeleccionado.idRol = listRoles.FirstOrDefault(r => r.nombreRol.Equals(cmbRol.Text)).idRol;
            empleadoSeleccionado.idTurno = listTurnos.FirstOrDefault(t => t.nombreTurno.Equals(cmbTurno.Text)).idTurno;

            empleadoRepository.AgregarEmpleado(empleadoSeleccionado);
            MessageBox.Show("Empleado agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarCampos();
            llenarDGVEmpleadosCaras(empleados);
            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }
    }
}
