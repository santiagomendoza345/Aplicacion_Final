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
    public partial class FormRegistrate : Form
    {
        public FormRegistrate()
        {
            InitializeComponent();
        }
        private bool ValidarDatos(string Usuario, string nombreemail, string Contraseña)
        {
            if (Usuario == "pedro22578")
            {
                MessageBox.Show("Error: El nombre de usuario ya está en uso.");
                return false;
            }

            if (nombreemail == "cbtis75@gmail.com")
            {
                MessageBox.Show("Error: El correo electrónico ya está en uso.");
                return false;
            }

            if (Contraseña.Length < 6 || Contraseña.Length > 15)
            {
                MessageBox.Show("Error: La contraseña debe tener entre 6 y 15 caracteres.");
                return false;
            }

            // Si no se cumple ninguna de las condiciones anteriores, entonces los datos son válidos.
            return true;
        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonContraseñaLost_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            FormIngresaste home = new FormIngresaste();
            home.Show();
        }

        private void buttonIngresar1_Click(object sender, EventArgs e)
        {
            string Usuario = textNombreUsuario.Text;
            string nombreemail = textUsuario.Text;
            string Contraseña = textContraseñaR.Text;

            bool datosValidos = true; // Esta variable indica si todos los datos son válidos

            if (string.IsNullOrWhiteSpace(Usuario))
            {
                MessageBox.Show("Por favor, complete el campo de nombre de usuario.");
                datosValidos = false;
            }

            if (string.IsNullOrWhiteSpace(nombreemail))
            {
                MessageBox.Show("Por favor, complete el campo de email.");
                datosValidos = false;
            }

            if (string.IsNullOrWhiteSpace(Contraseña))
            {
                MessageBox.Show("Por favor, complete el campo de contraseña.");
                datosValidos = false;
            }

            if (!ValidarDatos(Usuario, nombreemail, Contraseña))
            {
                datosValidos = false;
            }

            if (datosValidos)
            {
                // Los datos son válidos, puedes proceder
                FormIngresaste home = new FormIngresaste();
                home.Show();
            }

        }


    }
}
