using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Restaurant
{
   public class ProductosBL
    {
        public ProductosBL()
        {
           
        }
    }
    public class Producto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public int Tipo { get; set; }
        public bool Activo { get; set; }
    }
}
