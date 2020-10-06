namespace L02
{
    partial class Form1
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
            this.btnStocFinal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnIesiri = new System.Windows.Forms.Button();
            this.btnIntrari = new System.Windows.Forms.Button();
            this.btnStocInitial = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new L02.DataSet1();
            this.calculStocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calculStocTableAdapter = new L02.DataSet1TableAdapters.CalculStocTableAdapter();
            this.idOperatieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stocTableAdapter = new L02.DataSet1TableAdapters.StocTableAdapter();
            this.idRFDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dRFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monedaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculStocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStocFinal
            // 
            this.btnStocFinal.Location = new System.Drawing.Point(467, 117);
            this.btnStocFinal.Name = "btnStocFinal";
            this.btnStocFinal.Size = new System.Drawing.Size(75, 23);
            this.btnStocFinal.TabIndex = 15;
            this.btnStocFinal.Text = "Stoc final";
            this.btnStocFinal.UseVisualStyleBackColor = true;
            this.btnStocFinal.Click += new System.EventHandler(this.btnStocFinal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(554, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Stoc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Calcul stoc";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRFDataGridViewTextBoxColumn1,
            this.dRFDataGridViewTextBoxColumn,
            this.monedaDataGridViewTextBoxColumn,
            this.cantitateDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.stocBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(548, 30);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 20;
            this.dataGridView2.Size = new System.Drawing.Size(446, 205);
            this.dataGridView2.TabIndex = 12;
            // 
            // btnIesiri
            // 
            this.btnIesiri.Location = new System.Drawing.Point(467, 88);
            this.btnIesiri.Name = "btnIesiri";
            this.btnIesiri.Size = new System.Drawing.Size(75, 23);
            this.btnIesiri.TabIndex = 11;
            this.btnIesiri.Text = "Iesiri";
            this.btnIesiri.UseVisualStyleBackColor = true;
            this.btnIesiri.Click += new System.EventHandler(this.btnIesiri_Click);
            // 
            // btnIntrari
            // 
            this.btnIntrari.Location = new System.Drawing.Point(467, 59);
            this.btnIntrari.Name = "btnIntrari";
            this.btnIntrari.Size = new System.Drawing.Size(75, 23);
            this.btnIntrari.TabIndex = 10;
            this.btnIntrari.Text = "Intrari";
            this.btnIntrari.UseVisualStyleBackColor = true;
            this.btnIntrari.Click += new System.EventHandler(this.btnIntrari_Click);
            // 
            // btnStocInitial
            // 
            this.btnStocInitial.Location = new System.Drawing.Point(467, 30);
            this.btnStocInitial.Name = "btnStocInitial";
            this.btnStocInitial.Size = new System.Drawing.Size(75, 23);
            this.btnStocInitial.TabIndex = 9;
            this.btnStocInitial.Text = "Stoc initial";
            this.btnStocInitial.UseVisualStyleBackColor = true;
            this.btnStocInitial.Click += new System.EventHandler(this.btnStocInitial_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOperatieDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.cantitateDataGridViewTextBoxColumn,
            this.idRFDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.calculStocBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.Size = new System.Drawing.Size(459, 326);
            this.dataGridView1.TabIndex = 8;
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
            this.idOperatieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantitateDataGridViewTextBoxColumn
            // 
            this.cantitateDataGridViewTextBoxColumn.DataPropertyName = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.HeaderText = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.Name = "cantitateDataGridViewTextBoxColumn";
            this.cantitateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idRFDataGridViewTextBoxColumn
            // 
            this.idRFDataGridViewTextBoxColumn.DataPropertyName = "IdRF";
            this.idRFDataGridViewTextBoxColumn.HeaderText = "IdRF";
            this.idRFDataGridViewTextBoxColumn.Name = "idRFDataGridViewTextBoxColumn";
            this.idRFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stocBindingSource
            // 
            this.stocBindingSource.DataMember = "Stoc";
            this.stocBindingSource.DataSource = this.dataSet1;
            // 
            // stocTableAdapter
            // 
            this.stocTableAdapter.ClearBeforeFill = true;
            // 
            // idRFDataGridViewTextBoxColumn1
            // 
            this.idRFDataGridViewTextBoxColumn1.DataPropertyName = "IdRF";
            this.idRFDataGridViewTextBoxColumn1.HeaderText = "IdRF";
            this.idRFDataGridViewTextBoxColumn1.Name = "idRFDataGridViewTextBoxColumn1";
            this.idRFDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dRFDataGridViewTextBoxColumn
            // 
            this.dRFDataGridViewTextBoxColumn.DataPropertyName = "DRF";
            this.dRFDataGridViewTextBoxColumn.HeaderText = "DRF";
            this.dRFDataGridViewTextBoxColumn.Name = "dRFDataGridViewTextBoxColumn";
            this.dRFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // monedaDataGridViewTextBoxColumn
            // 
            this.monedaDataGridViewTextBoxColumn.DataPropertyName = "Moneda";
            this.monedaDataGridViewTextBoxColumn.HeaderText = "Moneda";
            this.monedaDataGridViewTextBoxColumn.Name = "monedaDataGridViewTextBoxColumn";
            this.monedaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantitateDataGridViewTextBoxColumn1
            // 
            this.cantitateDataGridViewTextBoxColumn1.DataPropertyName = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn1.HeaderText = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn1.Name = "cantitateDataGridViewTextBoxColumn1";
            this.cantitateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 367);
            this.Controls.Add(this.btnStocFinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnIesiri);
            this.Controls.Add(this.btnIntrari);
            this.Controls.Add(this.btnStocInitial);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculStocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStocFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnIesiri;
        private System.Windows.Forms.Button btnIntrari;
        private System.Windows.Forms.Button btnStocInitial;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource calculStocBindingSource;
        private DataSet1TableAdapters.CalculStocTableAdapter calculStocTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOperatieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRFDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource stocBindingSource;
        private DataSet1TableAdapters.StocTableAdapter stocTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRFDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dRFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monedaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitateDataGridViewTextBoxColumn1;
    }
}

