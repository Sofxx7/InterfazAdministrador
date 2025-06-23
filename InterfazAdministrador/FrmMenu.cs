using InterfazAdministrador.Data;
using InterfazAdministrador.Interfaces;
using System;
using System.Windows.Forms;

namespace InterfazAdministrador
{
    public partial class FrmMenu : Form
    {
        private Empleado administrador;

        public FrmMenu(Empleado empleado)
        {
            InitializeComponent();
            administrador = empleado;

            lblBienvenida.Text = $" Bienvenido(a) {administrador.nombreEmpleado} {administrador.apellidoEmpleado}";
        }

        private void CargarFormulario(Form formulario)
        {
            if (pnlContenedor.Controls.Count > 0) pnlContenedor.Controls.RemoveAt(0);

            formulario.TopLevel = false;
            pnlContenedor.Controls.Add(formulario);
            pnlContenedor.Tag = formulario;
            formulario.Show();

        }

        private void BtnAsistencia_Click_1(object sender, EventArgs e)
        {
            gbLogoMenu.Visible = false;
            CargarFormulario(new FrmAsistencia());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            gbLogoMenu.Visible = false;
            CargarFormulario(new FrmModificar());
        }

        private void btnHorasExtras_Click(object sender, EventArgs e)
        {
            gbLogoMenu.Visible = false;
            CargarFormulario(new FrmHorasExtras());
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            gbLogoMenu.Visible = false;
            CargarFormulario(new FrmEmpleados());
        }

        private void btnDatosPersonales_Click(object sender, EventArgs e)
        {
            gbLogoMenu.Visible = false;
            CargarFormulario(new FrmDatosPersonales());
        }

        private void btnDatosBiometricos_Click(object sender, EventArgs e)
        {
            gbLogoMenu.Visible = false;
            CargarFormulario(new FrmDatosBiometricos());
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            gbLogoMenu.Visible = false;
            CargarFormulario(new FrmConfiguracion(administrador.idEmpleado));
        }

        private void BtnSalir_Click_1(object sender, EventArgs e)
        { 
            Application.Exit();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
