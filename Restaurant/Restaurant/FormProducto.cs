using BL.Restaurant;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class FormProducto : Form
    {
        ProductosBL _productos;

        public object ListaProductosBindingSource { get; private set; }

        public FormProducto()
        {
            InitializeComponent();

            _productos = new ProductosBL();
            productoBindingSource.DataSource = _productos.ObtenerProductos();

        }


        private void FormProducto_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void productoBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void productoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            var producto = (Producto)productoBindingSource.Current;
           
        }
    }
}
