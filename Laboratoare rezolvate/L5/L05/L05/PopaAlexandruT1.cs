using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L05
{
    public partial class PopaAlexandruT1 : Form
    {
        public PopaAlexandruT1()
        {
            InitializeComponent();
        }

        private void PopaAlexandruT1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Furnizori' table. You can move, or remove it, as needed.
            this.furnizoriTableAdapter.Fill(this.dataSet1.Furnizori);
            sumaTextBox();
        }

        private void sumaTextBox()
        {
            Int32 suma = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                suma += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
            }
            textBox1.Text = suma.ToString();
        }
    }
}
