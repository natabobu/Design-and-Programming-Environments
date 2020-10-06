namespace Lab6
{
    partial class Form5
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
            this.cantitateMaterialeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cantitateMaterialeTableAdapter = new Lab6.IncasariDSTableAdapters.CantitateMaterialeTableAdapter();
            this.dMaterialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incasariDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantitateMaterialeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dMaterialDataGridViewTextBoxColumn,
            this.cantitateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cantitateMaterialeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(334, 316);
            this.dataGridView1.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.cantitateMaterialeBindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(373, 30);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Materiale";
            series1.XValueMember = "DMaterial";
            series1.YValueMembers = "Cantitate";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(339, 316);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // incasariDS
            // 
            this.incasariDS.DataSetName = "IncasariDS";
            this.incasariDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cantitateMaterialeBindingSource
            // 
            this.cantitateMaterialeBindingSource.DataMember = "CantitateMateriale";
            this.cantitateMaterialeBindingSource.DataSource = this.incasariDS;
            // 
            // cantitateMaterialeTableAdapter
            // 
            this.cantitateMaterialeTableAdapter.ClearBeforeFill = true;
            // 
            // dMaterialDataGridViewTextBoxColumn
            // 
            this.dMaterialDataGridViewTextBoxColumn.DataPropertyName = "DMaterial";
            this.dMaterialDataGridViewTextBoxColumn.HeaderText = "DMaterial";
            this.dMaterialDataGridViewTextBoxColumn.Name = "dMaterialDataGridViewTextBoxColumn";
            // 
            // cantitateDataGridViewTextBoxColumn
            // 
            this.cantitateDataGridViewTextBoxColumn.DataPropertyName = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.HeaderText = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.Name = "cantitateDataGridViewTextBoxColumn";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 372);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "Bobu Natalia Tema 4";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incasariDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantitateMaterialeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private IncasariDS incasariDS;
        private System.Windows.Forms.BindingSource cantitateMaterialeBindingSource;
        private IncasariDSTableAdapters.CantitateMaterialeTableAdapter cantitateMaterialeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dMaterialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitateDataGridViewTextBoxColumn;
    }
}