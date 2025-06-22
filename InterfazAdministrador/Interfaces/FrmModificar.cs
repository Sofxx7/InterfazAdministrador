using InterfazAdministrador.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace InterfazAdministrador.Interfaces
{
    public partial class FrmModificar : Form
    {
        private readonly EmpleadoRepository empleadoRepository = new EmpleadoRepository();
        private readonly FechaRepository fechaRepository = new FechaRepository();
        private readonly EstadoAsistenciaRepository estadoRepository = new EstadoAsistenciaRepository();
        private readonly RegistroDiarioRepository registroRepository = new RegistroDiarioRepository();
        private List<Fecha> fechasCache;
        private List<EstadoAsistencia> estadosAsistencia;

        public FrmModificar()
        {
            InitializeComponent();

            fechasCache = fechaRepository.ObtenerFechas();
            estadosAsistencia = estadoRepository.ListarEstadoAsistencia();
            LoadComboBoxes();
            ConfigurarDgvRegistro();
        }

        private void LoadComboBoxes()
        {
            cmbAno.SelectedIndexChanged -= cmbAno_SelectedIndexChanged;
            cmbMes.SelectedIndexChanged -= cmbMes_SelectedIndexChanged;

            var anos = fechasCache.Select(f => f.ano).Distinct().OrderBy(y => y).ToList();
            cmbAno.DataSource = anos;
            if (anos.Any())
            {
                cmbAno.SelectedIndex = anos.IndexOf(DateTime.Now.Year.ToString());
            }
            else
            {
                cmbAno.SelectedIndex = -1;
            }

            LoadMonthsForSelectedYear();
            LoadDaysForSelectedMonthAndYear();

            cmbAno.SelectedIndexChanged += cmbAno_SelectedIndexChanged;
            cmbMes.SelectedIndexChanged += cmbMes_SelectedIndexChanged;
        }

        private void LoadMonthsForSelectedYear()
        {
            cmbMes.SelectedIndexChanged -= cmbMes_SelectedIndexChanged;
            cmbDia.SelectedIndexChanged -= cmbDia_SelectedIndexChanged;

            if (cmbAno.SelectedItem == null) return;
            string anoSeleccionado = cmbAno.SelectedItem.ToString();
            var meses = fechasCache
                .Where(f => f.ano == anoSeleccionado)
                .Select(f => f.mes)
                .Distinct()
                .OrderBy(m => int.Parse(m))
                .ToList();
            cmbMes.DataSource = meses;
            if (meses.Any())
            {
                string mesActual = DateTime.Now.Month.ToString("D2");
                int idx = meses.IndexOf(mesActual);
                cmbMes.SelectedIndex = idx >= 0 ? idx : meses.Count - 1;
            }
            else
            {
                cmbMes.SelectedIndex = -1;
            }

            LoadDaysForSelectedMonthAndYear();

            cmbMes.SelectedIndexChanged += cmbMes_SelectedIndexChanged;
            cmbDia.SelectedIndexChanged += cmbDia_SelectedIndexChanged;
        }

        private void LoadDaysForSelectedMonthAndYear()
        {
            cmbDia.SelectedIndexChanged -= cmbDia_SelectedIndexChanged;
            if (cmbAno.SelectedItem == null || cmbMes.SelectedItem == null) return;
            string anoSeleccionado = cmbAno.SelectedItem.ToString();
            string mesSeleccionado = cmbMes.SelectedItem.ToString();
            var dias = fechasCache
                .Where(f => f.ano == anoSeleccionado && f.mes == mesSeleccionado)
                .Select(f => f.dia)
                .Distinct()
                .OrderBy(d => int.Parse(d))
                .ToList();
            cmbDia.DataSource = dias;
            if (dias.Any())
            {
                string currentDay = DateTime.Now.Day.ToString("D2");
                int idx = dias.IndexOf(currentDay);
                cmbDia.SelectedIndex = idx >= 0 ? idx : dias.Count - 1;
            }
            else
            {
                cmbDia.SelectedIndex = -1;
            }
            cmbDia.SelectedIndexChanged += cmbDia_SelectedIndexChanged;
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            string buscar = txtFiltrar.Text.ToLower();
            if (string.IsNullOrEmpty(buscar)) return;
        }

        private void cmbDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarRegistros();
        }

        private void cmbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDaysForSelectedMonthAndYear();
            ActualizarRegistros();
        }

        private void cmbAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMonthsForSelectedYear();
            ActualizarRegistros();
        }

        private void ActualizarRegistros()
        {
            dgvRegistro.Rows.Clear();
            if (cmbAno.SelectedItem == null || cmbMes.SelectedItem == null || cmbDia.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un año, mes y día válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string anoSeleccionado = cmbAno.SelectedItem.ToString();
            string mesSeleccionado = cmbMes.SelectedItem.ToString();
            string diaSeleccionado = cmbDia.SelectedItem.ToString();

            List<RegistroDiario> registros = registroRepository.ListarRegistrosDiariosPorFecha(diaSeleccionado, mesSeleccionado, anoSeleccionado);
            if (registros.Count == 0)
            {
                MessageBox.Show("No se encontraron registros para la fecha seleccionada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            foreach (var registro in registros)
            {
                var empleado = empleadoRepository.ObtenerEmpleadoPorId(registro.idEmpleado);
                var estado = estadosAsistencia.FirstOrDefault(e => e.idEvento == registro.idEstadoAsistencia);
                dgvRegistro.Rows.Add(
                    $"{empleado.apellidoEmpleado}, {empleado.nombreEmpleado}",
                    registro.horaEntrada,
                    registro.horaSalida,
                    estado != null ? estado.idEvento : (object)null
                );
            }
        }

        private void ConfigurarDgvRegistro()
        {
            var colEstado = dgvRegistro.Columns["ColEstado"] as DataGridViewComboBoxColumn;
            if (colEstado != null)
            {
                colEstado.DataSource = estadosAsistencia;
                colEstado.DisplayMember = "nombreEvento";
                colEstado.ValueMember = "idEvento"; // Corregido: debe ser idEvento
            }
            // Elimina la suscripción a CellFormatting, ya que no existe el método y no es necesario para el funcionamiento del ComboBox
            // dgvRegistro.CellFormatting += dgvRegistro_CellFormatting;
            dgvRegistro.EditingControlShowing += dgvRegistro_EditingControlShowing;
            dgvRegistro.DataError += dgvRegistro_DataError; // Manejo de errores de ComboBox
        }

        private void dgvRegistro_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Evita que se muestre el cuadro de error predeterminado
            e.ThrowException = false;
            MessageBox.Show("Error de datos en la columna Estado. El valor no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dgvRegistro_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvRegistro.CurrentCell.ColumnIndex == dgvRegistro.Columns["ColEstado"].Index)
            {
                var combo = e.Control as ComboBox;
                if (combo != null)
                {
                    combo.SelectedIndexChanged -= ComboBoxEstado_SelectedIndexChanged;
                    combo.SelectedIndexChanged += ComboBoxEstado_SelectedIndexChanged;

                    int rowIndex = dgvRegistro.CurrentCell.RowIndex;
                    var estadoActual = dgvRegistro.Rows[rowIndex].Cells["ColEstado"].Value;
                    // Buscar por idEvento (int), no por nombreEvento
                    var estadoObj = estadosAsistencia.FirstOrDefault(es => es.idEvento.Equals(estadoActual));
                    if (estadoObj != null && (estadoObj.nombreEvento == "Tardanza" || estadoObj.nombreEvento == "Falta"))
                    {
                        combo.Enabled = true;
                        var justificado = estadosAsistencia.FirstOrDefault(es => es.nombreEvento == "Justificado");
                        var items = new List<EstadoAsistencia> { estadoObj };
                        if (justificado != null && estadoObj.idEvento != justificado.idEvento)
                            items.Add(justificado);
                        combo.DataSource = items;
                        combo.DisplayMember = "nombreEvento";
                        combo.ValueMember = "idEvento";
                    }
                    else
                    {
                        combo.DataSource = estadoObj != null ? new List<EstadoAsistencia> { estadoObj } : new List<EstadoAsistencia>();
                        combo.DisplayMember = "nombreEvento";
                        combo.ValueMember = "idEvento";
                        combo.Enabled = false;
                    }
                }
            }
        }

        private void ComboBoxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Aquí puedes manejar el cambio de estado si necesitas guardar el cambio
        }
    }
}
