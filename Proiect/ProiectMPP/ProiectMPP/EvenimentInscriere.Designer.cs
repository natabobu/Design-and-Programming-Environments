namespace ProiectMPP
{
    partial class EvenimentInscriere
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
            this.dataInscriereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeTipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inscrieriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new ProiectMPP.DataSet1();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCurrentClass = new System.Windows.Forms.Label();
            this.lblCurrentClass = new System.Windows.Forms.Label();
            this.cmbStudent = new System.Windows.Forms.ComboBox();
            this.eleviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new ProiectMPP.DataSet1();
            this.txtNr = new System.Windows.Forms.TextBox();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.claseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblClass = new System.Windows.Forms.Label();
            this.lblStudent = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.tipuriInscrieriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.inscrieriTableAdapter = new ProiectMPP.DataSet1TableAdapters.InscrieriTableAdapter();
            this.tipuriInscrieriTableAdapter = new ProiectMPP.DataSet1TableAdapters.TipuriInscrieriTableAdapter();
            this.claseTableAdapter = new ProiectMPP.DataSet1TableAdapters.ClaseTableAdapter();
            this.lblOp = new System.Windows.Forms.Label();
            this.eleviTableAdapter = new ProiectMPP.DataSet1TableAdapters.EleviTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscrieriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eleviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.claseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipuriInscrieriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(25, 72);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(75, 23);
            this.btnAdaugare.TabIndex = 0;
            this.btnAdaugare.Text = "Adaugare";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // btnModificare
            // 
            this.btnModificare.Location = new System.Drawing.Point(134, 72);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(75, 23);
            this.btnModificare.TabIndex = 1;
            this.btnModificare.Text = "Modificare";
            this.btnModificare.UseVisualStyleBackColor = true;
            this.btnModificare.Click += new System.EventHandler(this.btnModificare_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(244, 72);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(75, 23);
            this.btnStergere.TabIndex = 2;
            this.btnStergere.Text = "Stergere";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnConfirmare
            // 
            this.btnConfirmare.Location = new System.Drawing.Point(480, 72);
            this.btnConfirmare.Name = "btnConfirmare";
            this.btnConfirmare.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmare.TabIndex = 3;
            this.btnConfirmare.Text = "Confirmare";
            this.btnConfirmare.UseVisualStyleBackColor = true;
            this.btnConfirmare.Click += new System.EventHandler(this.btnConfirmare_Click);
            // 
            // btnRenuntare
            // 
            this.btnRenuntare.Location = new System.Drawing.Point(626, 72);
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
            this.dataInscriereDataGridViewTextBoxColumn,
            this.numeTipDataGridViewTextBoxColumn,
            this.numeDataGridViewTextBoxColumn,
            this.clasaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.inscrieriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 205);
            this.dataGridView1.TabIndex = 5;
            // 
            // dataInscriereDataGridViewTextBoxColumn
            // 
            this.dataInscriereDataGridViewTextBoxColumn.DataPropertyName = "DataInscriere";
            this.dataInscriereDataGridViewTextBoxColumn.HeaderText = "DataInscriere";
            this.dataInscriereDataGridViewTextBoxColumn.Name = "dataInscriereDataGridViewTextBoxColumn";
            // 
            // numeTipDataGridViewTextBoxColumn
            // 
            this.numeTipDataGridViewTextBoxColumn.DataPropertyName = "NumeTip";
            this.numeTipDataGridViewTextBoxColumn.HeaderText = "NumeTip";
            this.numeTipDataGridViewTextBoxColumn.Name = "numeTipDataGridViewTextBoxColumn";
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
            // inscrieriBindingSource
            // 
            this.inscrieriBindingSource.DataMember = "Inscrieri";
            this.inscrieriBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCurrentClass);
            this.panel1.Controls.Add(this.lblCurrentClass);
            this.panel1.Controls.Add(this.cmbStudent);
            this.panel1.Controls.Add(this.txtNr);
            this.panel1.Controls.Add(this.cmbClass);
            this.panel1.Controls.Add(this.lblClass);
            this.panel1.Controls.Add(this.lblStudent);
            this.panel1.Controls.Add(this.cmbType);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(480, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 205);
            this.panel1.TabIndex = 6;
            // 
            // txtCurrentClass
            // 
            this.txtCurrentClass.AutoSize = true;
            this.txtCurrentClass.Location = new System.Drawing.Point(266, 100);
            this.txtCurrentClass.Name = "txtCurrentClass";
            this.txtCurrentClass.Size = new System.Drawing.Size(0, 13);
            this.txtCurrentClass.TabIndex = 14;
            // 
            // lblCurrentClass
            // 
            this.lblCurrentClass.AutoSize = true;
            this.lblCurrentClass.Location = new System.Drawing.Point(190, 100);
            this.lblCurrentClass.Name = "lblCurrentClass";
            this.lblCurrentClass.Size = new System.Drawing.Size(75, 13);
            this.lblCurrentClass.TabIndex = 12;
            this.lblCurrentClass.Text = "Clasa curenta:";
            // 
            // cmbStudent
            // 
            this.cmbStudent.DataSource = this.eleviBindingSource;
            this.cmbStudent.DisplayMember = "Nume";
            this.cmbStudent.FormattingEnabled = true;
            this.cmbStudent.Location = new System.Drawing.Point(63, 97);
            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.Size = new System.Drawing.Size(121, 21);
            this.cmbStudent.TabIndex = 11;
            this.cmbStudent.ValueMember = "IdElev";
            // 
            // eleviBindingSource
            // 
            this.eleviBindingSource.DataMember = "Elevi";
            this.eleviBindingSource.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNr
            // 
            this.txtNr.Location = new System.Drawing.Point(13, 182);
            this.txtNr.Name = "txtNr";
            this.txtNr.Size = new System.Drawing.Size(121, 20);
            this.txtNr.TabIndex = 9;
            // 
            // cmbClass
            // 
            this.cmbClass.DataSource = this.claseBindingSource;
            this.cmbClass.DisplayMember = "Clasa";
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(63, 135);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(121, 21);
            this.cmbClass.TabIndex = 7;
            this.cmbClass.ValueMember = "IdClasa";
            // 
            // claseBindingSource
            // 
            this.claseBindingSource.DataMember = "Clase";
            this.claseBindingSource.DataSource = this.dataSet1;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(10, 135);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(33, 13);
            this.lblClass.TabIndex = 6;
            this.lblClass.Text = "Clasa";
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Location = new System.Drawing.Point(10, 97);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(28, 13);
            this.lblStudent.TabIndex = 4;
            this.lblStudent.Text = "Elev";
            // 
            // cmbType
            // 
            this.cmbType.DataSource = this.tipuriInscrieriBindingSource;
            this.cmbType.DisplayMember = "NumeTip";
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(65, 57);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(121, 21);
            this.cmbType.TabIndex = 3;
            this.cmbType.ValueMember = "IdTip";
            // 
            // tipuriInscrieriBindingSource
            // 
            this.tipuriInscrieriBindingSource.DataMember = "TipuriInscrieri";
            this.tipuriInscrieriBindingSource.DataSource = this.dataSet1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tip";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(63, 18);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(123, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data";
            // 
            // inscrieriTableAdapter
            // 
            this.inscrieriTableAdapter.ClearBeforeFill = true;
            // 
            // tipuriInscrieriTableAdapter
            // 
            this.tipuriInscrieriTableAdapter.ClearBeforeFill = true;
            // 
            // claseTableAdapter
            // 
            this.claseTableAdapter.ClearBeforeFill = true;
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Location = new System.Drawing.Point(25, 27);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(0, 13);
            this.lblOp.TabIndex = 7;
            // 
            // eleviTableAdapter
            // 
            this.eleviTableAdapter.ClearBeforeFill = true;
            // 
            // EvenimentInscriere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 388);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRenuntare);
            this.Controls.Add(this.btnConfirmare);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnModificare);
            this.Controls.Add(this.btnAdaugare);
            this.Name = "EvenimentInscriere";
            this.Text = "Inscrieri";
            this.Load += new System.EventHandler(this.EvenimentInscriere_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscrieriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eleviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.claseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipuriInscrieriBindingSource)).EndInit();
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
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource inscrieriBindingSource;
        private DataSet1TableAdapters.InscrieriTableAdapter inscrieriTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.BindingSource tipuriInscrieriBindingSource;
        private DataSet1TableAdapters.TipuriInscrieriTableAdapter tipuriInscrieriTableAdapter;
        private System.Windows.Forms.BindingSource claseBindingSource;
        private DataSet1TableAdapters.ClaseTableAdapter claseTableAdapter;
        private System.Windows.Forms.TextBox txtNr;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.ComboBox cmbStudent;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource eleviBindingSource;
        private DataSet1TableAdapters.EleviTableAdapter eleviTableAdapter;
        private System.Windows.Forms.Label lblCurrentClass;
        private System.Windows.Forms.Label txtCurrentClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInscriereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeTipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clasaDataGridViewTextBoxColumn;
    }
}