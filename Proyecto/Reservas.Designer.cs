namespace Proyecto
{
    partial class Reservas
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
            this.codResDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nPresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paqueteDataSet = new Proyecto.PaqueteDataSet();
            this.reservaTableAdapter = new Proyecto.PaqueteDataSetTableAdapters.reservaTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.Fecha_Reserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paqueteDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codResDataGridViewTextBoxColumn,
            this.nPresDataGridViewTextBoxColumn,
            this.senaDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.Fecha_Reserva});
            this.dataGridView1.DataSource = this.reservaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(545, 351);
            this.dataGridView1.TabIndex = 0;
            // 
            // codResDataGridViewTextBoxColumn
            // 
            this.codResDataGridViewTextBoxColumn.DataPropertyName = "Cod_Res";
            this.codResDataGridViewTextBoxColumn.HeaderText = "Cod_Res";
            this.codResDataGridViewTextBoxColumn.Name = "codResDataGridViewTextBoxColumn";
            this.codResDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nPresDataGridViewTextBoxColumn
            // 
            this.nPresDataGridViewTextBoxColumn.DataPropertyName = "N_Pres";
            this.nPresDataGridViewTextBoxColumn.HeaderText = "N_Pres";
            this.nPresDataGridViewTextBoxColumn.Name = "nPresDataGridViewTextBoxColumn";
            this.nPresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // senaDataGridViewTextBoxColumn
            // 
            this.senaDataGridViewTextBoxColumn.DataPropertyName = "Sena";
            this.senaDataGridViewTextBoxColumn.HeaderText = "Sena";
            this.senaDataGridViewTextBoxColumn.Name = "senaDataGridViewTextBoxColumn";
            this.senaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reservaBindingSource
            // 
            this.reservaBindingSource.DataMember = "reserva";
            this.reservaBindingSource.DataSource = this.paqueteDataSet;
            // 
            // paqueteDataSet
            // 
            this.paqueteDataSet.DataSetName = "PaqueteDataSet";
            this.paqueteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservaTableAdapter
            // 
            this.reservaTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Fecha_Reserva
            // 
            this.Fecha_Reserva.DataPropertyName = "Fecha_Reserva";
            this.Fecha_Reserva.HeaderText = "Fecha_Reserva";
            this.Fecha_Reserva.Name = "Fecha_Reserva";
            this.Fecha_Reserva.ReadOnly = true;
            // 
            // Reservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 392);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Reservas";
            this.Text = "Reservas";
            this.Load += new System.EventHandler(this.Reservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paqueteDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private PaqueteDataSet paqueteDataSet;
        private System.Windows.Forms.BindingSource reservaBindingSource;
        private PaqueteDataSetTableAdapters.reservaTableAdapter reservaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codResDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nPresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Reserva;
    }
}