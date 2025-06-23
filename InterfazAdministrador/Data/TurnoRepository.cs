using System.Collections.Generic;
using System.Linq;

namespace InterfazAdministrador.Data
{
    internal class TurnoRepository
    {
        DataClassesTableDataContext db = new DataClassesTableDataContext();

        public List<Turno> ObtenerTurnos()
        {
            return db.Turno.ToList();
        }
    }
}
