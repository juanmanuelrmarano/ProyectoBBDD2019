namespace Proyecto
{
    partial class AgregarExcursionesPaquete
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.paqueteDataSet = new Proyecto.PaqueteDataSet();
            this.excursionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.excursionTableAdapter = new Proyecto.PaqueteDataSetTableAdapters.excursionTableAdapter();
            this.iDExcurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actividadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plazasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRealizacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtExc = new System.Windows.Forms.TextBox();
            this.btnAgregarExc = new System.Windows.Forms.Button();
            this.btnEliminarExc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paqueteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.excursionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDExcurDataGridViewTextBoxColumn,
            this.iDDestDataGridViewTextBoxColumn,
            this.actividadDataGridViewTextBoxColumn,
            this.duracionDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.plazasDataGridViewTextBoxColumn,
            this.fechaRealizacionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.excursionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(746, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // paqueteDataSet
            // 
            this.paqueteDataSet.DataSetName = "PaqueteDataSet";
            this.paqueteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // excursionBindingSource
            // 
            this.excursionBindingSource.DataMember = "excursion";
            this.excursionBindingSource.DataSource = this.paqueteDataSet;
            // 
            // excursionTableAdapter
            // 
            this.excursionTableAdapter.ClearBeforeFill = true;
            // 
            // iDExcurDataGridViewTextBoxColumn
            // 
            this.iDExcurDataGridViewTextBoxColumn.DataPropertyName = "ID_Excur";
            this.iDExcurDataGridViewTextBoxColumn.HeaderText = "ID_Excur";
            this.iDExcurDataGridViewTextBoxColumn.Name = "iDExcurDataGridViewTextBoxColumn";
            // 
            // iDDestDataGridViewTextBoxColumn
            // 
            this.iDDestDataGridViewTextBoxColumn.DataPropertyName = "ID_Dest";
            this.iDDestDataGridViewTextBoxColumn.HeaderText = "ID_Dest";
            this.iDDestDataGridViewTextBoxColumn.Name = "iDDestDataGridViewTextBoxColumn";
            // 
            // actividadDataGridViewTextBoxColumn
            // 
            this.actividadDataGridViewTextBoxColumn.DataPropertyName = "Actividad";
            this.actividadDataGridViewTextBoxColumn.HeaderText = "Actividad";
            this.actividadDataGridViewTextBoxColumn.Name = "actividadDataGridViewTextBoxColumn";
            // 
            // duracionDataGridViewTextBoxColumn
            // 
            this.duracionDataGridViewTextBoxColumn.DataPropertyName = "Duracion";
            this.duracionDataGridViewTextBoxColumn.HeaderText = "Duracion";
            this.duracionDataGridViewTextBoxColumn.Name = "duracionDataGridViewTextBoxColumn";
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            // 
            // plazasDataGridViewTextBoxColumn
            // 
            this.plazasDataGridViewTextBoxColumn.DataPropertyName = "Plazas";
            this.plazasDataGridViewTextBoxColumn.HeaderText = "Plazas";
            this.plazasDataGridViewTextBoxColumn.Name = "plazasDataGridViewTextBoxColumn";
            // 
            // fechaRealizacionDataGridViewTextBoxColumn
            // 
            this.fechaRealizacionDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Realizacion";
            this.fechaRealizacionDataGridViewTextBoxColumn.HeaderText = "Fecha_Realizacion";
            this.fechaRealizacionDataGridViewTextBoxColumn.Name = "fechaRealizacionDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Excursion";
            // 
            // txtExc
            // 
            this.txtExc.Location = new System.Drawing.Point(85, 163);
            this.txtExc.Name = "txtExc";
            this.txtExc.Size = new System.Drawing.Size(100, 20);
            this.txtExc.TabIndex = 2;
            // 
            // btnAgregarExc
            // 
            this.btnAgregarExc.Location = new System.Drawing.Point(191, 163);
            this.btnAgregarExc.Name = "btnAgregarExc";
            this.btnAgregarExc.Size = new System.Drawing.Size(128, 20);
            this.btnAgregarExc.TabIndex = 3;
            this.btnAgregarExc.Text = "Agregar Excursion";
            this.btnAgregarExc.UseVisualStyleBackColor = true;
            this.btnAgregarExc.Click += new System.EventHandler(this.btnAgregarExc_Click);
            // 
            // btnEliminarExc
            // 
            this.btnEliminarExc.Location = new System.Drawing.Point(325, 163);
            this.btnEliminarExc.Name = "btnEliminarExc";
            this.btnEliminarExc.Size = new System.Drawing.Size(128, 20);
            this.btnEliminarExc.TabIndex = 4;
            this.btnEliminarExc.Text = "Borrar Excursion";
            this.btnEliminarExc.UseVisualStyleBackColor = true;
            this.btnEliminarExc.Click += new System.EventHandler(this.btnEliminarExc_Click);
            // 
            // AgregarExcursionesPaquete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 193);
            this.Controls.Add(this.btnEliminarExc);
            this.Controls.Add(this.btnAgregarExc);
            this.Controls.Add(this.txtExc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AgregarExcursionesPaquete";
            this.Text = "AgregarExcursionesPaquete";
            this.Load += new System.EventHandler(this.AgregarExcursionesPaquete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paqueteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.excursionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private PaqueteDataSet paqueteDataSet;
        private System.Windows.Forms.BindingSource excursionBindingSource;
        private PaqueteDataSetTableAdapters.excursionTableAdapter excursionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDExcurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actividadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plazasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRealizacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExc;
        private System.Windows.Forms.Button btnAgregarExc;
        private System.Windows.Forms.Button btnEliminarExc;
    }
}