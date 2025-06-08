using InterfazAdministrador.Data;
using InterfazAdministrador.Tools;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace InterfazAdministrador.Interfaces
{
    public partial class FrmAsistencia : Form
    {
        private readonly FechaRepository fechaRepository = new FechaRepository();
        private readonly Tool tool = new Tool();

        public FrmAsistencia()
        {
            InitializeComponent();

            cmbAno.DataSource = fechaRepository.ObtenerLosAnos();
            if (cmbAno.Items.Count > 0)
            {
                cmbAno.SelectedIndex = 0;
            }

            cmbMes.DataSource = fechaRepository.ObtenerLosMesesPorAno(cmbAno.SelectedItem.ToString())
                   .Select(mes => tool.numberToMonth(int.Parse(mes)))
                   .ToList();
            if (cmbMes.Items.Count > 0)
            {
                cmbMes.SelectedIndex = cmbMes.Items.Count - 1;
            }
        }
    }
}
