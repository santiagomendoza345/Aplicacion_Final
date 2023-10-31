
namespace Aplicacion.Formas
{
    partial class FormContraseña
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonRegistrarse = new System.Windows.Forms.Button();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.buttonVolveralnicio1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Font = new System.Drawing.Font("Constantia", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label1.Location = new System.Drawing.Point(51, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Restablecer contraseña";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LemonChiffon;
            this.textBox1.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.SeaGreen;
            this.textBox1.Location = new System.Drawing.Point(122, 179);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(283, 40);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Email";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LemonChiffon;
            this.textBox2.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.SeaGreen;
            this.textBox2.Location = new System.Drawing.Point(122, 123);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(283, 40);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Usuario";
            // 
            // buttonRegistrarse
            // 
            this.buttonRegistrarse.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistrarse.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrarse.ForeColor = System.Drawing.Color.SeaGreen;
            this.buttonRegistrarse.Location = new System.Drawing.Point(122, 238);
            this.buttonRegistrarse.Name = "buttonRegistrarse";
            this.buttonRegistrarse.Size = new System.Drawing.Size(283, 26);
            this.buttonRegistrarse.TabIndex = 15;
            this.buttonRegistrarse.Text = "Ingresa el email que nos proporcionaste ";
            this.buttonRegistrarse.UseVisualStyleBackColor = false;
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIngresar.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIngresar.ForeColor = System.Drawing.Color.LemonChiffon;
            this.buttonIngresar.Location = new System.Drawing.Point(123, 284);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(282, 43);
            this.buttonIngresar.TabIndex = 16;
            this.buttonIngresar.Text = "Restablecer";
            this.buttonIngresar.UseVisualStyleBackColor = false;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // buttonVolveralnicio1
            // 
            this.buttonVolveralnicio1.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonVolveralnicio1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVolveralnicio1.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVolveralnicio1.ForeColor = System.Drawing.Color.LemonChiffon;
            this.buttonVolveralnicio1.Location = new System.Drawing.Point(220, 364);
            this.buttonVolveralnicio1.Name = "buttonVolveralnicio1";
            this.buttonVolveralnicio1.Size = new System.Drawing.Size(89, 26);
            this.buttonVolveralnicio1.TabIndex = 18;
            this.buttonVolveralnicio1.Text = "Volver";
            this.buttonVolveralnicio1.UseVisualStyleBackColor = false;
            this.buttonVolveralnicio1.Click += new System.EventHandler(this.buttonVolveralnicio1_Click);
            // 
            // FormContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 450);
            this.Controls.Add(this.buttonVolveralnicio1);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.buttonRegistrarse);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Name = "FormContraseña";
            this.Text = "FormContraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonRegistrarse;
        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.Button buttonVolveralnicio1;
    }
}