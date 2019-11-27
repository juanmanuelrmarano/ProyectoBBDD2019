namespace Proyecto
{
    partial class Presupuestos
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
            this.presupuestoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paqueteDataSet = new Proyecto.PaqueteDataSet();
            this.presupuestoTableAdapter = new Proyecto.PaqueteDataSetTableAdapters.presupuestoTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.nPresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nClieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPaqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fEmisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vigenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presupuestoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paqueteDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nPresDataGridViewTextBoxColumn,
            this.nClieDataGridViewTextBoxColumn,
            this.iDPaqDataGridViewTextBoxColumn,
            this.fEmisionDataGridViewTextBoxColumn,
            this.vigenciaDataGridViewTextBoxColumn,
            this.Costo});
            this.dataGridView1.DataSource = this.presupuestoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(657, 311);
            this.dataGridView1.TabIndex = 0;
            // 
            // presupuestoBindingSource
            // 
            this.presupuestoBindingSource.DataMember = "presupuesto";
            this.presupuestoBindingSource.DataSource = this.paqueteDataSet;
            // 
            // paqueteDataSet
            // 
            this.paqueteDataSet.DataSetName = "PaqueteDataSet";
            this.paqueteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // presupuestoTableAdapter
            // 
            this.presupuestoTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nPresDataGridViewTextBoxColumn
            // 
            this.nPresDataGridViewTextBoxColumn.DataPropertyName = "N_Pres";
            this.nPresDataGridViewTextBoxColumn.HeaderText = "N_Pres";
            this.nPresDataGridViewTextBoxColumn.Name = "nPresDataGridViewTextBoxColumn";
            // 
            // nClieDataGridViewTextBoxColumn
            // 
            this.nClieDataGridViewTextBoxColumn.DataPropertyName = "N_Clie";
            this.nClieDataGridViewTextBoxColumn.HeaderText = "N_Clie";
            this.nClieDataGridViewTextBoxColumn.Name = "nClieDataGridViewTextBoxColumn";
            // 
            // iDPaqDataGridViewTextBoxColumn
            // 
            this.iDPaqDataGridViewTextBoxColumn.DataPropertyName = "ID_Paq";
            this.iDPaqDataGridViewTextBoxColumn.HeaderText = "ID_Paq";
            this.iDPaqDataGridViewTextBoxColumn.Name = "iDPaqDataGridViewTextBoxColumn";
            // 
            // fEmisionDataGridViewTextBoxColumn
            // 
            this.fEmisionDataGridViewTextBoxColumn.DataPropertyName = "F_Emision";
            this.fEmisionDataGridViewTextBoxColumn.HeaderText = "F_Emision";
            this.fEmisionDataGridViewTextBoxColumn.Name = "fEmisionDataGridViewTextBoxColumn";
            // 
            // vigenciaDataGridViewTextBoxColumn
            // 
            this.vigenciaDataGridViewTextBoxColumn.DataPropertyName = "Vigencia";
            this.vigenciaDataGridViewTextBoxColumn.HeaderText = "Vigencia";
            this.vigenciaDataGridViewTextBoxColumn.Name = "vigenciaDataGridViewTextBoxColumn";
            // 
            // Costo
            // 
            this.Costo.DataPropertyName = "Costo";
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            // 
            // Presupuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 352);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Presupuestos";
            this.Text = "Presupuestos";
            this.Load += new System.EventHandler(this.Presupuestos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presupuestoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paqueteDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private PaqueteDataSet paqueteDataSet;
        private System.Windows.Forms.BindingSource presupuestoBindingSource;
        private PaqueteDataSetTableAdapters.presupuestoTableAdapter presupuestoTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nPresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nClieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPaqDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fEmisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vigenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
    }
}