using InterfazAdministrador.Interfaces;
using System;
using System.Windows.Forms;

namespace InterfazAdministrador
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CargarFormulario(Form formulario)
        {
            if (this.pnlContenedor.Controls.Count > 0) this.pnlContenedor.Controls.RemoveAt(0);

            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(formulario);
            this.pnlContenedor.Tag = formulario;
            formulario.Show();

        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            CargarFormulario(new FrmAsistencia());
        }

        private void btnDatosBiometricos_Click(object sender, EventArgs e)
        {
            CargarFormulario(new FrmDatosBiometricos());
        }
    }
}
