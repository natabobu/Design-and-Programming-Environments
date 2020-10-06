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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime d1 = new DateTime(date1.Value.Year, date1.Value.Month, date1.Value.Day);
            DateTime d2 = new DateTime(date2.Value.Year, date2.Value.Month, date2.Value.Day);
            this.platiTableAdapter1.Fill(this.dataSet11.Plati, d1, d2);
            //Pregatesc parametrii raportului
            Microsoft.Reporting.WinForms.ReportParameter[] parameters = new Microsoft.Reporting.WinForms.ReportParameter[1];
            parameters[0] = new Microsoft.Reporting.WinForms.ReportParameter("Titlu", "Lista incasarilor din perioada " + d1.ToShortDateString() +
                                                                     " - " + d2.ToShortDateString());

            //Comunicare parametrii
            this.reportViewer1.LocalReport.SetParameters(parameters);

            //Emit raport
            this.reportViewer1.RefreshReport();
        }
    }
}
