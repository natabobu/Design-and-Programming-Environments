using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tema1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 tema1 = new Form2();
            tema1.ShowDialog();
        }

        private void tema2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 tema2 = new Form3();
            tema2.ShowDialog();
        }

        private void tema3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 tema3 = new Form4();
            tema3.ShowDialog();
        }

        private void tema4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 tema4 = new Form5();
            tema4.ShowDialog();
        }
    }
}
