
namespace Aplicacion.Formas
{
    partial class FormRestablecida
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRegistrarse = new System.Windows.Forms.Button();
            this.buttonVolveralnicio1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Font = new System.Drawing.Font("Constantia", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label1.Location = new System.Drawing.Point(72, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Peticion enviada";
            // 
            // buttonRegistrarse
            // 
            this.buttonRegistrarse.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistrarse.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrarse.ForeColor = System.Drawing.Color.SeaGreen;
            this.buttonRegistrarse.Location = new System.Drawing.Point(80, 181);
            this.buttonRegistrarse.Name = "buttonRegistrarse";
            this.buttonRegistrarse.Size = new System.Drawing.Size(301, 26);
            this.buttonRegistrarse.TabIndex = 16;
            this.buttonRegistrarse.Text = "Tu peticion se ha realizado correctamente";
            this.buttonRegistrarse.UseVisualStyleBackColor = false;
            // 
            // buttonVolveralnicio1
            // 
            this.buttonVolveralnicio1.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonVolveralnicio1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVolveralnicio1.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVolveralnicio1.ForeColor = System.Drawing.Color.LemonChiffon;
            this.buttonVolveralnicio1.Location = new System.Drawing.Point(175, 234);
            this.buttonVolveralnicio1.Name = "buttonVolveralnicio1";
            this.buttonVolveralnicio1.Size = new System.Drawing.Size(89, 26);
            this.buttonVolveralnicio1.TabIndex = 17;
            this.buttonVolveralnicio1.Text = "Volver";
            this.buttonVolveralnicio1.UseVisualStyleBackColor = false;
            this.buttonVolveralnicio1.Click += new System.EventHandler(this.buttonVolveralnicio1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Aplicacion.Properties.Resources.ingresaste;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(162, 287);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 103);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // FormRestablecida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(444, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonVolveralnicio1);
            this.Controls.Add(this.buttonRegistrarse);
            this.Controls.Add(this.label1);
            this.Name = "FormRestablecida";
            this.Text = "FormRestablecida";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRegistrarse;
        private System.Windows.Forms.Button buttonVolveralnicio1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}