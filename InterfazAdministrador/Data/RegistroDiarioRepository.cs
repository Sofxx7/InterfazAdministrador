using System.Collections.Generic;
using System.Linq;

namespace InterfazAdministrador.Data
{
    internal class RegistroDiarioRepository
    {
        DataClassesTableDataContext db = new DataClassesTableDataContext();

        public List<RegistroDiario> ListarRegistrosDiarios(string ano, int mes)
        {
            return db.RegistroDiario
                .Where(r => r.Fecha.ano.Equals(ano) && r.Fecha.mes.Equals(mes))
                .ToList();
        }
    }
}
