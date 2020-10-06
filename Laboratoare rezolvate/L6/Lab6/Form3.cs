using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'IncasariDS.ResursaFinanciara' table. You can move, or remove it, as needed.
            this.ResursaFinanciaraTableAdapter.Fill(this.IncasariDS.ResursaFinanciara);

            this.reportViewer1.RefreshReport();
        }
    }
}
