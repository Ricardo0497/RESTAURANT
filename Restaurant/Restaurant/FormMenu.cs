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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();
            MessageBox.Show("Bienvenidos a Nuestro Sistema");
        }

        private void diarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formDiario = new FormDiario ();
            formDiario.MdiParent = this;
            formDiario.Show();
        }
    }
}
