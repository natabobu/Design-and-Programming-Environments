namespace ProiectMPP
{
    partial class EvenimentExmatriculare
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
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.btnModificare = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnConfirmare = new System.Windows.Forms.Button();
            this.btnRenuntare = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataExmatriculareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeMotivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exmatriculariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new ProiectMPP.DataSet1();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNr = new System.Windows.Forms.TextBox();
            this.txtClasa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbStudent = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMotiv = new System.Windows.Forms.ComboBox();
            this.motiveExmatriculariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.exmatriculariTableAdapter = new ProiectMPP.DataSet1TableAdapters.ExmatriculariTableAdapter();
            this.motiveExmatriculariTableAdapter = new ProiectMPP.DataSet1TableAdapters.MotiveExmatriculariTableAdapter();
            this.lblOp = new System.Windows.Forms.Label();
            this.eleviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eleviTableAdapter = new ProiectMPP.DataSet1TableAdapters.EleviTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exmatriculariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.motiveExmatriculariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eleviBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(27, 58);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(75, 23);
            this.btnAdaugare.TabIndex = 0;
            this.btnAdaugare.Text = "Adaugare";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // btnModificare
            // 
            this.btnModificare.Location = new System.Drawing.Point(144, 58);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(75, 23);
            this.btnModificare.TabIndex = 1;
            this.btnModificare.Text = "Modificare";
            this.btnModificare.UseVisualStyleBackColor = true;
            this.btnModificare.Click += new System.EventHandler(this.btnModificare_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(260, 58);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(75, 23);
            this.btnStergere.TabIndex = 2;
            this.btnStergere.Text = "Stergere";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnConfirmare
            // 
            this.btnConfirmare.Location = new System.Drawing.Point(513, 58);
            this.btnConfirmare.Name = "btnConfirmare";
            this.btnConfirmare.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmare.TabIndex = 3;
            this.btnConfirmare.Text = "Confirmare";
            this.btnConfirmare.UseVisualStyleBackColor = true;
            this.btnConfirmare.Click += new System.EventHandler(this.btnConfirmare_Click);
            // 
            // btnRenuntare
            // 
            this.btnRenuntare.Location = new System.Drawing.Point(642, 58);
            this.btnRenuntare.Name = "btnRenuntare";
            this.btnRenuntare.Size = new System.Drawing.Size(75, 23);
            this.btnRenuntare.TabIndex = 4;
            this.btnRenuntare.Text = "Renuntare";
            this.btnRenuntare.UseVisualStyleBackColor = true;
            this.btnRenuntare.Click += new System.EventHandler(this.btnRenuntare_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataExmatriculareDataGridViewTextBoxColumn,
            this.numeMotivDataGridViewTextBoxColumn,
            this.numeDataGridViewTextBoxColumn,
            this.clasaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.exmatriculariBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 233);
            this.dataGridView1.TabIndex = 5;
            // 
            // dataExmatriculareDataGridViewTextBoxColumn
            // 
            this.dataExmatriculareDataGridViewTextBoxColumn.DataPropertyName = "DataExmatriculare";
            this.dataExmatriculareDataGridViewTextBoxColumn.HeaderText = "DataExmatriculare";
            this.dataExmatriculareDataGridViewTextBoxColumn.Name = "dataExmatriculareDataGridViewTextBoxColumn";
            // 
            // numeMotivDataGridViewTextBoxColumn
            // 
            this.numeMotivDataGridViewTextBoxColumn.DataPropertyName = "NumeMotiv";
            this.numeMotivDataGridViewTextBoxColumn.HeaderText = "NumeMotiv";
            this.numeMotivDataGridViewTextBoxColumn.Name = "numeMotivDataGridViewTextBoxColumn";
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            // 
            // clasaDataGridViewTextBoxColumn
            // 
            this.clasaDataGridViewTextBoxColumn.DataPropertyName = "Clasa";
            this.clasaDataGridViewTextBoxColumn.HeaderText = "Clasa";
            this.clasaDataGridViewTextBoxColumn.Name = "clasaDataGridViewTextBoxColumn";
            // 
            // exmatriculariBindingSource
            // 
            this.exmatriculariBindingSource.DataMember = "Exmatriculari";
            this.exmatriculariBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtNr);
            this.panel1.Controls.Add(this.txtClasa);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmbStudent);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbMotiv);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(513, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 233);
            this.panel1.TabIndex = 6;
            // 
            // txtNr
            // 
            this.txtNr.Location = new System.Drawing.Point(11, 191);
            this.txtNr.Name = "txtNr";
            this.txtNr.Size = new System.Drawing.Size(108, 20);
            this.txtNr.TabIndex = 9;
            // 
            // txtClasa
            // 
            this.txtClasa.Location = new System.Drawing.Point(52, 142);
            this.txtClasa.Name = "txtClasa";
            this.txtClasa.Size = new System.Drawing.Size(108, 20);
            this.txtClasa.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Clasa";
            // 
            // cmbStudent
            // 
            this.cmbStudent.DataSource = this.eleviBindingSource;
            this.cmbStudent.DisplayMember = "Nume";
            this.cmbStudent.FormattingEnabled = true;
            this.cmbStudent.Location = new System.Drawing.Point(52, 102);
            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.Size = new System.Drawing.Size(108, 21);
            this.cmbStudent.TabIndex = 5;
            this.cmbStudent.ValueMember = "IdElev";
            this.cmbStudent.SelectedIndexChanged += new System.EventHandler(this.cmbStudent_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Elev";
            // 
            // cmbMotiv
            // 
            this.cmbMotiv.DataSource = this.motiveExmatriculariBindingSource;
            this.cmbMotiv.DisplayMember = "NumeMotiv";
            this.cmbMotiv.FormattingEnabled = true;
            this.cmbMotiv.Location = new System.Drawing.Point(52, 61);
            this.cmbMotiv.Name = "cmbMotiv";
            this.cmbMotiv.Size = new System.Drawing.Size(108, 21);
            this.cmbMotiv.TabIndex = 3;
            this.cmbMotiv.ValueMember = "IdMotiv";
            // 
            // motiveExmatriculariBindingSource
            // 
            this.motiveExmatriculariBindingSource.DataMember = "MotiveExmatriculari";
            this.motiveExmatriculariBindingSource.DataSource = this.dataSet1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Motiv";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(52, 15);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(108, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data";
            // 
            // exmatriculariTableAdapter
            // 
            this.exmatriculariTableAdapter.ClearBeforeFill = true;
            // 
            // motiveExmatriculariTableAdapter
            // 
            this.motiveExmatriculariTableAdapter.ClearBeforeFill = true;
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOp.Location = new System.Drawing.Point(24, 24);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(0, 20);
            this.lblOp.TabIndex = 7;
            // 
            // eleviBindingSource
            // 
            this.eleviBindingSource.DataMember = "Elevi";
            this.eleviBindingSource.DataSource = this.dataSet1;
            // 
            // eleviTableAdapter
            // 
            this.eleviTableAdapter.ClearBeforeFill = true;
            // 
            // EvenimentExmatriculare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 397);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRenuntare);
            this.Controls.Add(this.btnConfirmare);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnModificare);
            this.Controls.Add(this.btnAdaugare);
            this.Name = "EvenimentExmatriculare";
            this.Text = "EvenimentExmatriculare";
            this.Load += new System.EventHandler(this.EvenimentExmatriculare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exmatriculariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.motiveExmatriculariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eleviBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Button btnModificare;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnConfirmare;
        private System.Windows.Forms.Button btnRenuntare;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNr;
        private System.Windows.Forms.TextBox txtClasa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbStudent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMotiv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource exmatriculariBindingSource;
        private DataSet1TableAdapters.ExmatriculariTableAdapter exmatriculariTableAdapter;
        private System.Windows.Forms.BindingSource motiveExmatriculariBindingSource;
        private DataSet1TableAdapters.MotiveExmatriculariTableAdapter motiveExmatriculariTableAdapter;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataExmatriculareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeMotivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clasaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource eleviBindingSource;
        private DataSet1TableAdapters.EleviTableAdapter eleviTableAdapter;
    }
}