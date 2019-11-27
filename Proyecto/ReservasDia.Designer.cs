namespace Proyecto
{
    partial class ReservasDia
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
            this.verReservaDiariaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.verReservaDiariaTableAdapter = new Proyecto.PaqueteDataSetTableAdapters.verReservaDiariaTableAdapter();
            this.codResDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nPresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaReservaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paqueteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verReservaDiariaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codResDataGridViewTextBoxColumn,
            this.nPresDataGridViewTextBoxColumn,
            this.senaDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.fechaReservaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.verReservaDiariaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // paqueteDataSet
            // 
            this.paqueteDataSet.DataSetName = "PaqueteDataSet";
            this.paqueteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // verReservaDiariaBindingSource
            // 
            this.verReservaDiariaBindingSource.DataMember = "verReservaDiaria";
            this.verReservaDiariaBindingSource.DataSource = this.paqueteDataSet;
            // 
            // verReservaDiariaTableAdapter
            // 
            this.verReservaDiariaTableAdapter.ClearBeforeFill = true;
            // 
            // codResDataGridViewTextBoxColumn
            // 
            this.codResDataGridViewTextBoxColumn.DataPropertyName = "Cod_Res";
            this.codResDataGridViewTextBoxColumn.HeaderText = "Cod_Res";
            this.codResDataGridViewTextBoxColumn.Name = "codResDataGridViewTextBoxColumn";
            // 
            // nPresDataGridViewTextBoxColumn
            // 
            this.nPresDataGridViewTextBoxColumn.DataPropertyName = "N_Pres";
            this.nPresDataGridViewTextBoxColumn.HeaderText = "N_Pres";
            this.nPresDataGridViewTextBoxColumn.Name = "nPresDataGridViewTextBoxColumn";
            // 
            // senaDataGridViewTextBoxColumn
            // 
            this.senaDataGridViewTextBoxColumn.DataPropertyName = "Sena";
            this.senaDataGridViewTextBoxColumn.HeaderText = "Sena";
            this.senaDataGridViewTextBoxColumn.Name = "senaDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // fechaReservaDataGridViewTextBoxColumn
            // 
            this.fechaReservaDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Reserva";
            this.fechaReservaDataGridViewTextBoxColumn.HeaderText = "Fecha_Reserva";
            this.fechaReservaDataGridViewTextBoxColumn.Name = "fechaReservaDataGridViewTextBoxColumn";
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(12, 164);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 1;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // ReservasDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 199);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ReservasDia";
            this.Text = "ReservasDia";
            this.Load += new System.EventHandler(this.ReservasDia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paqueteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verReservaDiariaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private PaqueteDataSet paqueteDataSet;
        private System.Windows.Forms.BindingSource verReservaDiariaBindingSource;
        private PaqueteDataSetTableAdapters.verReservaDiariaTableAdapter verReservaDiariaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codResDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nPresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaReservaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAtras;
    }
}