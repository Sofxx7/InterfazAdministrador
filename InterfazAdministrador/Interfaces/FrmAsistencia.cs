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

namespace InterfazAdministrador.Interfaces
{
    public partial class FrmAsistencia : Form
    {
        private readonly FechaRepository fechaRepository = new FechaRepository();

        public FrmAsistencia()
        {
            InitializeComponent();

            cmbAno.DataSource = fechaRepository.ObtenerLosAnos();
            if (cmbAno.Items.Count > 0)
            {
                cmbAno.SelectedIndex = 0;
            }

            cmbMes.DataSource = fechaRepository.ObtenerLosMesesPorAno(cmbAno.SelectedItem.ToString());
            if (cmbMes.Items.Count > 0)
            {
                cmbMes.SelectedIndex = cmbMes.Items.Count - 1;
            }
        }
    }
}
