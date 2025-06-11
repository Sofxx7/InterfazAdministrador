using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazAdministrador.Data
{
    internal class EstadoAsistenciaRepository
    {
        DataClassesTableDataContext db = new DataClassesTableDataContext();

        public List<EstadoAsistencia> ListarEstadoAsistencia()
        {
            return db.EstadoAsistencia.ToList();
        }
    }
}
