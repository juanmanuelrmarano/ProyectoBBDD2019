namespace Proyecto
{
    partial class Clientes
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
            this.nClieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreApellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paqueteDataSet = new Proyecto.PaqueteDataSet();
            this.paqueteDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new Proyecto.PaqueteDataSetTableAdapters.clienteTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paqueteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paqueteDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nClieDataGridViewTextBoxColumn,
            this.nombreApellidoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.eMailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clienteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(727, 395);
            this.dataGridView1.TabIndex = 0;
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
            this.clienteBindingSource.DataSource = this.paqueteDataSetBindingSource;
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
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 402);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 446);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paqueteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paqueteDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource paqueteDataSetBindingSource;
        private PaqueteDataSet paqueteDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private PaqueteDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nClieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreApellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}