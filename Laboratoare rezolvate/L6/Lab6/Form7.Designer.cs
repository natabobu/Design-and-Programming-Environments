namespace Lab6
{
    partial class Form7
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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.incasariDS = new Lab6.IncasariDS();
            this.incasariDS1 = new Lab6.IncasariDS();
            this.lucrariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lucrariTableAdapter = new Lab6.IncasariDSTableAdapters.LucrariTableAdapter();
            this.dLucrareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costConsumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incasariDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incasariDS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lucrariBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dLucrareDataGridViewTextBoxColumn,
            this.costConsumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lucrariBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(363, 268);
            this.dataGridView1.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.lucrariBindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(442, 29);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Consumuri Lucrari";
            series1.XValueMember = "DLucrare";
            series1.YValueMembers = "CostConsum";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // incasariDS
            // 
            this.incasariDS.DataSetName = "IncasariDS";
            this.incasariDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // incasariDS1
            // 
            this.incasariDS1.DataSetName = "IncasariDS";
            this.incasariDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lucrariBindingSource
            // 
            this.lucrariBindingSource.DataMember = "Lucrari";
            this.lucrariBindingSource.DataSource = this.incasariDS1;
            // 
            // lucrariTableAdapter
            // 
            this.lucrariTableAdapter.ClearBeforeFill = true;
            // 
            // dLucrareDataGridViewTextBoxColumn
            // 
            this.dLucrareDataGridViewTextBoxColumn.DataPropertyName = "DLucrare";
            this.dLucrareDataGridViewTextBoxColumn.HeaderText = "DLucrare";
            this.dLucrareDataGridViewTextBoxColumn.Name = "dLucrareDataGridViewTextBoxColumn";
            // 
            // costConsumDataGridViewTextBoxColumn
            // 
            this.costConsumDataGridViewTextBoxColumn.DataPropertyName = "CostConsum";
            this.costConsumDataGridViewTextBoxColumn.HeaderText = "CostConsum";
            this.costConsumDataGridViewTextBoxColumn.Name = "costConsumDataGridViewTextBoxColumn";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 341);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form7";
            this.Text = "Bobu Natalia Tema 6";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incasariDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incasariDS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lucrariBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private IncasariDS incasariDS;
        private IncasariDS incasariDS1;
        private System.Windows.Forms.BindingSource lucrariBindingSource;
        private IncasariDSTableAdapters.LucrariTableAdapter lucrariTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dLucrareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costConsumDataGridViewTextBoxColumn;
    }
}