namespace Proyecto
{
    partial class frmPrincipal
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.btnNuevoPaquete = new System.Windows.Forms.Button();
            this.btnHoteles = new System.Windows.Forms.Button();
            this.btnExcursiones = new System.Windows.Forms.Button();
            this.btnTransporte = new System.Windows.Forms.Button();
            this.btnDestino = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnComprobantes = new System.Windows.Forms.Button();
            this.btnPresupuestos = new System.Windows.Forms.Button();
            this.btnReservas = new System.Windows.Forms.Button();
            this.btnNuevaReserva = new System.Windows.Forms.Button();
            this.btnReservasDia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(7, 9);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(100, 25);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(64, 9);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(0, 13);
            this.lblNombreUsuario.TabIndex = 1;
            // 
            // btnNuevoPaquete
            // 
            this.btnNuevoPaquete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoPaquete.Location = new System.Drawing.Point(12, 37);
            this.btnNuevoPaquete.Name = "btnNuevoPaquete";
            this.btnNuevoPaquete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNuevoPaquete.Size = new System.Drawing.Size(172, 84);
            this.btnNuevoPaquete.TabIndex = 2;
            this.btnNuevoPaquete.Text = "Nuevo Paquete";
            this.btnNuevoPaquete.UseVisualStyleBackColor = true;
            this.btnNuevoPaquete.Click += new System.EventHandler(this.btnNuevoPaquete_Click);
            // 
            // btnHoteles
            // 
            this.btnHoteles.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoteles.Location = new System.Drawing.Point(190, 37);
            this.btnHoteles.Name = "btnHoteles";
            this.btnHoteles.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnHoteles.Size = new System.Drawing.Size(151, 39);
            this.btnHoteles.TabIndex = 3;
            this.btnHoteles.Text = "Hoteles";
            this.btnHoteles.UseVisualStyleBackColor = true;
            this.btnHoteles.Click += new System.EventHandler(this.btnPaquetes_Click);
            // 
            // btnExcursiones
            // 
            this.btnExcursiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcursiones.Location = new System.Drawing.Point(190, 82);
            this.btnExcursiones.Name = "btnExcursiones";
            this.btnExcursiones.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnExcursiones.Size = new System.Drawing.Size(151, 39);
            this.btnExcursiones.TabIndex = 4;
            this.btnExcursiones.Text = "Excursiones";
            this.btnExcursiones.UseVisualStyleBackColor = true;
            this.btnExcursiones.Click += new System.EventHandler(this.btnExcursiones_Click);
            // 
            // btnTransporte
            // 
            this.btnTransporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransporte.Location = new System.Drawing.Point(347, 37);
            this.btnTransporte.Name = "btnTransporte";
            this.btnTransporte.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTransporte.Size = new System.Drawing.Size(151, 39);
            this.btnTransporte.TabIndex = 5;
            this.btnTransporte.Text = "Transportes";
            this.btnTransporte.UseVisualStyleBackColor = true;
            this.btnTransporte.Click += new System.EventHandler(this.btnTransporte_Click);
            // 
            // btnDestino
            // 
            this.btnDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDestino.Location = new System.Drawing.Point(347, 82);
            this.btnDestino.Name = "btnDestino";
            this.btnDestino.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDestino.Size = new System.Drawing.Size(151, 39);
            this.btnDestino.TabIndex = 6;
            this.btnDestino.Text = "Destinos";
            this.btnDestino.UseVisualStyleBackColor = true;
            this.btnDestino.Click += new System.EventHandler(this.btnDestino_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Location = new System.Drawing.Point(190, 127);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnClientes.Size = new System.Drawing.Size(151, 39);
            this.btnClientes.TabIndex = 7;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnComprobantes
            // 
            this.btnComprobantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprobantes.Location = new System.Drawing.Point(347, 127);
            this.btnComprobantes.Name = "btnComprobantes";
            this.btnComprobantes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnComprobantes.Size = new System.Drawing.Size(151, 39);
            this.btnComprobantes.TabIndex = 8;
            this.btnComprobantes.Text = "Comprobantes";
            this.btnComprobantes.UseVisualStyleBackColor = true;
            this.btnComprobantes.Click += new System.EventHandler(this.btnComprobantes_Click);
            // 
            // btnPresupuestos
            // 
            this.btnPresupuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPresupuestos.Location = new System.Drawing.Point(190, 172);
            this.btnPresupuestos.Name = "btnPresupuestos";
            this.btnPresupuestos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPresupuestos.Size = new System.Drawing.Size(151, 39);
            this.btnPresupuestos.TabIndex = 9;
            this.btnPresupuestos.Text = "Presupuestos";
            this.btnPresupuestos.UseVisualStyleBackColor = true;
            this.btnPresupuestos.Click += new System.EventHandler(this.btnPresupuestos_Click);
            // 
            // btnReservas
            // 
            this.btnReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservas.Location = new System.Drawing.Point(347, 172);
            this.btnReservas.Name = "btnReservas";
            this.btnReservas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnReservas.Size = new System.Drawing.Size(151, 39);
            this.btnReservas.TabIndex = 10;
            this.btnReservas.Text = "Reservas";
            this.btnReservas.UseVisualStyleBackColor = true;
            this.btnReservas.Click += new System.EventHandler(this.btnReservas_Click);
            // 
            // btnNuevaReserva
            // 
            this.btnNuevaReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaReserva.Location = new System.Drawing.Point(12, 127);
            this.btnNuevaReserva.Name = "btnNuevaReserva";
            this.btnNuevaReserva.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNuevaReserva.Size = new System.Drawing.Size(172, 84);
            this.btnNuevaReserva.TabIndex = 11;
            this.btnNuevaReserva.Text = "Nueva Reserva";
            this.btnNuevaReserva.UseVisualStyleBackColor = true;
            this.btnNuevaReserva.Click += new System.EventHandler(this.btnNuevaReserva_Click);
            // 
            // btnReservasDia
            // 
            this.btnReservasDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservasDia.Location = new System.Drawing.Point(120, 218);
            this.btnReservasDia.Name = "btnReservasDia";
            this.btnReservasDia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnReservasDia.Size = new System.Drawing.Size(246, 39);
            this.btnReservasDia.TabIndex = 12;
            this.btnReservasDia.Text = "Reservas del Dia";
            this.btnReservasDia.UseVisualStyleBackColor = true;
            this.btnReservasDia.Visible = false;
            this.btnReservasDia.Click += new System.EventHandler(this.btnReservasDia_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 269);
            this.Controls.Add(this.btnReservasDia);
            this.Controls.Add(this.btnNuevaReserva);
            this.Controls.Add(this.btnReservas);
            this.Controls.Add(this.btnPresupuestos);
            this.Controls.Add(this.btnComprobantes);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnDestino);
            this.Controls.Add(this.btnTransporte);
            this.Controls.Add(this.btnExcursiones);
            this.Controls.Add(this.btnHoteles);
            this.Controls.Add(this.btnNuevoPaquete);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Name = "frmPrincipal";
            this.Text = "Adm. de paquetes - Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Button btnNuevoPaquete;
        private System.Windows.Forms.Button btnHoteles;
        private System.Windows.Forms.Button btnExcursiones;
        private System.Windows.Forms.Button btnTransporte;
        private System.Windows.Forms.Button btnDestino;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnComprobantes;
        private System.Windows.Forms.Button btnPresupuestos;
        private System.Windows.Forms.Button btnReservas;
        private System.Windows.Forms.Button btnNuevaReserva;
        private System.Windows.Forms.Button btnReservasDia;
    }
}