using InterfazAdministrador.Tools;
using System.Collections.Generic;
using System.Linq;

namespace InterfazAdministrador.Data
{
    internal class RegistroDiarioRepository
    {
        DataClassesTableDataContext db = new DataClassesTableDataContext();
        private readonly Tool tools = new Tool();

        public List<RegistroDiario> ListarRegistrosDiarios(string ano, int mes)
        {
            return db.RegistroDiario
                .Where(r => r.Fecha.ano.Equals(ano) && r.Fecha.mes.Equals(mes))
                .ToList();
        }

        public List<(RegistroDiario registro, Empleado empleado, EstadoAsistencia estado, Fecha fecha)> ListarRegistrosDiariosJoin(string ano, int mes)
        {
            var query = from r in db.RegistroDiario
                        join e in db.Empleado on r.idEmpleado equals e.idEmpleado
                        join f in db.Fecha on r.idFecha equals f.idFecha
                        join ea in db.EstadoAsistencia on r.idEstadoAsistencia equals ea.idEvento into eaJoin
                        from ea in eaJoin.DefaultIfEmpty()
                        where f.ano == ano && f.mes == mes.ToString()
                        select new { registro = r, empleado = e, estado = ea, fecha = f };

            return query.ToList().Select(x => (x.registro, x.empleado, x.estado, x.fecha)).ToList();
        }

        public List<RegistroDiario> ListarRegistrosDiariosPorFecha(string dia, string mes, string ano)
            {
            var query = from r in db.RegistroDiario
                        join f in db.Fecha on r.idFecha equals f.idFecha
                        where f.dia == dia && f.mes == mes && f.ano == ano
                        select r;
            return query.ToList();
        }

        public bool ActualizarEstadoAsistencia(string idEmpleado, string dia, string mes, string ano, int idEstadoAsistencia)
        {
            var registro = (from r in db.RegistroDiario
                            join f in db.Fecha on r.idFecha equals f.idFecha
                            where r.idEmpleado == idEmpleado && f.dia == dia && f.mes == mes && f.ano == ano
                            select r).FirstOrDefault();
            if (registro == null) return false;
            registro.idEstadoAsistencia = idEstadoAsistencia;
            db.SubmitChanges();
            return true;
        }
    }
}
