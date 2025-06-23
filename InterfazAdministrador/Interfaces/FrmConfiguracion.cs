using InterfazAdministrador.Data;
using InterfazAdministrador.Service;
using System;
using System.Windows.Forms;

namespace InterfazAdministrador.Interfaces
{
    public partial class FrmConfiguracion : Form
    {
        private readonly PasswordService passwordService = new PasswordService();
        private readonly CredencialRepository credencialRepository = new CredencialRepository();
        private string idEmpleado;

        public FrmConfiguracion(string idEmpleado)
        {
            InitializeComponent();
            this.idEmpleado = idEmpleado;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            string contrasenaActual = txtContraActual.Text;
            string nuevaContrasena = txtNuevaContra.Text;
            string repetirContrasena = txtRepetirNuevaContra.Text;

            if (string.IsNullOrWhiteSpace(contrasenaActual) ||
                string.IsNullOrWhiteSpace(nuevaContrasena) ||
                string.IsNullOrWhiteSpace(repetirContrasena))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (nuevaContrasena != repetirContrasena)
            {
                MessageBox.Show("Las nuevas contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool esValida = await credencialRepository.VerificarCredencialesAsync(idEmpleado, contrasenaActual);
            if (!esValida)
            {
                MessageBox.Show("La contraseña actual es incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool actualizada = await credencialRepository.ActualizarContrasenaAsync(idEmpleado, nuevaContrasena);
            if (actualizada)
            {
                MessageBox.Show("Contraseña actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtContraActual.Clear();
                txtNuevaContra.Clear();
                txtRepetirNuevaContra.Clear();
            }
            else
            {
                MessageBox.Show("No se pudo actualizar la contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
