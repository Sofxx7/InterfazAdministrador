using InterfazAdministrador.Data;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazAdministrador
{
    public partial class FrmLogin : Form
    {
        private readonly CredencialRepository credencialRepository = new CredencialRepository();
        private readonly EmpleadoRepository empleadoRepository = new EmpleadoRepository();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

            bool esValido = await credencialRepository.VerificarCredencialesAsync(usuario, contrasena);
            Empleado empleado = empleadoRepository.ObtenerEmpleadoPorId(usuario);

            if (esValido)
            {
                FrmMenu menu = new FrmMenu(empleado);
                menu.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
