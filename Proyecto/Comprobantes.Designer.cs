namespace Proyecto
{
    partial class Comprobantes
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
            this.iDPaqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nClieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprobanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paqueteDataSet = new Proyecto.PaqueteDataSet();
            this.comprobanteTableAdapter = new Proyecto.PaqueteDataSetTableAdapters.comprobanteTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprobanteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paqueteDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codResDataGridViewTextBoxColumn,
            this.iDPaqDataGridViewTextBoxColumn,
            this.nClieDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.comprobanteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(348, 308);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // codResDataGridViewTextBoxColumn
            // 
            this.codResDataGridViewTextBoxColumn.DataPropertyName = "Cod_Res";
            this.codResDataGridViewTextBoxColumn.HeaderText = "Cod_Res";
            this.codResDataGridViewTextBoxColumn.Name = "codResDataGridViewTextBoxColumn";
            // 
            // iDPaqDataGridViewTextBoxColumn
            // 
            this.iDPaqDataGridViewTextBoxColumn.DataPropertyName = "ID_Paq";
            this.iDPaqDataGridViewTextBoxColumn.HeaderText = "ID_Paq";
            this.iDPaqDataGridViewTextBoxColumn.Name = "iDPaqDataGridViewTextBoxColumn";
            // 
            // nClieDataGridViewTextBoxColumn
            // 
            this.nClieDataGridViewTextBoxColumn.DataPropertyName = "N_Clie";
            this.nClieDataGridViewTextBoxColumn.HeaderText = "N_Clie";
            this.nClieDataGridViewTextBoxColumn.Name = "nClieDataGridViewTextBoxColumn";
            // 
            // comprobanteBindingSource
            // 
            this.comprobanteBindingSource.DataMember = "comprobante";
            this.comprobanteBindingSource.DataSource = this.paqueteDataSet;
            // 
            // paqueteDataSet
            // 
            this.paqueteDataSet.DataSetName = "PaqueteDataSet";
            this.paqueteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comprobanteTableAdapter
            // 
            this.comprobanteTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Comprobantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 349);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Comprobantes";
            this.Text = "Comprobantes";
            this.Load += new System.EventHandler(this.Comprobantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprobanteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paqueteDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private PaqueteDataSet paqueteDataSet;
        private System.Windows.Forms.BindingSource comprobanteBindingSource;
        private PaqueteDataSetTableAdapters.comprobanteTableAdapter comprobanteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codResDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPaqDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nClieDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}