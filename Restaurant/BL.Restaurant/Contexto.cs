using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Restaurant
{
    public class Contexto : DbContext //heredar clases enC#
    {
        public Contexto() : base("Menu")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)   //Crear Modelo y base de dato
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();// Remueva las tablas pluralizadas
        }

        public DbSet<Producto> Productos { get; set; } //Crea la Lista  Jalando los Datos de Producto BL
    }

}
