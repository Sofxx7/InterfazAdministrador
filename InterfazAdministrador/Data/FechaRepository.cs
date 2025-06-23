using System;
using System.Collections.Generic;
using System.Linq;

namespace InterfazAdministrador.Data
{
    internal class FechaRepository
    {
        DataClassesTableDataContext db = new DataClassesTableDataContext();

        public List<Fecha> ObtenerFechas()
        {
            return db.Fecha.ToList();
        }

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

        public Fecha ObtenerFechaPorId(int idFecha)
        {
            var fecha = db.Fecha.FirstOrDefault(f => f.idFecha == idFecha);
            if (fecha == null)
            {
                throw new Exception("Fecha no encontrada");
            }
            return fecha;
        }
    }
}
