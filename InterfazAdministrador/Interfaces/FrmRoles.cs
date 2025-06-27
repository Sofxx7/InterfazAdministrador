using InterfazAdministrador.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace InterfazAdministrador.Interfaces
{
    public partial class FrmRoles : Form
    {
        private readonly RolRepository rolRespository = new RolRepository();
        private List<Rol> roles;


        public FrmRoles()
        {
            InitializeComponent();

            roles = rolRespository.ObtenerRoles();
            llenarDGV(roles);

            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnAgregar.Enabled = true;
        }

        private void llenarDGV(List<Rol> roles)
        {
            dgvRoles.Rows.Clear();

            foreach (var rol in roles)
            {
                dgvRoles.Rows.Add(rol.nombreRol);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Debe llenar el campo para poder agregar un nuevo rol.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var existeRol = roles.Any(r => r.nombreRol.ToLower().Equals(txtNombre.Text.ToLower()));
            if (existeRol)
            {
                MessageBox.Show("El nombre de rol ingresado ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var nuevoRol = new Rol()
            {
                nombreRol = txtNombre.Text
            };
            rolRespository.AgregarRol(nuevoRol);
            MessageBox.Show("Rol agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            roles = rolRespository.ObtenerRoles();
            llenarDGV(roles);
            txtNombre.Text = string.Empty;
            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Debe llenar el campo para poder eliminar un nuevo rol.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var existeRol = roles.Any(r => r.nombreRol.ToLower().Equals(txtNombre.Text.ToLower()));
            if (!existeRol)
            {
                MessageBox.Show("El nombre de rol ingresado no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int personmasConRol = rolRespository.NumEmpleadosConRol(txtNombre.Text);
            if (personmasConRol > 0)
            {
                MessageBox.Show("No se puede eliminar el rol porque hay empleados asignados a él.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show($"¿Está seguro de que desea eliminar el rol: {txtNombre.Text}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                bool eliminado = rolRespository.EliminarRol(txtNombre.Text);
                if (eliminado)
                {
                    MessageBox.Show("Rol eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    roles = rolRespository.ObtenerRoles();
                    llenarDGV(roles);
                }
                else
                {
                    MessageBox.Show("Error al eliminar el rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtNombre.Text = string.Empty;                
                btnAgregar.Enabled = true;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var existeRol = roles.Any(r => r.nombreRol.ToLower().Equals(txtNombre.Text.ToLower()));
            if (existeRol)
            {
                MessageBox.Show("El nombre de rol ingresado ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var rol = new Rol()
            {
                nombreRol = txtNombre.Text
            };

            rolRespository.ActualizarRol(rol);
            MessageBox.Show("Rol modificado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtNombre.Text = string.Empty;
            roles = rolRespository.ObtenerRoles();
            llenarDGV(roles);
            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void dgvRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;

            if (fila >= 0 && fila < dgvRoles.Rows.Count)
            {
                btnAgregar.Enabled = false;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;

                string rol = dgvRoles.Rows[fila].Cells[0].Value.ToString();

                txtNombre.Text = rol;
            }
        }
    }
}
