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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Localitati' table. You can move, or remove it, as needed.
            this.localitatiTableAdapter.Fill(this.dataSet1.Localitati);
            this.comboBox1.SelectedIndex = -1;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String localitate = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            this.persoaneTableAdapter.Fill(this.dataSet1.Persoane, localitate);
        }

    }
}
