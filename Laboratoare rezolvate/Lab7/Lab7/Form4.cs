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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime d1 = new DateTime(date1.Value.Year, date1.Value.Month, date1.Value.Day);
            DateTime d2 = new DateTime(date2.Value.Year, date2.Value.Month, date2.Value.Day);
            this.platiTableAdapter.Fill(this.dataSet1.Plati, d1, d2);
            Boolean a = Equals(d1, d2);
            if(a)
            {
                this.Text = "Lista platilor din ziua " + date1.Value.ToShortDateString();
            }
            else
            {
                this.Text = "Bobu Natalia Tema 3";
            }
        }
    }
}
