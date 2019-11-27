namespace Proyecto
{
    partial class NuevaReserva
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
            this.components = new System.ComponentModel.Container();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.btnValidar = new System.Windows.Forms.Button();
            this.lblValidacionIDDest = new System.Windows.Forms.Label();
            this.lblValidacionNroPres = new System.Windows.Forms.Label();
            this.lblValidacionNroCliente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDPaqueteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.llegadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verTodosLosPaquetesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paqueteDataSet = new Proyecto.PaqueteDataSet();
            this.paqueteDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.verTodosLosPaquetesTableAdapter = new Proyecto.PaqueteDataSetTableAdapters.verTodosLosPaquetesTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDDestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreLocalidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plazas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.destinoTableAdapter = new Proyecto.PaqueteDataSetTableAdapters.destinoTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.nClieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreApellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new Proyecto.PaqueteDataSetTableAdapters.clienteTableAdapter();
            this.grpSena = new System.Windows.Forms.GroupBox();
            this.btnCrearReserva = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSena = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verTodosLosPaquetesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paqueteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paqueteDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.grpSena.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.btnValidar);
            this.grpDatos.Controls.Add(this.lblValidacionIDDest);
            this.grpDatos.Controls.Add(this.lblValidacionNroPres);
            this.grpDatos.Controls.Add(this.lblValidacionNroCliente);
            this.grpDatos.Controls.Add(this.label3);
            this.grpDatos.Controls.Add(this.txtDes);
            this.grpDatos.Controls.Add(this.label2);
            this.grpDatos.Controls.Add(this.txtPres);
            this.grpDatos.Controls.Add(this.label1);
            this.grpDatos.Controls.Add(this.txtCliente);
            this.grpDatos.Location = new System.Drawing.Point(12, 200);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(458, 100);
            this.grpDatos.TabIndex = 0;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Ingresar Datos";
            // 
            // btnValidar
            // 
            this.btnValidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidar.Location = new System.Drawing.Point(335, 36);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(117, 58);
            this.btnValidar.TabIndex = 10;
            this.btnValidar.Text = "Validar Datos";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // lblValidacionIDDest
            // 
            this.lblValidacionIDDest.AutoSize = true;
            this.lblValidacionIDDest.Location = new System.Drawing.Point(223, 74);
            this.lblValidacionIDDest.Name = "lblValidacionIDDest";
            this.lblValidacionIDDest.Size = new System.Drawing.Size(0, 13);
            this.lblValidacionIDDest.TabIndex = 9;
            // 
            // lblValidacionNroPres
            // 
            this.lblValidacionNroPres.AutoSize = true;
            this.lblValidacionNroPres.Location = new System.Drawing.Point(223, 48);
            this.lblValidacionNroPres.Name = "lblValidacionNroPres";
            this.lblValidacionNroPres.Size = new System.Drawing.Size(0, 13);
            this.lblValidacionNroPres.TabIndex = 8;
            // 
            // lblValidacionNroCliente
            // 
            this.lblValidacionNroCliente.AutoSize = true;
            this.lblValidacionNroCliente.Location = new System.Drawing.Point(223, 22);
            this.lblValidacionNroCliente.Name = "lblValidacionNroCliente";
            this.lblValidacionNroCliente.Size = new System.Drawing.Size(0, 13);
            this.lblValidacionNroCliente.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID Destino";
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(86, 71);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(131, 20);
            this.txtDes.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nro Prespuesto";
            // 
            // txtPres
            // 
            this.txtPres.Location = new System.Drawing.Point(86, 45);
            this.txtPres.Name = "txtPres";
            this.txtPres.Size = new System.Drawing.Size(131, 20);
            this.txtPres.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nro de Cliente";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(86, 19);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(131, 20);
            this.txtCliente.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPaqueteDataGridViewTextBoxColumn,
            this.localidadDataGridViewTextBoxColumn,
            this.hotelDataGridViewTextBoxColumn,
            this.medioDataGridViewTextBoxColumn,
            this.salidaDataGridViewTextBoxColumn,
            this.llegadaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.verTodosLosPaquetesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(679, 88);
            this.dataGridView1.TabIndex = 3;
            // 
            // iDPaqueteDataGridViewTextBoxColumn
            // 
            this.iDPaqueteDataGridViewTextBoxColumn.DataPropertyName = "ID Paquete";
            this.iDPaqueteDataGridViewTextBoxColumn.HeaderText = "ID Paquete";
            this.iDPaqueteDataGridViewTextBoxColumn.Name = "iDPaqueteDataGridViewTextBoxColumn";
            this.iDPaqueteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // localidadDataGridViewTextBoxColumn
            // 
            this.localidadDataGridViewTextBoxColumn.DataPropertyName = "Localidad";
            this.localidadDataGridViewTextBoxColumn.HeaderText = "Localidad";
            this.localidadDataGridViewTextBoxColumn.Name = "localidadDataGridViewTextBoxColumn";
            this.localidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hotelDataGridViewTextBoxColumn
            // 
            this.hotelDataGridViewTextBoxColumn.DataPropertyName = "Hotel";
            this.hotelDataGridViewTextBoxColumn.HeaderText = "Hotel";
            this.hotelDataGridViewTextBoxColumn.Name = "hotelDataGridViewTextBoxColumn";
            this.hotelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // medioDataGridViewTextBoxColumn
            // 
            this.medioDataGridViewTextBoxColumn.DataPropertyName = "Medio";
            this.medioDataGridViewTextBoxColumn.HeaderText = "Medio";
            this.medioDataGridViewTextBoxColumn.Name = "medioDataGridViewTextBoxColumn";
            this.medioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salidaDataGridViewTextBoxColumn
            // 
            this.salidaDataGridViewTextBoxColumn.DataPropertyName = "Salida";
            this.salidaDataGridViewTextBoxColumn.HeaderText = "Salida";
            this.salidaDataGridViewTextBoxColumn.Name = "salidaDataGridViewTextBoxColumn";
            this.salidaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // llegadaDataGridViewTextBoxColumn
            // 
            this.llegadaDataGridViewTextBoxColumn.DataPropertyName = "Llegada";
            this.llegadaDataGridViewTextBoxColumn.HeaderText = "Llegada";
            this.llegadaDataGridViewTextBoxColumn.Name = "llegadaDataGridViewTextBoxColumn";
            this.llegadaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // verTodosLosPaquetesBindingSource
            // 
            this.verTodosLosPaquetesBindingSource.DataMember = "verTodosLosPaquetes";
            this.verTodosLosPaquetesBindingSource.DataSource = this.paqueteDataSet;
            // 
            // paqueteDataSet
            // 
            this.paqueteDataSet.DataSetName = "PaqueteDataSet";
            this.paqueteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paqueteDataSetBindingSource
            // 
            this.paqueteDataSetBindingSource.DataSource = this.paqueteDataSet;
            this.paqueteDataSetBindingSource.Position = 0;
            // 
            // verTodosLosPaquetesTableAdapter
            // 
            this.verTodosLosPaquetesTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDestDataGridViewTextBoxColumn,
            this.nombreLocalidadDataGridViewTextBoxColumn,
            this.Plazas});
            this.dataGridView2.DataSource = this.destinoBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 106);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(329, 88);
            this.dataGridView2.TabIndex = 3;
            // 
            // iDDestDataGridViewTextBoxColumn
            // 
            this.iDDestDataGridViewTextBoxColumn.DataPropertyName = "ID_Dest";
            this.iDDestDataGridViewTextBoxColumn.HeaderText = "ID_Dest";
            this.iDDestDataGridViewTextBoxColumn.Name = "iDDestDataGridViewTextBoxColumn";
            this.iDDestDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreLocalidadDataGridViewTextBoxColumn
            // 
            this.nombreLocalidadDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Localidad";
            this.nombreLocalidadDataGridViewTextBoxColumn.HeaderText = "Nombre_Localidad";
            this.nombreLocalidadDataGridViewTextBoxColumn.Name = "nombreLocalidadDataGridViewTextBoxColumn";
            this.nombreLocalidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Plazas
            // 
            this.Plazas.DataPropertyName = "Plazas";
            this.Plazas.HeaderText = "Plazas";
            this.Plazas.Name = "Plazas";
            this.Plazas.ReadOnly = true;
            // 
            // destinoBindingSource
            // 
            this.destinoBindingSource.DataMember = "destino";
            this.destinoBindingSource.DataSource = this.paqueteDataSet;
            // 
            // destinoTableAdapter
            // 
            this.destinoTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nClieDataGridViewTextBoxColumn,
            this.nombreApellidoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.eMailDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.clienteBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(347, 106);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(344, 88);
            this.dataGridView3.TabIndex = 4;
            // 
            // nClieDataGridViewTextBoxColumn
            // 
            this.nClieDataGridViewTextBoxColumn.DataPropertyName = "N_Clie";
            this.nClieDataGridViewTextBoxColumn.HeaderText = "N_Clie";
            this.nClieDataGridViewTextBoxColumn.Name = "nClieDataGridViewTextBoxColumn";
            this.nClieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreApellidoDataGridViewTextBoxColumn
            // 
            this.nombreApellidoDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Apellido";
            this.nombreApellidoDataGridViewTextBoxColumn.HeaderText = "Nombre_Apellido";
            this.nombreApellidoDataGridViewTextBoxColumn.Name = "nombreApellidoDataGridViewTextBoxColumn";
            this.nombreApellidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "Tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "Tel";
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            this.telDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eMailDataGridViewTextBoxColumn
            // 
            this.eMailDataGridViewTextBoxColumn.DataPropertyName = "E_Mail";
            this.eMailDataGridViewTextBoxColumn.HeaderText = "E_Mail";
            this.eMailDataGridViewTextBoxColumn.Name = "eMailDataGridViewTextBoxColumn";
            this.eMailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.paqueteDataSet;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // grpSena
            // 
            this.grpSena.Controls.Add(this.btnCrearReserva);
            this.grpSena.Controls.Add(this.label4);
            this.grpSena.Controls.Add(this.txtSena);
            this.grpSena.Controls.Add(this.label5);
            this.grpSena.Enabled = false;
            this.grpSena.Location = new System.Drawing.Point(476, 200);
            this.grpSena.Name = "grpSena";
            this.grpSena.Size = new System.Drawing.Size(215, 100);
            this.grpSena.TabIndex = 5;
            this.grpSena.TabStop = false;
            this.grpSena.Text = "Ingresar Seña";
            // 
            // btnCrearReserva
            // 
            this.btnCrearReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearReserva.Location = new System.Drawing.Point(55, 48);
            this.btnCrearReserva.Name = "btnCrearReserva";
            this.btnCrearReserva.Size = new System.Drawing.Size(154, 46);
            this.btnCrearReserva.TabIndex = 14;
            this.btnCrearReserva.Text = "Crear Reserva";
            this.btnCrearReserva.UseVisualStyleBackColor = true;
            this.btnCrearReserva.Click += new System.EventHandler(this.btnCrearReserva_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 13;
            // 
            // txtSena
            // 
            this.txtSena.Location = new System.Drawing.Point(42, 19);
            this.txtSena.Name = "txtSena";
            this.txtSena.Size = new System.Drawing.Size(131, 20);
            this.txtSena.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Seña";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Atras";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NuevaReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 335);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.grpSena);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpDatos);
            this.Name = "NuevaReserva";
            this.Text = "NuevaReserva";
            this.Load += new System.EventHandler(this.NuevaReserva_Load);
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verTodosLosPaquetesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paqueteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paqueteDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.grpSena.ResumeLayout(false);
            this.grpSena.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.BindingSource paqueteDataSetBindingSource;
        private PaqueteDataSet paqueteDataSet;
        private System.Windows.Forms.BindingSource verTodosLosPaquetesBindingSource;
        private PaqueteDataSetTableAdapters.verTodosLosPaquetesTableAdapter verTodosLosPaquetesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPaqueteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn llegadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource destinoBindingSource;
        private PaqueteDataSetTableAdapters.destinoTableAdapter destinoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreLocalidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private PaqueteDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.Label lblValidacionIDDest;
        private System.Windows.Forms.Label lblValidacionNroPres;
        private System.Windows.Forms.Label lblValidacionNroCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPres;
        private System.Windows.Forms.DataGridViewTextBoxColumn nClieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreApellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.GroupBox grpSena;
        private System.Windows.Forms.Button btnCrearReserva;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSena;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plazas;
    }
}