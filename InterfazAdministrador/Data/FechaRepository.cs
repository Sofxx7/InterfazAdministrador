using System.Collections.Generic;
using System.Linq;

namespace InterfazAdministrador.Data
{
    internal class FechaRepository
    {
        DataClassesTableDataContext db = new DataClassesTableDataContext();

        public List<string> ObtenerLosAnos()
        {
            var fechas = db.Fecha.ToList();
            return fechas.Select(f => f.ano).Distinct().ToList();
        }

        public List<string> ObtenerLosMesesPorAno(string ano)
        {
            var meses = db.Fecha.Where(f => f.ano.Equals(ano)).Select(f => f.mes).Distinct().ToList();
            return meses;
        }
    }
}
