using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Restaurant
{
   public class Contexto: DbContext //heredar clases enC#
    {
        public Contexto() : base()
        {

        }

        public DbSet<Producto> Productos { get; set; } //Crea la Lista  Jalando los Datos de Producto BL
    }

}
