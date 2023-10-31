using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion.Formas
{
    public partial class FormRestablecida : Form
    {
        public FormRestablecida()
        {
            InitializeComponent();
        }

        private void buttonVolveralnicio1_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
        }
    }
}
