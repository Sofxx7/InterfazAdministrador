using InterfazAdministrador.Data;
using InterfazAdministrador.Tools;
using InterfazAdministrador.Service;
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
        private List<RegistroDiario> registrosDiariosCache;
        private List<EstadoAsistencia> estadosAsistenciaCache;

        public FrmAsistencia()
        {
            InitializeComponent();
            empleadosCache = empleadoRepository.ListarEmpleados();
            estadosAsistenciaCache = estadoAsistenciaRepository.ListarEstadoAsistencia();
            fechasCache = fechaRepository.ObtenerFechas();
            registrosDiariosCache = new List<RegistroDiario>();
            LoadComboBoxes();
            CargarDgvReporte();
            CargarDgvATF();
        }

        private void LoadComboBoxes()
        {
            cmbAno.SelectedIndexChanged -= cmbAno_SelectedIndexChanged;
            cmbMes.SelectedIndexChanged -= cmbMes_SelectedIndexChanged;

            DateTime currentDate = DateTime.Now;
            actualMonth = currentDate.Month;
            actualYear = currentDate.Year.ToString();

            var years = fechasCache.Select(f => f.ano).Distinct().ToList();
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

            LoadMonthsForSelectedYear();

            cmbAno.SelectedIndexChanged += cmbAno_SelectedIndexChanged;
            cmbMes.SelectedIndexChanged += cmbMes_SelectedIndexChanged;
        }

        private void LoadMonthsForSelectedYear()
        {
            if (cmbAno.SelectedItem == null) return;

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
        }

        private void cmbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDgvATF();
            CargarDgvReporte();
        }

        private void cmbAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMonthsForSelectedYear();
            CargarDgvATF();
            CargarDgvReporte();
        }

        private void CargarDgvReporte()
        {
            dgvMostrarReporte.Columns.Clear();
            dgvMostrarReporte.Rows.Clear();

            string mesSeleccionado = cmbMes.SelectedItem?.ToString();
            string anoSeleccionado = cmbAno.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(mesSeleccionado) || string.IsNullOrEmpty(anoSeleccionado))
                return;

            int mesNumero = int.Parse(tool.monthToNumber(mesSeleccionado));

            var registrosJoin = registroDiarioRepository.ListarRegistrosDiariosJoin(anoSeleccionado, mesNumero);

            // Obtener solo los días con registros
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
            dgvMostrarATF.Rows.Clear();

            string mesSeleccionado = cmbMes.SelectedItem?.ToString();
            string anoSeleccionado = cmbAno.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(mesSeleccionado) || string.IsNullOrEmpty(anoSeleccionado))
                return;

            var registrosJoin = registroDiarioRepository.ListarRegistrosDiariosJoin(anoSeleccionado, int.Parse(tool.monthToNumber(mesSeleccionado)));

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

                dgvMostrarATF.Rows.Add(
                    $"{empleado.apellidoEmpleado}, {empleado.nombreEmpleado}",
                    asistencias,
                    tardanzas,
                    faltas
                );
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (dgvMostrarReporte.Rows.Count == 0 && dgvMostrarATF.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.", "Exportar", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            { "Resumen", dgvMostrarATF }
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
