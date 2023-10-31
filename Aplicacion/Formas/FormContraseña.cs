using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aplicacion.Formas;

namespace Aplicacion.Formas
{
    public partial class FormContraseña : Form
    {
        public FormContraseña()
        {
            InitializeComponent();
        }

        private void buttonVolveralnicio1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool Validarusuario(string nombreUsuario, string email)
        {
            // Agrega tu lógica de validación de usuario aquí.
            // Reemplaza el siguiente ejemplo con la validación real que necesitas.
            if (nombreUsuario == "pedro22578" && email == "cbtis75@gmail.com")
            {
                return true;
            }
            return false;
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = textBox2.Text;
            string email = textBox1.Text;
            if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }
            else if (!Validarusuario(nombreUsuario, email))
            {
                MessageBox.Show("Nombre de usuario o email inexistentes.");
            }
            else
            {
                FormIngresaste home = new FormIngresaste();
                home.Show();

            }
        }
    }
}
