using System.Collections.Generic;
using System.Linq;

namespace InterfazAdministrador.Data
{
    internal class CaraRepository
    {
        DataClassesTableDataContext db = new DataClassesTableDataContext();

        public bool tieneCaras(string idEmpleado)
        {
            return db.Cara.Any(c => c.idEmpleado.Equals(idEmpleado));
        }
    }
}
