﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'IncasariDS.Incasari' table. You can move, or remove it, as needed.
            this.IncasariTableAdapter.Fill(this.IncasariDS.Incasari);

            this.reportViewer1.RefreshReport();
        }
    }
}
