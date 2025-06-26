using InterfazAdministrador.Data;
using InterfazAdministrador.Service;
using InterfazAdministrador.Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace InterfazAdministrador.Interfaces
{
    public partial class FrmAsistencia : Form
    {
        private readonly FechaRepository fechaRepository = new FechaRepository();
        private readonly EmpleadoRepository empleadoRepository = new EmpleadoRepository();
        private readonly RegistroDiarioRepository registroDiarioRepository = new RegistroDiarioRepository();
        private readonly EstadoAsistenciaRepository estadoAsistenciaRepository = new EstadoAsistenciaRepository();
        private readonly Tool tool = new Tool();

        private int actualMonth;
        private string actualYear;

        private List<Fecha> fechasCache;
        private List<Empleado> empleadosCache;

        public FrmAsistencia()
        {
            InitializeComponent();
            CargarDatosIniciales();
        }

        private async void CargarDatosIniciales()
        {
            try
            {
                var empleadosTask = System.Threading.Tasks.Task.Run(() => empleadoRepository.ListarEmpleados());
                var fechasTask = System.Threading.Tasks.Task.Run(() => fechaRepository.ObtenerFechas());
                empleadosCache = await empleadosTask;
                fechasCache = await fechasTask;
                if (empleadosCache == null || empleadosCache.Count == 0)
                {
                    MessageBox.Show("No hay empleados registrados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (fechasCache == null || fechasCache.Count == 0)
                {
                    MessageBox.Show("No hay fechas registradas.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                LoadComboBoxes();
                CargarDgvReporte();
                CargarDgvATF();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos iniciales: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadComboBoxes()
        {
            cmbAno.SelectedIndexChanged -= cmbAno_SelectedIndexChanged;
            cmbMes.SelectedIndexChanged -= cmbMes_SelectedIndexChanged;

            DateTime currentDate = DateTime.Now;
            actualMonth = currentDate.Month;
            actualYear = currentDate.Year.ToString();

            var years = fechasCache?.Select(f => f.ano).Distinct().ToList();
            if (years != null && years.Any())
            {
                cmbAno.DataSource = years;

                if (years.Contains(actualYear))
                {
                    cmbAno.SelectedItem = actualYear;
                }
                else
                {
                    cmbAno.SelectedIndex = cmbAno.Items.Count - 1;
                    actualYear = cmbAno.SelectedItem?.ToString() ?? actualYear;
                }
            }
            else
            {
                cmbAno.DataSource = null;
                cmbMes.DataSource = null;
                return;
            }

            LoadMonthsForSelectedYear();

            cmbAno.SelectedIndexChanged += cmbAno_SelectedIndexChanged;
            cmbMes.SelectedIndexChanged += cmbMes_SelectedIndexChanged;
        }

        private void LoadMonthsForSelectedYear()
        {
            if (cmbAno.SelectedItem == null) { cmbMes.DataSource = null; return; }

            string selectedYear = cmbAno.SelectedItem.ToString();
            var months = fechasCache
                .Where(f => f.ano == selectedYear)
                .Select(f => f.mes)
                .Distinct()
                .ToList();

            if (months != null && months.Any())
            {
                var monthNames = months
                    .Select(mes => new
                    {
                        Number = int.Parse(mes),
                        Name = tool.numberToMonth(int.Parse(mes))
                    })
                    .OrderBy(m => m.Number)
                    .Select(m => m.Name)
                    .ToList();

                cmbMes.DataSource = monthNames;

                if (selectedYear == DateTime.Now.Year.ToString())
                {
                    string currentMonthName = tool.numberToMonth(actualMonth);
                    int currentMonthIndex = monthNames.IndexOf(currentMonthName);

                    if (currentMonthIndex >= 0)
                    {
                        cmbMes.SelectedIndex = currentMonthIndex;
                    }
                    else
                    {
                        cmbMes.SelectedIndex = cmbMes.Items.Count - 1;
                    }
                }
                else
                {
                    cmbMes.SelectedIndex = cmbMes.Items.Count - 1;
                }
            }
            else
            {
                cmbMes.DataSource = null;
            }
        }

        private void cmbAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMonthsForSelectedYear();
            CargarDgvATF();
            CargarDgvReporte();
        }

        private void cmbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDgvATF();
            CargarDgvReporte();
        }

        private void CargarDgvReporte()
        {
            dgvMostrarReporte.Columns.Clear();
            dgvMostrarReporte.Rows.Clear();

            string mesSeleccionado = cmbMes.SelectedItem?.ToString();
            string anoSeleccionado = cmbAno.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(mesSeleccionado) || string.IsNullOrEmpty(anoSeleccionado)) return;

            int mesNumero;
            if (!int.TryParse(tool.monthToNumber(mesSeleccionado), out mesNumero))
            {
                MessageBox.Show("Mes seleccionado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var registrosJoin = registroDiarioRepository.ListarRegistrosDiariosJoin(anoSeleccionado, mesNumero);
            if (registrosJoin == null || registrosJoin.Count == 0) return;

            var diasConRegistros = registrosJoin
                .Select(x => int.Parse(x.fecha.dia))
                .Distinct()
                .OrderBy(d => d)
                .ToList();

            dgvMostrarReporte.Columns.Add("Empleado", "Empleado");
            dgvMostrarReporte.Columns[0].Width = 170;
            foreach (var dia in diasConRegistros)
            {
                int colIndex = dgvMostrarReporte.Columns.Add($"Dia{dia}", dia.ToString());
                dgvMostrarReporte.Columns[colIndex].Width = 30;
            }

            dgvMostrarReporte.RowTemplate.Height = 30;

            var estadoPorEmpleadoDia = new Dictionary<string, Dictionary<int, string>>();
            foreach (var x in registrosJoin)
            {
                var empleado = x.empleado;
                var fecha = x.fecha;
                var estado = x.estado;
                int dia = int.Parse(fecha.dia);
                string idEmpleado = empleado.idEmpleado;
                string simbolo = "";
                if (estado != null)
                {
                    if (estado.nombreEvento == "Asistencia") simbolo = "A";
                    else if (estado.nombreEvento == "Falta") simbolo = "F";
                    else if (estado.nombreEvento == "Justificado") simbolo = "J";
                    else simbolo = "T";
                }
                else
                {
                    simbolo = "F";
                }
                if (!estadoPorEmpleadoDia.ContainsKey(idEmpleado))
                    estadoPorEmpleadoDia[idEmpleado] = new Dictionary<int, string>();
                estadoPorEmpleadoDia[idEmpleado][dia] = simbolo;
            }

            foreach (var empleado in empleadosCache)
            {
                var fila = new List<object>();
                fila.Add($"{empleado.apellidoEmpleado}, {empleado.nombreEmpleado}");
                foreach (var dia in diasConRegistros)
                {
                    string simbolo = "";
                    if (estadoPorEmpleadoDia.ContainsKey(empleado.idEmpleado) && estadoPorEmpleadoDia[empleado.idEmpleado].ContainsKey(dia))
                        simbolo = estadoPorEmpleadoDia[empleado.idEmpleado][dia];
                    else
                        simbolo = "";
                    fila.Add(simbolo);
                }
                dgvMostrarReporte.Rows.Add(fila.ToArray());
            }
        }

        private void CargarDgvATF()
        {
            dgvResumen.Rows.Clear();

            string mesSeleccionado = cmbMes.SelectedItem?.ToString();
            string anoSeleccionado = cmbAno.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(mesSeleccionado) || string.IsNullOrEmpty(anoSeleccionado))
                return;

            int mesNumero;
            if (!int.TryParse(tool.monthToNumber(mesSeleccionado), out mesNumero))
            {
                MessageBox.Show("Mes seleccionado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var registrosJoin = registroDiarioRepository.ListarRegistrosDiariosJoin(anoSeleccionado, mesNumero);
            if (registrosJoin == null || registrosJoin.Count == 0) return;

            var empleadosAgrupados = registrosJoin
                .GroupBy(x => x.empleado)
                .ToList();

            foreach (var grupo in empleadosAgrupados)
            {
                int asistencias = 0;
                int tardanzas = 0;
                int faltas = 0;
                var empleado = grupo.Key;

                foreach (var x in grupo)
                {
                    var registro = x.registro;
                    var estado = x.estado;

                    if (registro.horaEntrada.HasValue)
                    {
                        var nombreEstado = estado?.nombreEvento ?? string.Empty;
                        if (nombreEstado.Equals("Asistencia"))
                        {
                            asistencias++;
                        }
                        else if (nombreEstado.Equals("Falta"))
                        {
                            faltas++;
                        }
                        else
                        {
                            tardanzas++;
                        }
                    }
                    else
                    {
                        faltas++;
                    }
                }

                dgvResumen.Rows.Add(
                    $"{empleado.apellidoEmpleado}, {empleado.nombreEmpleado}",
                    asistencias,
                    tardanzas,
                    faltas
                );
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if ((dgvMostrarReporte.Rows == null || dgvMostrarReporte.Rows.Count == 0) && (dgvResumen.Rows == null || dgvResumen.Rows.Count == 0))
            {
                MessageBox.Show("No hay datos para exportar.", "Exportar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cmbMes.SelectedItem == null || cmbAno.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un año y un mes antes de exportar.", "Exportar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string mes = cmbMes.SelectedItem?.ToString() ?? "Mes";
            string ano = cmbAno.SelectedItem?.ToString() ?? "Año";
            string defaultFileName = $"{mes}{ano}.xlsx";

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Archivos Excel (*.xlsx)|*.xlsx";
                sfd.FileName = defaultFileName;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var excelService = new ExcelServicecs();
                        var grids = new Dictionary<string, DataGridView>
                        {
                            { "Reporte", dgvMostrarReporte },
                            { "Resumen", dgvResumen }
                        };
                        excelService.ExportMultipleDataGridViewsToExcel(grids, sfd.FileName);
                        MessageBox.Show("Exportación exitosa.", "Exportar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show($"Error al guardar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
