namespace ProiectMPP
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eleviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.claseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evenimenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscriereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exmatriculareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resurseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipuriInscriereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motiveExmatriculareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titlu: Aplicatie pentru gestiunea elevilor unui liceu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Autor: Bobu Natalia";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agentiToolStripMenuItem,
            this.evenimenteToolStripMenuItem,
            this.resurseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(430, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agentiToolStripMenuItem
            // 
            this.agentiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eleviToolStripMenuItem,
            this.claseToolStripMenuItem});
            this.agentiToolStripMenuItem.Name = "agentiToolStripMenuItem";
            this.agentiToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.agentiToolStripMenuItem.Text = "Resurse";
            // 
            // eleviToolStripMenuItem
            // 
            this.eleviToolStripMenuItem.Name = "eleviToolStripMenuItem";
            this.eleviToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eleviToolStripMenuItem.Text = "Elevi";
            this.eleviToolStripMenuItem.Click += new System.EventHandler(this.eleviToolStripMenuItem_Click);
            // 
            // claseToolStripMenuItem
            // 
            this.claseToolStripMenuItem.Name = "claseToolStripMenuItem";
            this.claseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.claseToolStripMenuItem.Text = "Clase";
            this.claseToolStripMenuItem.Click += new System.EventHandler(this.claseToolStripMenuItem_Click);
            // 
            // evenimenteToolStripMenuItem
            // 
            this.evenimenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inscriereToolStripMenuItem,
            this.exmatriculareToolStripMenuItem});
            this.evenimenteToolStripMenuItem.Name = "evenimenteToolStripMenuItem";
            this.evenimenteToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.evenimenteToolStripMenuItem.Text = "Evenimente";
            // 
            // inscriereToolStripMenuItem
            // 
            this.inscriereToolStripMenuItem.Name = "inscriereToolStripMenuItem";
            this.inscriereToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.inscriereToolStripMenuItem.Text = "Inscriere";
            this.inscriereToolStripMenuItem.Click += new System.EventHandler(this.inscriereToolStripMenuItem_Click);
            // 
            // exmatriculareToolStripMenuItem
            // 
            this.exmatriculareToolStripMenuItem.Name = "exmatriculareToolStripMenuItem";
            this.exmatriculareToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.exmatriculareToolStripMenuItem.Text = "Exmatriculare";
            this.exmatriculareToolStripMenuItem.Click += new System.EventHandler(this.exmatriculareToolStripMenuItem_Click);
            // 
            // resurseToolStripMenuItem
            // 
            this.resurseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipuriInscriereToolStripMenuItem,
            this.motiveExmatriculareToolStripMenuItem});
            this.resurseToolStripMenuItem.Name = "resurseToolStripMenuItem";
            this.resurseToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.resurseToolStripMenuItem.Text = "Agenti";
            // 
            // tipuriInscriereToolStripMenuItem
            // 
            this.tipuriInscriereToolStripMenuItem.Name = "tipuriInscriereToolStripMenuItem";
            this.tipuriInscriereToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.tipuriInscriereToolStripMenuItem.Text = "Tipuri Inscriere";
            this.tipuriInscriereToolStripMenuItem.Click += new System.EventHandler(this.tipuriInscriereToolStripMenuItem_Click);
            // 
            // motiveExmatriculareToolStripMenuItem
            // 
            this.motiveExmatriculareToolStripMenuItem.Name = "motiveExmatriculareToolStripMenuItem";
            this.motiveExmatriculareToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.motiveExmatriculareToolStripMenuItem.Text = "Motive Exmatriculare";
            this.motiveExmatriculareToolStripMenuItem.Click += new System.EventHandler(this.motiveExmatriculareToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 140);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Medii de proiectare si programare";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evenimenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resurseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motiveExmatriculareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipuriInscriereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscriereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exmatriculareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eleviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem claseToolStripMenuItem;
    }
}

