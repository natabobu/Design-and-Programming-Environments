namespace Lab5
{
    partial class Form3
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnStocInitial = new System.Windows.Forms.Button();
            this.btnIntrari = new System.Windows.Forms.Button();
            this.btnIesiri = new System.Windows.Forms.Button();
            this.btnStocFinal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idRFDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stocInitialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intrariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iesiriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stocFinalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dRFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monedaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balantaStocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Lab5.DataSet1();
            this.idOperatieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calculStocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calculStocTableAdapter = new Lab5.DataSet1TableAdapters.CalculStocTableAdapter();
            this.balantaStocTableAdapter = new Lab5.DataSet1TableAdapters.BalantaStocTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balantaStocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculStocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOperatieDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.idRFDataGridViewTextBoxColumn,
            this.cantitateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.calculStocBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(387, 336);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRFDataGridViewTextBoxColumn1,
            this.stocInitialDataGridViewTextBoxColumn,
            this.intrariDataGridViewTextBoxColumn,
            this.iesiriDataGridViewTextBoxColumn,
            this.stocFinalDataGridViewTextBoxColumn,
            this.dRFDataGridViewTextBoxColumn,
            this.monedaDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.balantaStocBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(490, 73);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(540, 208);
            this.dataGridView2.TabIndex = 1;
            // 
            // btnStocInitial
            // 
            this.btnStocInitial.Location = new System.Drawing.Point(628, 313);
            this.btnStocInitial.Name = "btnStocInitial";
            this.btnStocInitial.Size = new System.Drawing.Size(75, 23);
            this.btnStocInitial.TabIndex = 2;
            this.btnStocInitial.Text = "Stoc Initial";
            this.btnStocInitial.UseVisualStyleBackColor = true;
            this.btnStocInitial.Click += new System.EventHandler(this.btnStocInitial_Click);
            // 
            // btnIntrari
            // 
            this.btnIntrari.Location = new System.Drawing.Point(758, 313);
            this.btnIntrari.Name = "btnIntrari";
            this.btnIntrari.Size = new System.Drawing.Size(75, 23);
            this.btnIntrari.TabIndex = 3;
            this.btnIntrari.Text = "Intrari";
            this.btnIntrari.UseVisualStyleBackColor = true;
            this.btnIntrari.Click += new System.EventHandler(this.btnIntrari_Click);
            // 
            // btnIesiri
            // 
            this.btnIesiri.Location = new System.Drawing.Point(887, 313);
            this.btnIesiri.Name = "btnIesiri";
            this.btnIesiri.Size = new System.Drawing.Size(75, 23);
            this.btnIesiri.TabIndex = 4;
            this.btnIesiri.Text = "Iesiri";
            this.btnIesiri.UseVisualStyleBackColor = true;
            this.btnIesiri.Click += new System.EventHandler(this.btnIesiri_Click);
            // 
            // btnStocFinal
            // 
            this.btnStocFinal.Location = new System.Drawing.Point(490, 313);
            this.btnStocFinal.Name = "btnStocFinal";
            this.btnStocFinal.Size = new System.Drawing.Size(75, 23);
            this.btnStocFinal.TabIndex = 5;
            this.btnStocFinal.Text = "Stoc Final";
            this.btnStocFinal.UseVisualStyleBackColor = true;
            this.btnStocFinal.Click += new System.EventHandler(this.btnStocFinal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Calcul Stoc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(486, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Balanta Stoc";
            // 
            // idRFDataGridViewTextBoxColumn1
            // 
            this.idRFDataGridViewTextBoxColumn1.DataPropertyName = "IdRF";
            this.idRFDataGridViewTextBoxColumn1.HeaderText = "IdRF";
            this.idRFDataGridViewTextBoxColumn1.Name = "idRFDataGridViewTextBoxColumn1";
            // 
            // stocInitialDataGridViewTextBoxColumn
            // 
            this.stocInitialDataGridViewTextBoxColumn.DataPropertyName = "StocInitial";
            this.stocInitialDataGridViewTextBoxColumn.HeaderText = "StocInitial";
            this.stocInitialDataGridViewTextBoxColumn.Name = "stocInitialDataGridViewTextBoxColumn";
            // 
            // intrariDataGridViewTextBoxColumn
            // 
            this.intrariDataGridViewTextBoxColumn.DataPropertyName = "Intrari";
            this.intrariDataGridViewTextBoxColumn.HeaderText = "Intrari";
            this.intrariDataGridViewTextBoxColumn.Name = "intrariDataGridViewTextBoxColumn";
            // 
            // iesiriDataGridViewTextBoxColumn
            // 
            this.iesiriDataGridViewTextBoxColumn.DataPropertyName = "Iesiri";
            this.iesiriDataGridViewTextBoxColumn.HeaderText = "Iesiri";
            this.iesiriDataGridViewTextBoxColumn.Name = "iesiriDataGridViewTextBoxColumn";
            // 
            // stocFinalDataGridViewTextBoxColumn
            // 
            this.stocFinalDataGridViewTextBoxColumn.DataPropertyName = "StocFinal";
            this.stocFinalDataGridViewTextBoxColumn.HeaderText = "StocFinal";
            this.stocFinalDataGridViewTextBoxColumn.Name = "stocFinalDataGridViewTextBoxColumn";
            // 
            // dRFDataGridViewTextBoxColumn
            // 
            this.dRFDataGridViewTextBoxColumn.DataPropertyName = "DRF";
            this.dRFDataGridViewTextBoxColumn.HeaderText = "DRF";
            this.dRFDataGridViewTextBoxColumn.Name = "dRFDataGridViewTextBoxColumn";
            // 
            // monedaDataGridViewTextBoxColumn
            // 
            this.monedaDataGridViewTextBoxColumn.DataPropertyName = "Moneda";
            this.monedaDataGridViewTextBoxColumn.HeaderText = "Moneda";
            this.monedaDataGridViewTextBoxColumn.Name = "monedaDataGridViewTextBoxColumn";
            // 
            // balantaStocBindingSource
            // 
            this.balantaStocBindingSource.DataMember = "BalantaStoc";
            this.balantaStocBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idOperatieDataGridViewTextBoxColumn
            // 
            this.idOperatieDataGridViewTextBoxColumn.DataPropertyName = "IdOperatie";
            this.idOperatieDataGridViewTextBoxColumn.HeaderText = "IdOperatie";
            this.idOperatieDataGridViewTextBoxColumn.Name = "idOperatieDataGridViewTextBoxColumn";
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // idRFDataGridViewTextBoxColumn
            // 
            this.idRFDataGridViewTextBoxColumn.DataPropertyName = "IdRF";
            this.idRFDataGridViewTextBoxColumn.HeaderText = "IdRF";
            this.idRFDataGridViewTextBoxColumn.Name = "idRFDataGridViewTextBoxColumn";
            // 
            // cantitateDataGridViewTextBoxColumn
            // 
            this.cantitateDataGridViewTextBoxColumn.DataPropertyName = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.HeaderText = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.Name = "cantitateDataGridViewTextBoxColumn";
            // 
            // calculStocBindingSource
            // 
            this.calculStocBindingSource.DataMember = "CalculStoc";
            this.calculStocBindingSource.DataSource = this.dataSet1;
            // 
            // calculStocTableAdapter
            // 
            this.calculStocTableAdapter.ClearBeforeFill = true;
            // 
            // balantaStocTableAdapter
            // 
            this.balantaStocTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 421);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStocFinal);
            this.Controls.Add(this.btnIesiri);
            this.Controls.Add(this.btnIntrari);
            this.Controls.Add(this.btnStocInitial);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Bobu Natalia Tema 3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balantaStocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculStocBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnStocInitial;
        private System.Windows.Forms.Button btnIntrari;
        private System.Windows.Forms.Button btnIesiri;
        private System.Windows.Forms.Button btnStocFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource calculStocBindingSource;
        private DataSet1TableAdapters.CalculStocTableAdapter calculStocTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOperatieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource balantaStocBindingSource;
        private DataSet1TableAdapters.BalantaStocTableAdapter balantaStocTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRFDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stocInitialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intrariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iesiriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stocFinalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dRFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monedaDataGridViewTextBoxColumn;
    }
}