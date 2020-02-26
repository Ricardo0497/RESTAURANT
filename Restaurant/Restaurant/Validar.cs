using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    class Validar
    {
        public static void SoloLetras(KeyPressEventArgs v)
        {
         /*if (char.IsLetter(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
                MessageBox.Show("Por Favor Ingrese Solo Letras");
            }*/
        }

        internal static void SoloLetras(EventArgs e)
        {
           
        }

        internal static void SoloLetras(object v)
        {
           
        }
    }
}

       