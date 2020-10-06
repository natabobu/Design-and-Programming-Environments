namespace Lab6
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.incasariDS = new Lab6.IncasariDS();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.incasariDS1 = new Lab6.IncasariDS();
            this.noteElevBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.noteElevTableAdapter = new Lab6.IncasariDSTableAdapters.NoteElevTableAdapter();
            this.materieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incasariDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incasariDS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteElevBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.materieDataGridViewTextBoxColumn,
            this.medieDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.noteElevBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(319, 300);
            this.dataGridView1.TabIndex = 0;
            // 
            // incasariDS
            // 
            this.incasariDS.DataSetName = "IncasariDS";
            this.incasariDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.noteElevBindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(353, 39);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Note";
            series1.XValueMember = "Materie";
            series1.YValueMembers = "Medie";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // incasariDS1
            // 
            this.incasariDS1.DataSetName = "IncasariDS";
            this.incasariDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // noteElevBindingSource
            // 
            this.noteElevBindingSource.DataMember = "NoteElev";
            this.noteElevBindingSource.DataSource = this.incasariDS1;
            // 
            // noteElevTableAdapter
            // 
            this.noteElevTableAdapter.ClearBeforeFill = true;
            // 
            // materieDataGridViewTextBoxColumn
            // 
            this.materieDataGridViewTextBoxColumn.DataPropertyName = "Materie";
            this.materieDataGridViewTextBoxColumn.HeaderText = "Materie";
            this.materieDataGridViewTextBoxColumn.Name = "materieDataGridViewTextBoxColumn";
            // 
            // medieDataGridViewTextBoxColumn
            // 
            this.medieDataGridViewTextBoxColumn.DataPropertyName = "Medie";
            this.medieDataGridViewTextBoxColumn.HeaderText = "Medie";
            this.medieDataGridViewTextBoxColumn.Name = "medieDataGridViewTextBoxColumn";
            this.medieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 374);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Bobu Natalia Tema 3";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incasariDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incasariDS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteElevBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private IncasariDS incasariDS;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private IncasariDS incasariDS1;
        private System.Windows.Forms.BindingSource noteElevBindingSource;
        private IncasariDSTableAdapters.NoteElevTableAdapter noteElevTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn materieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medieDataGridViewTextBoxColumn;
    }
}