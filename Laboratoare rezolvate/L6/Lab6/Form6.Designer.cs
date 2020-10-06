namespace Lab6
{
    partial class Form6
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.incasariDS = new Lab6.IncasariDS();
            this.materialeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialeTableAdapter = new Lab6.IncasariDSTableAdapters.MaterialeTableAdapter();
            this.dMaterialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoareTotalaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incasariDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dMaterialDataGridViewTextBoxColumn,
            this.valoareTotalaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.materialeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(311, 300);
            this.dataGridView1.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.DataSource = this.materialeBindingSource;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(341, 23);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Valoare Totala";
            series2.XValueMember = "DMaterial";
            series2.YValueMembers = "Valoare totala";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // incasariDS
            // 
            this.incasariDS.DataSetName = "IncasariDS";
            this.incasariDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialeBindingSource
            // 
            this.materialeBindingSource.DataMember = "Materiale";
            this.materialeBindingSource.DataSource = this.incasariDS;
            // 
            // materialeTableAdapter
            // 
            this.materialeTableAdapter.ClearBeforeFill = true;
            // 
            // dMaterialDataGridViewTextBoxColumn
            // 
            this.dMaterialDataGridViewTextBoxColumn.DataPropertyName = "DMaterial";
            this.dMaterialDataGridViewTextBoxColumn.HeaderText = "DMaterial";
            this.dMaterialDataGridViewTextBoxColumn.Name = "dMaterialDataGridViewTextBoxColumn";
            // 
            // valoareTotalaDataGridViewTextBoxColumn
            // 
            this.valoareTotalaDataGridViewTextBoxColumn.DataPropertyName = "Valoare totala";
            this.valoareTotalaDataGridViewTextBoxColumn.HeaderText = "Valoare totala";
            this.valoareTotalaDataGridViewTextBoxColumn.Name = "valoareTotalaDataGridViewTextBoxColumn";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 340);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form6";
            this.Text = "Bobu Natalia Tema 5";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incasariDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private IncasariDS incasariDS;
        private System.Windows.Forms.BindingSource materialeBindingSource;
        private IncasariDSTableAdapters.MaterialeTableAdapter materialeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dMaterialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoareTotalaDataGridViewTextBoxColumn;
    }
}