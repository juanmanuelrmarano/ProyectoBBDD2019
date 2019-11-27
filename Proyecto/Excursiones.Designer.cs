namespace Proyecto
{
    partial class Excursiones
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
            this.iDExcurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actividadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plazasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Realizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.excursionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paqueteDataSet = new Proyecto.PaqueteDataSet();
            this.excursionTableAdapter = new Proyecto.PaqueteDataSetTableAdapters.excursionTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.excursionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paqueteDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.Fecha_Realizacion});
            this.dataGridView1.DataSource = this.excursionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1008, 458);
            this.dataGridView1.TabIndex = 0;
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
            // Fecha_Realizacion
            // 
            this.Fecha_Realizacion.DataPropertyName = "Fecha_Realizacion";
            this.Fecha_Realizacion.HeaderText = "Fecha_Realizacion";
            this.Fecha_Realizacion.Name = "Fecha_Realizacion";
            // 
            // excursionBindingSource
            // 
            this.excursionBindingSource.DataMember = "excursion";
            this.excursionBindingSource.DataSource = this.paqueteDataSet;
            // 
            // paqueteDataSet
            // 
            this.paqueteDataSet.DataSetName = "PaqueteDataSet";
            this.paqueteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // excursionTableAdapter
            // 
            this.excursionTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 468);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Location = new System.Drawing.Point(418, 503);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 88);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eliminar Excursion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Id";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(67, 52);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 7;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(68, 21);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBox10);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 503);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 259);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Excursion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(85, 172);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 22);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Plazas";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(85, 141);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 22);
            this.textBox8.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Precio";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(85, 112);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 22);
            this.textBox10.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Actividad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Duracion";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(85, 56);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 9;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(85, 84);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 22);
            this.textBox7.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(85, 224);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 7;
            this.button2.Text = "Agregar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID Destino";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(85, 27);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.dateTimePicker2);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.textBox11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.textBox12);
            this.groupBox3.Controls.Add(this.textBox13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.textBox14);
            this.groupBox3.Controls.Add(this.textBox15);
            this.groupBox3.Location = new System.Drawing.Point(215, 503);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(197, 259);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Modificar Excursion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Plazas";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(90, 166);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "Precio";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(90, 137);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 22);
            this.textBox11.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 17);
            this.label12.TabIndex = 11;
            this.label12.Text = "Actividad";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 109);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 17);
            this.label13.TabIndex = 8;
            this.label13.Text = "Duracion";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(90, 81);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 22);
            this.textBox12.TabIndex = 9;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(90, 109);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 22);
            this.textBox13.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 17);
            this.label14.TabIndex = 6;
            this.label14.Text = "Id Excur";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(90, 224);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 28);
            this.button4.TabIndex = 7;
            this.button4.Text = "Modificar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 17);
            this.label15.TabIndex = 3;
            this.label15.Text = "ID Destino";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(90, 24);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(100, 22);
            this.textBox14.TabIndex = 4;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(90, 52);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(100, 22);
            this.textBox15.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Fecha";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(90, 194);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(100, 22);
            this.dateTimePicker2.TabIndex = 20;
            // 
            // Excursiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 774);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Excursiones";
            this.Text = "Excursiones";
            this.Load += new System.EventHandler(this.Excursiones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.excursionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paqueteDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private PaqueteDataSet paqueteDataSet;
        private System.Windows.Forms.BindingSource excursionBindingSource;
        private PaqueteDataSetTableAdapters.excursionTableAdapter excursionTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDExcurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actividadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plazasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Realizacion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}