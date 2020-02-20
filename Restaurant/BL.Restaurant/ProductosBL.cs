using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Restaurant
{
   public class ProductosBL
    {
       public  BindingList<Producto> ListaProductos { get; set; }


        public ProductosBL()
        {
            ListaProductos = new BindingList<Producto>();

            var producto1 = new Producto();
            producto1.Id = 001;
            producto1.Descripcion = "Baleadas";
            producto1.Cantidad = 500;
            producto1.Precio = 18;
            producto1.Tipo = "Desayuno"; 
            producto1.Activo = true;

            ListaProductos.Add(producto1);

            var producto2 = new Producto();
            producto2.Id = 002;
            producto2.Descripcion = "Pollo Chuco";
            producto2.Cantidad = 500;
            producto2.Precio = 70;
            producto2.Tipo = "Almuerzo";
            producto2.Activo = true;

            ListaProductos.Add(producto2);

            var producto3 = new Producto();
            producto3.Id = 003;
            producto3.Descripcion = "Chuleta con Tajadas";
            producto3.Cantidad = 500;
            producto3.Precio = 18;
            producto3.Tipo = "Cena";
            producto3.Activo = true;

            ListaProductos.Add(producto3);

            var producto4 = new Producto();
            producto4.Id = 004;
            producto4.Descripcion = "Pastel";
            producto4.Cantidad = 500;
            producto4.Precio = 18;
            producto4.Tipo = "Postre";
            producto4.Activo = true;

            ListaProductos.Add(producto4);

            var producto5 = new Producto();
            producto5.Id = 005;
            producto5.Descripcion = "Caldo de Pollo";
            producto5.Cantidad = 500;
            producto5.Precio = 18;
            producto5.Tipo = "Entradas";
            producto5.Activo = true;

            ListaProductos.Add(producto5);

            var producto6 = new Producto();
            producto6.Id = 006;
            producto6.Descripcion = "Coca-Cola";
            producto6.Cantidad = 500;
            producto6.Precio = 18;
            producto6.Tipo = "Refrescos";
            producto6.Activo = true;

            ListaProductos.Add(producto6);


        }


        public BindingList<Producto> ObtenerProductos()
        {
            return ListaProductos;
        }
    }

    public class Producto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public string Tipo { get; set; }
        public bool Activo { get; set; }
    }
}
