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

namespace Aplicacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool ValidarUsuario(string nombreUsuario, string contraseña)
        {
            // Agrega tu lógica de validación de usuario aquí.
            // Reemplaza el siguiente ejemplo con la validación real que necesitas.
            if (nombreUsuario == "usuario" && contraseña == "contraseña")
            {
                return true;
            }
            return false;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
        private bool validarUsuario(string nombreUsuario, string contraseña)
        {
            // Agrega tu lógica de validación de usuario aquí.
            // Reemplaza el siguiente ejemplo con la validación real que necesitas.
            if (nombreUsuario == "pedro22578" && contraseña == "cbtis75")
            {
                return true;
            }
            return false;
        }


        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = textBoxUsuario.Text;
            string contraseña = textContraseña.Text;
            if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(contraseña))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }
            else if (!ValidarUsuario(nombreUsuario, contraseña))
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.");
            }
            else
            {
                FormIngresaste home = new FormIngresaste();
                home.Show();

            }
        }


        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRegistrarse_Click(object sender, EventArgs e)
        {
            FormRegistrate home = new FormRegistrate();
            home.Show();
        }

        private void buttonContraseñaLost_Click(object sender, EventArgs e)
        {
            FormContraseña home = new FormContraseña();
            home.Show();
        }

        private void buttonEstudiantes_Click(object sender, EventArgs e)
        {
            FormEstudiantes home = new FormEstudiantes();
            home.Show();
        }
    }
}
