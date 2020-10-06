namespace Lab7
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tema1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tema2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tema3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tema4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tema1ToolStripMenuItem,
            this.tema2ToolStripMenuItem,
            this.tema3ToolStripMenuItem,
            this.tema4ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(321, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tema1ToolStripMenuItem
            // 
            this.tema1ToolStripMenuItem.Name = "tema1ToolStripMenuItem";
            this.tema1ToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.tema1ToolStripMenuItem.Text = "Tema 1";
            this.tema1ToolStripMenuItem.Click += new System.EventHandler(this.tema1ToolStripMenuItem_Click);
            // 
            // tema2ToolStripMenuItem
            // 
            this.tema2ToolStripMenuItem.Name = "tema2ToolStripMenuItem";
            this.tema2ToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.tema2ToolStripMenuItem.Text = "Tema 2";
            this.tema2ToolStripMenuItem.Click += new System.EventHandler(this.tema2ToolStripMenuItem_Click);
            // 
            // tema3ToolStripMenuItem
            // 
            this.tema3ToolStripMenuItem.Name = "tema3ToolStripMenuItem";
            this.tema3ToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.tema3ToolStripMenuItem.Text = "Tema 3";
            this.tema3ToolStripMenuItem.Click += new System.EventHandler(this.tema3ToolStripMenuItem_Click);
            // 
            // tema4ToolStripMenuItem
            // 
            this.tema4ToolStripMenuItem.Name = "tema4ToolStripMenuItem";
            this.tema4ToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.tema4ToolStripMenuItem.Text = "Tema 4";
            this.tema4ToolStripMenuItem.Click += new System.EventHandler(this.tema4ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 77);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Bobu Natalia Laborator 7";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tema1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tema2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tema3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tema4ToolStripMenuItem;
    }
}

