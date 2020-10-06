namespace Lab7
{
    partial class Form4
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
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new Lab7.DataSet1();
            this.platiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.platiTableAdapter = new Lab7.DataSet1TableAdapters.PlatiTableAdapter();
            this.dataPlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dRFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monedaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dBeneficiarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // date1
            // 
            this.date1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date1.Location = new System.Drawing.Point(48, 68);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(102, 20);
            this.date1.TabIndex = 0;
            // 
            // date2
            // 
            this.date2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date2.Location = new System.Drawing.Point(217, 68);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(97, 20);
            this.date2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "De la";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pana la";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(372, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Afiseaza";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataPlDataGridViewTextBoxColumn,
            this.dRFDataGridViewTextBoxColumn,
            this.sumaDataGridViewTextBoxColumn,
            this.monedaDataGridViewTextBoxColumn,
            this.dBeneficiarDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.platiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(37, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(586, 280);
            this.dataGridView1.TabIndex = 5;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // platiBindingSource
            // 
            this.platiBindingSource.DataMember = "Plati";
            this.platiBindingSource.DataSource = this.dataSet1;
            // 
            // platiTableAdapter
            // 
            this.platiTableAdapter.ClearBeforeFill = true;
            // 
            // dataPlDataGridViewTextBoxColumn
            // 
            this.dataPlDataGridViewTextBoxColumn.DataPropertyName = "DataPl";
            this.dataPlDataGridViewTextBoxColumn.HeaderText = "DataPl";
            this.dataPlDataGridViewTextBoxColumn.Name = "dataPlDataGridViewTextBoxColumn";
            // 
            // dRFDataGridViewTextBoxColumn
            // 
            this.dRFDataGridViewTextBoxColumn.DataPropertyName = "DRF";
            this.dRFDataGridViewTextBoxColumn.HeaderText = "DRF";
            this.dRFDataGridViewTextBoxColumn.Name = "dRFDataGridViewTextBoxColumn";
            // 
            // sumaDataGridViewTextBoxColumn
            // 
            this.sumaDataGridViewTextBoxColumn.DataPropertyName = "Suma";
            this.sumaDataGridViewTextBoxColumn.HeaderText = "Suma";
            this.sumaDataGridViewTextBoxColumn.Name = "sumaDataGridViewTextBoxColumn";
            // 
            // monedaDataGridViewTextBoxColumn
            // 
            this.monedaDataGridViewTextBoxColumn.DataPropertyName = "Moneda";
            this.monedaDataGridViewTextBoxColumn.HeaderText = "Moneda";
            this.monedaDataGridViewTextBoxColumn.Name = "monedaDataGridViewTextBoxColumn";
            // 
            // dBeneficiarDataGridViewTextBoxColumn
            // 
            this.dBeneficiarDataGridViewTextBoxColumn.DataPropertyName = "DBeneficiar";
            this.dBeneficiarDataGridViewTextBoxColumn.HeaderText = "DBeneficiar";
            this.dBeneficiarDataGridViewTextBoxColumn.Name = "dBeneficiarDataGridViewTextBoxColumn";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.date1);
            this.Name = "Form4";
            this.Text = "Bobu Natalia Tema 3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.DateTimePicker date2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dRFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monedaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dBeneficiarDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource platiBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.PlatiTableAdapter platiTableAdapter;
    }
}