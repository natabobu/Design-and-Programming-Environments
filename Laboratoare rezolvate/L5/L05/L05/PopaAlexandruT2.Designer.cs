namespace L05
{
    partial class PopaAlexandruT2
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
            this.btnActualizare = new System.Windows.Forms.Button();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.btnRenuntare = new System.Windows.Forms.Button();
            this.idFurnizorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dFurnizorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.furnizoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new L05.DataSet2();
            this.furnizoriTableAdapter = new L05.DataSet2TableAdapters.FurnizoriTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnizoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFurnizorDataGridViewTextBoxColumn,
            this.dFurnizorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.furnizoriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(463, 209);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // btnActualizare
            // 
            this.btnActualizare.Location = new System.Drawing.Point(46, 65);
            this.btnActualizare.Name = "btnActualizare";
            this.btnActualizare.Size = new System.Drawing.Size(75, 52);
            this.btnActualizare.TabIndex = 1;
            this.btnActualizare.Text = "Actualizare";
            this.btnActualizare.UseVisualStyleBackColor = true;
            this.btnActualizare.Click += new System.EventHandler(this.btnActualizare_Click);
            // 
            // btnSalvare
            // 
            this.btnSalvare.Location = new System.Drawing.Point(208, 65);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(75, 52);
            this.btnSalvare.TabIndex = 2;
            this.btnSalvare.Text = "Salvare";
            this.btnSalvare.UseVisualStyleBackColor = true;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click);
            // 
            // btnRenuntare
            // 
            this.btnRenuntare.Location = new System.Drawing.Point(366, 65);
            this.btnRenuntare.Name = "btnRenuntare";
            this.btnRenuntare.Size = new System.Drawing.Size(75, 52);
            this.btnRenuntare.TabIndex = 3;
            this.btnRenuntare.Text = "Renuntare";
            this.btnRenuntare.UseVisualStyleBackColor = true;
            this.btnRenuntare.Click += new System.EventHandler(this.btnRenuntare_Click);
            // 
            // idFurnizorDataGridViewTextBoxColumn
            // 
            this.idFurnizorDataGridViewTextBoxColumn.DataPropertyName = "IdFurnizor";
            this.idFurnizorDataGridViewTextBoxColumn.HeaderText = "IdFurnizor";
            this.idFurnizorDataGridViewTextBoxColumn.Name = "idFurnizorDataGridViewTextBoxColumn";
            // 
            // dFurnizorDataGridViewTextBoxColumn
            // 
            this.dFurnizorDataGridViewTextBoxColumn.DataPropertyName = "DFurnizor";
            this.dFurnizorDataGridViewTextBoxColumn.HeaderText = "DFurnizor";
            this.dFurnizorDataGridViewTextBoxColumn.Name = "dFurnizorDataGridViewTextBoxColumn";
            // 
            // furnizoriBindingSource
            // 
            this.furnizoriBindingSource.DataMember = "Furnizori";
            this.furnizoriBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // furnizoriTableAdapter
            // 
            this.furnizoriTableAdapter.ClearBeforeFill = true;
            // 
            // PopaAlexandruT2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 396);
            this.Controls.Add(this.btnRenuntare);
            this.Controls.Add(this.btnSalvare);
            this.Controls.Add(this.btnActualizare);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PopaAlexandruT2";
            this.Text = "PopaAlexandruT2";
            this.Load += new System.EventHandler(this.PopaAlexandruT2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnizoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnActualizare;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.Button btnRenuntare;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource furnizoriBindingSource;
        private DataSet2TableAdapters.FurnizoriTableAdapter furnizoriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFurnizorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dFurnizorDataGridViewTextBoxColumn;
    }
}