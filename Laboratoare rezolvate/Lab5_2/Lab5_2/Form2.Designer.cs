namespace Lab5_2
{
    partial class Form2
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
            this.btnStocFinal = new System.Windows.Forms.Button();
            this.btnStocInitial = new System.Windows.Forms.Button();
            this.btnIntrari = new System.Windows.Forms.Button();
            this.btnIesiri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataSet1 = new Lab5_2.DataSet1();
            this.calculStocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calculStocTableAdapter = new Lab5_2.DataSet1TableAdapters.CalculStocTableAdapter();
            this.idOperatieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMaterialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balantaStocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.balantaStocTableAdapter = new Lab5_2.DataSet1TableAdapters.BalantaStocTableAdapter();
            this.stocInitialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intrariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consumuriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stocFinalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculStocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balantaStocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOperatieDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.idMaterialDataGridViewTextBoxColumn,
            this.cantitateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.calculStocBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(367, 316);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stocInitialDataGridViewTextBoxColumn,
            this.intrariDataGridViewTextBoxColumn,
            this.consumuriDataGridViewTextBoxColumn,
            this.stocFinalDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.balantaStocBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(420, 70);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(379, 271);
            this.dataGridView2.TabIndex = 1;
            // 
            // btnStocFinal
            // 
            this.btnStocFinal.Location = new System.Drawing.Point(420, 362);
            this.btnStocFinal.Name = "btnStocFinal";
            this.btnStocFinal.Size = new System.Drawing.Size(75, 23);
            this.btnStocFinal.TabIndex = 2;
            this.btnStocFinal.Text = "Stoc final";
            this.btnStocFinal.UseVisualStyleBackColor = true;
            this.btnStocFinal.Click += new System.EventHandler(this.btnStocFinal_Click);
            // 
            // btnStocInitial
            // 
            this.btnStocInitial.Location = new System.Drawing.Point(515, 361);
            this.btnStocInitial.Name = "btnStocInitial";
            this.btnStocInitial.Size = new System.Drawing.Size(75, 23);
            this.btnStocInitial.TabIndex = 3;
            this.btnStocInitial.Text = "StocInitial";
            this.btnStocInitial.UseVisualStyleBackColor = true;
            this.btnStocInitial.Click += new System.EventHandler(this.btnStocInitial_Click);
            // 
            // btnIntrari
            // 
            this.btnIntrari.Location = new System.Drawing.Point(614, 360);
            this.btnIntrari.Name = "btnIntrari";
            this.btnIntrari.Size = new System.Drawing.Size(75, 23);
            this.btnIntrari.TabIndex = 4;
            this.btnIntrari.Text = "Intrari";
            this.btnIntrari.UseVisualStyleBackColor = true;
            this.btnIntrari.Click += new System.EventHandler(this.btnIntrari_Click);
            // 
            // btnIesiri
            // 
            this.btnIesiri.Location = new System.Drawing.Point(713, 362);
            this.btnIesiri.Name = "btnIesiri";
            this.btnIesiri.Size = new System.Drawing.Size(75, 23);
            this.btnIesiri.TabIndex = 5;
            this.btnIesiri.Text = "Iesiri";
            this.btnIesiri.UseVisualStyleBackColor = true;
            this.btnIesiri.Click += new System.EventHandler(this.btnIesiri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Calcul Stoc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "BalantaStoc";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // idMaterialDataGridViewTextBoxColumn
            // 
            this.idMaterialDataGridViewTextBoxColumn.DataPropertyName = "IdMaterial";
            this.idMaterialDataGridViewTextBoxColumn.HeaderText = "IdMaterial";
            this.idMaterialDataGridViewTextBoxColumn.Name = "idMaterialDataGridViewTextBoxColumn";
            // 
            // cantitateDataGridViewTextBoxColumn
            // 
            this.cantitateDataGridViewTextBoxColumn.DataPropertyName = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.HeaderText = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.Name = "cantitateDataGridViewTextBoxColumn";
            // 
            // balantaStocBindingSource
            // 
            this.balantaStocBindingSource.DataMember = "BalantaStoc";
            this.balantaStocBindingSource.DataSource = this.dataSet1;
            // 
            // balantaStocTableAdapter
            // 
            this.balantaStocTableAdapter.ClearBeforeFill = true;
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
            // consumuriDataGridViewTextBoxColumn
            // 
            this.consumuriDataGridViewTextBoxColumn.DataPropertyName = "Consumuri";
            this.consumuriDataGridViewTextBoxColumn.HeaderText = "Consumuri";
            this.consumuriDataGridViewTextBoxColumn.Name = "consumuriDataGridViewTextBoxColumn";
            // 
            // stocFinalDataGridViewTextBoxColumn
            // 
            this.stocFinalDataGridViewTextBoxColumn.DataPropertyName = "StocFinal";
            this.stocFinalDataGridViewTextBoxColumn.HeaderText = "StocFinal";
            this.stocFinalDataGridViewTextBoxColumn.Name = "stocFinalDataGridViewTextBoxColumn";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIesiri);
            this.Controls.Add(this.btnIntrari);
            this.Controls.Add(this.btnStocInitial);
            this.Controls.Add(this.btnStocFinal);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculStocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balantaStocBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnStocFinal;
        private System.Windows.Forms.Button btnStocInitial;
        private System.Windows.Forms.Button btnIntrari;
        private System.Windows.Forms.Button btnIesiri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource calculStocBindingSource;
        private DataSet1TableAdapters.CalculStocTableAdapter calculStocTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOperatieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMaterialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource balantaStocBindingSource;
        private DataSet1TableAdapters.BalantaStocTableAdapter balantaStocTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stocInitialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intrariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consumuriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stocFinalDataGridViewTextBoxColumn;
    }
}