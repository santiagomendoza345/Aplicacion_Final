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
    public partial class FormEstudiantes : Form
    {
        public FormEstudiantes()
        {
            InitializeComponent();
        }

        private void dataEstudiante_Click(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow renglon = (DataGridViewRow)dataEstudiante.Rows[0].Clone();

                renglon.Cells[0].Value = textBox2.Text;
                renglon.Cells[1].Value = textBox1.Text;
                renglon.Cells[2].Value = textBox4.Text;
                renglon.Cells[3].Value = comboBox1.Text;
                renglon.Cells[4].Value = comboBox2.Text;

                dataEstudiante.Rows.Add(renglon);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Agregando estudiante...",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
    }

        private void button2_Click(object sender, EventArgs e)
        {
            string mensaje = "Desea eliminar el resgistro?";
            string titulo = "Eliminando el resgistro...";
            if (!(dataEstudiante.CurrentRow is null ))
                {

                if (MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    dataEstudiante.Rows.Remove(dataEstudiante.CurrentRow);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Eliminado Estudiante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Debes seleccionar un renglón", "Eliminado Estudiante",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataEstudiante.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Debes seleccionar un renglon", "Modificando estudiante",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                textBox2.Text = dataEstudiante.CurrentRow.Cells["Nombre"].Value.ToString();
                textBox1.Text = dataEstudiante.CurrentRow.Cells["Apellidos"].Value.ToString();
                textBox4.Text = dataEstudiante.CurrentRow.Cells["Matricula"].Value.ToString();
                comboBox1.Text = dataEstudiante.CurrentRow.Cells["Carrera"].Value.ToString();
                comboBox2.Text = dataEstudiante.CurrentRow.Cells["Grupo"].Value.ToString();

            }
}
    }
}


