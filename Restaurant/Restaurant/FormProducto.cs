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
            if (idTextBox.Text!= "")
            {
                var id = Convert.ToInt32(idTextBox.Text);
                Eliminar(id);
        }
        }

        private void Eliminar(int id)
        {
           
            var resultado = _productos.EliminarProducto(id);

            if (resultado == true)
            {
                productoBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Error al Eliminar Producto");
            }
        }

        private void productoBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void productoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            productoBindingSource.EndEdit(); 

            var producto = (Producto)productoBindingSource.Current;

            var resultado = _productos.GuardarProducto(producto);
            
            if (resultado== true)
            {
                productoBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true); 
            }
            else
            {
                MessageBox.Show("Error al guardar producto");
            }
           
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _productos.AgregarProducto();
            productoBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);
        }

        private void DeshabilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;


            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripButtomCancelar.Visible = !valor; 
        }

        private void toolStripButtomCancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarHabilitarBotones(true);
            Eliminar(0);
        }
    }
}
