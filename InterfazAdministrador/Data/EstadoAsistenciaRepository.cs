using System.Collections.Generic;
using System.Linq;

namespace InterfazAdministrador.Data
{
    internal class EstadoAsistenciaRepository
    {
        DataClassesTableDataContext db = new DataClassesTableDataContext();

        public List<EstadoAsistencia> ListarEstadoAsistencia()
        {
            return db.EstadoAsistencia.ToList();
        }

        public string ObtenerEstadoAsistenciaPorId(int? idEstadoAsistencia)
        {
            if (idEstadoAsistencia == null)
            {
                return "Desconocido";
            }
            var estado = db.EstadoAsistencia.FirstOrDefault(e => e.idEvento == idEstadoAsistencia);
            if (estado != null)
            {
                return estado.nombreEvento;
            }
            else
            {
                return "Desconocido";
            }
        }
    }
}
