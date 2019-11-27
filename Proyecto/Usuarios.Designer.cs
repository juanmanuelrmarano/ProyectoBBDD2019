namespace Proyecto
{
    partial class frmUsuarios
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblTexto1 = new System.Windows.Forms.Label();
            this.lblTexto2 = new System.Windows.Forms.Label();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(67, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(212, 20);
            this.txtUsuario.TabIndex = 0;
            // 
            // lblTexto1
            // 
            this.lblTexto1.AutoSize = true;
            this.lblTexto1.Location = new System.Drawing.Point(0, 5);
            this.lblTexto1.Name = "lblTexto1";
            this.lblTexto1.Size = new System.Drawing.Size(43, 13);
            this.lblTexto1.TabIndex = 1;
            this.lblTexto1.Text = "Usuario";
            // 
            // lblTexto2
            // 
            this.lblTexto2.AutoSize = true;
            this.lblTexto2.Location = new System.Drawing.Point(0, 31);
            this.lblTexto2.Name = "lblTexto2";
            this.lblTexto2.Size = new System.Drawing.Size(61, 13);
            this.lblTexto2.TabIndex = 2;
            this.lblTexto2.Text = "Contraseña";
            // 
            // txtContra
            // 
            this.txtContra.BackColor = System.Drawing.SystemColors.Window;
            this.txtContra.Location = new System.Drawing.Point(67, 28);
            this.txtContra.Name = "txtContra";
            this.txtContra.PasswordChar = '*';
            this.txtContra.Size = new System.Drawing.Size(212, 20);
            this.txtContra.TabIndex = 3;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(204, 54);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(75, 20);
            this.btnEntrar.TabIndex = 4;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(67, 54);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(131, 20);
            this.btnRegistro.TabIndex = 6;
            this.btnRegistro.Text = "Registrar nuevo usuario";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(287, 82);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.lblTexto2);
            this.Controls.Add(this.lblTexto1);
            this.Controls.Add(this.txtUsuario);
            this.MaximizeBox = false;
            this.Name = "frmUsuarios";
            this.Padding = new System.Windows.Forms.Padding(200);
            this.Text = "Adm. de paquetes - Usuario";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblTexto1;
        private System.Windows.Forms.Label lblTexto2;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnRegistro;


    }
}

