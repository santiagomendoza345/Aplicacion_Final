
namespace Aplicacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textContraseña = new System.Windows.Forms.TextBox();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.buttonContraseñaLost = new System.Windows.Forms.Button();
            this.buttonRegistrarse = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonEstudiantes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Font = new System.Drawing.Font("Constantia", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label1.Location = new System.Drawing.Point(141, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.BackColor = System.Drawing.Color.LemonChiffon;
            this.textBoxUsuario.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuario.ForeColor = System.Drawing.Color.SeaGreen;
            this.textBoxUsuario.Location = new System.Drawing.Point(106, 171);
            this.textBoxUsuario.Multiline = true;
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(283, 40);
            this.textBoxUsuario.TabIndex = 1;
            this.textBoxUsuario.Text = "Usuario";
            // 
            // textContraseña
            // 
            this.textContraseña.BackColor = System.Drawing.Color.LemonChiffon;
            this.textContraseña.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textContraseña.ForeColor = System.Drawing.Color.SeaGreen;
            this.textContraseña.Location = new System.Drawing.Point(106, 233);
            this.textContraseña.Multiline = true;
            this.textContraseña.Name = "textContraseña";
            this.textContraseña.Size = new System.Drawing.Size(283, 40);
            this.textContraseña.TabIndex = 2;
            this.textContraseña.Text = "Contraseña";
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIngresar.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIngresar.ForeColor = System.Drawing.Color.LemonChiffon;
            this.buttonIngresar.Location = new System.Drawing.Point(106, 289);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(282, 43);
            this.buttonIngresar.TabIndex = 4;
            this.buttonIngresar.Text = "Ingresar";
            this.buttonIngresar.UseVisualStyleBackColor = false;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // buttonContraseñaLost
            // 
            this.buttonContraseñaLost.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonContraseñaLost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContraseñaLost.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContraseñaLost.ForeColor = System.Drawing.Color.SeaGreen;
            this.buttonContraseñaLost.Location = new System.Drawing.Point(155, 349);
            this.buttonContraseñaLost.Name = "buttonContraseñaLost";
            this.buttonContraseñaLost.Size = new System.Drawing.Size(204, 26);
            this.buttonContraseñaLost.TabIndex = 5;
            this.buttonContraseñaLost.Text = "Perdiste la contraseña?";
            this.buttonContraseñaLost.UseVisualStyleBackColor = false;
            this.buttonContraseñaLost.Click += new System.EventHandler(this.buttonContraseñaLost_Click);
            // 
            // buttonRegistrarse
            // 
            this.buttonRegistrarse.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistrarse.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrarse.ForeColor = System.Drawing.Color.SeaGreen;
            this.buttonRegistrarse.Location = new System.Drawing.Point(155, 392);
            this.buttonRegistrarse.Name = "buttonRegistrarse";
            this.buttonRegistrarse.Size = new System.Drawing.Size(204, 26);
            this.buttonRegistrarse.TabIndex = 6;
            this.buttonRegistrarse.Text = "No tienes cuenta? Registrate";
            this.buttonRegistrarse.UseVisualStyleBackColor = false;
            this.buttonRegistrarse.Click += new System.EventHandler(this.buttonRegistrarse_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalir.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.ForeColor = System.Drawing.Color.LemonChiffon;
            this.buttonSalir.Location = new System.Drawing.Point(208, 482);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(89, 26);
            this.buttonSalir.TabIndex = 7;
            this.buttonSalir.Text = "Volver";
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // buttonEstudiantes
            // 
            this.buttonEstudiantes.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonEstudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEstudiantes.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEstudiantes.ForeColor = System.Drawing.Color.SeaGreen;
            this.buttonEstudiantes.Location = new System.Drawing.Point(106, 438);
            this.buttonEstudiantes.Name = "buttonEstudiantes";
            this.buttonEstudiantes.Size = new System.Drawing.Size(283, 26);
            this.buttonEstudiantes.TabIndex = 8;
            this.buttonEstudiantes.Text = "Ir al formulario de estudiantes";
            this.buttonEstudiantes.UseVisualStyleBackColor = false;
            this.buttonEstudiantes.Click += new System.EventHandler(this.buttonEstudiantes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(513, 555);
            this.Controls.Add(this.buttonEstudiantes);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonRegistrarse);
            this.Controls.Add(this.buttonContraseñaLost);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.textContraseña);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textContraseña;
        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.Button buttonContraseñaLost;
        private System.Windows.Forms.Button buttonRegistrarse;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttonEstudiantes;
    }
}

