using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda.Core;
using Tienda.Data;

namespace Tienda.Logic
{
    public class PrestamoBL
    {
        public static List<Prestamo> Listar()
        {
            using (var db = new FinancieraEntities())
            {
                return db.Prestamo.ToList();
            }

          
        }
        public static Prestamo Buscar(int id)
        {
            using (var db = new FinancieraEntities())
            {
                return db.Prestamo.Find(id);

            }

        }
    }
}
