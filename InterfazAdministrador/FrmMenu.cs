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

        private void BtnAsistencia_Click(object sender, EventArgs e)
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

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            gbLogoMenu.Visible = false;
            CargarFormulario(new FrmEmpleados());
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            gbLogoMenu.Visible = false;
            CargarFormulario(new FrmDatosPersonales());
        }

        private void btnDatosBiometricos_Click(object sender, EventArgs e)
        {
            gbLogoMenu.Visible = false;
            CargarFormulario(new FrmDatosBiometricos());
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            gbLogoMenu.Visible = false;
            CargarFormulario(new FrmConfiguracion(administrador.idEmpleado));
        }

        private void btnTurnos_Click(object sender, EventArgs e)
        {
            gbLogoMenu.Visible = false;
            CargarFormulario(new FrmTurnos());
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            gbLogoMenu.Visible = false;
            CargarFormulario(new FrmRoles());
        }

        private void BtnSalir_Click_1(object sender, EventArgs e)
        {
            FrmLoginFiltrado login = new FrmLoginFiltrado();
            login.StartPosition = FormStartPosition.CenterScreen;
            Hide();
            login.FormClosed += (s, args) => this.Close();
            login.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
