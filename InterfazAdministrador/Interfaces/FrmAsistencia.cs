using InterfazAdministrador.Data;
using InterfazAdministrador.Tools;
using System;
using System.Collections.Generic;
using System.Data;
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
            CargarDgvReporteDia();
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
        }

        private void cmbAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMonthsForSelectedYear();
            CargarDgvATF();
        }

        private void CargarDgvReporteDia()
        {
            
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
    }
}
