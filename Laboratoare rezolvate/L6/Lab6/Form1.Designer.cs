﻿namespace Lab6
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.IncasariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IncasariDS = new Lab6.IncasariDS();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.IncasariTableAdapter = new Lab6.IncasariDSTableAdapters.IncasariTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.IncasariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncasariDS)).BeginInit();
            this.SuspendLayout();
            // 
            // IncasariBindingSource
            // 
            this.IncasariBindingSource.DataMember = "Incasari";
            this.IncasariBindingSource.DataSource = this.IncasariDS;
            // 
            // IncasariDS
            // 
            this.IncasariDS.DataSetName = "IncasariDS";
            this.IncasariDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.IncasariBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Lab6.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 21);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(678, 395);
            this.reportViewer1.TabIndex = 0;
            // 
            // IncasariTableAdapter
            // 
            this.IncasariTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 428);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Bobu Natalia Tema 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IncasariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncasariDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource IncasariBindingSource;
        private IncasariDS IncasariDS;
        private IncasariDSTableAdapters.IncasariTableAdapter IncasariTableAdapter;
    }
}
