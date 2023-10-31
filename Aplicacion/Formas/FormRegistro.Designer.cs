
namespace Aplicacion.Formas
{
    partial class FormRegistro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonRegistrarse = new System.Windows.Forms.Button();
            this.buttonVolveralInicioS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRegistrarse
            // 
            this.buttonRegistrarse.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistrarse.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrarse.ForeColor = System.Drawing.Color.SeaGreen;
            this.buttonRegistrarse.Location = new System.Drawing.Point(90, 220);
            this.buttonRegistrarse.Name = "buttonRegistrarse";
            this.buttonRegistrarse.Size = new System.Drawing.Size(288, 26);
            this.buttonRegistrarse.TabIndex = 15;
            this.buttonRegistrarse.Text = "Te has registrado correctamente";
            this.buttonRegistrarse.UseVisualStyleBackColor = false;
            // 
            // buttonVolveralInicioS
            // 
            this.buttonVolveralInicioS.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonVolveralInicioS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVolveralInicioS.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVolveralInicioS.ForeColor = System.Drawing.Color.LemonChiffon;
            this.buttonVolveralInicioS.Location = new System.Drawing.Point(145, 277);
            this.buttonVolveralInicioS.Name = "buttonVolveralInicioS";
            this.buttonVolveralInicioS.Size = new System.Drawing.Size(187, 26);
            this.buttonVolveralInicioS.TabIndex = 16;
            this.buttonVolveralInicioS.Text = "Volver al Inicio de Sesión";
            this.buttonVolveralInicioS.UseVisualStyleBackColor = false;
            this.buttonVolveralInicioS.Click += new System.EventHandler(this.buttonVolveralInicio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Font = new System.Drawing.Font("Constantia", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label1.Location = new System.Drawing.Point(94, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "En hora buena!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Aplicacion.Properties.Resources.ingresaste;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(178, 328);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 103);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // FormRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(463, 493);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonVolveralInicioS);
            this.Controls.Add(this.buttonRegistrarse);
            this.Controls.Add(this.label1);
            this.Name = "FormRegistro";
            this.Text = "FormRegistro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonRegistrarse;
        private System.Windows.Forms.Button buttonVolveralInicioS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}