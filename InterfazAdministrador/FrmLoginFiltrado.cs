using InterfazAdministrador.Data;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace InterfazAdministrador
{
    public partial class FrmLoginFiltrado : Form
    {
        private readonly CredencialRepository credencialRepository = new CredencialRepository();
        private readonly EmpleadoRepository empleadoRepository = new EmpleadoRepository();

        public FrmLoginFiltrado()
        {
            InitializeComponent();
            this.Load += FrmLoginFiltrado_Load;
        }

        private void FrmLoginFiltrado_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(FrmLoginFiltrado_KeyDown);
        }

        private void FrmLoginFiltrado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
                e.Handled = true;
            }
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;
            int intentos = 0;

            bool esValido = await credencialRepository.VerificarCredencialesAsync(usuario, contrasena);
            Empleado empleado = empleadoRepository.ObtenerEmpleadoPorId(usuario);

            if (intentos != 3)
            {
                if (esValido)
                {
                    FrmMenu menu = new FrmMenu(empleado);
                    menu.StartPosition = FormStartPosition.CenterScreen;
                    Hide();
                    menu.FormClosed += (s, args) => this.Close();
                    menu.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intentos += 1;
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Regex ValidarNumero = new Regex("^\\d+$");
                string texto = txtUsuario.Text;
                int selStart = txtUsuario.SelectionStart;
                if (!ValidarNumero.IsMatch(texto) || texto.Length > 8)
                {
                    if (texto.Length > 0)
                    {
                        txtUsuario.Text = texto.Remove(selStart - 1, 1);
                        txtUsuario.SelectionStart = selStart - 1;
                    }
                    else
                    {
                        txtUsuario.Text = "";
                        txtUsuario.SelectionStart = 0;
                    }
                    return;
                }
            }
            catch (Exception ex)
            {
                ex = new Exception("Error al procesar el texto del código.", ex);
            }
        }
    }
}
