using System.Collections.Generic;
using System.Linq;

namespace InterfazAdministrador.Data
{
    internal class RegistroDiarioRepository
    {
        DataClassesTableDataContext db = new DataClassesTableDataContext();

        public List<RegistroDiario> ListarRegistrosDiarios()
        {
            return db.RegistroDiario.ToList();
        }
    }
}
