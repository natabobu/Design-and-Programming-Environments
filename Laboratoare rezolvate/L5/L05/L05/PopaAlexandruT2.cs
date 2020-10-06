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
    public partial class PopaAlexandruT2 : Form
    {
        public PopaAlexandruT2()
        {
            InitializeComponent();
        }

        private void PopaAlexandruT2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.Furnizori' table. You can move, or remove it, as needed.
            this.furnizoriTableAdapter.Fill(this.dataSet2.Furnizori);
            config(true);
            refresh();

        }
        private void config(bool v)
        {
            dataGridView1.AllowUserToAddRows = !v;
            dataGridView1.AllowUserToDeleteRows = !v;
            dataGridView1.ReadOnly = v;
            btnActualizare.Enabled = v;
            btnSalvare.Visible = !v;
            btnRenuntare.Visible = !v;
        }
        private void refresh()
        {
            furnizoriTableAdapter.Fill(dataSet2.Furnizori);
        }

        private void btnActualizare_Click(object sender, EventArgs e)
        {
            config(false);
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            try
            {
                furnizoriTableAdapter.Update(dataSet2.Furnizori);
                config(true);
                refresh();
            }
            catch (Exception exception)
            {
                string s = exception.Message;
                if (s.IndexOf("duplicate values") > 0)
                {
                    MessageBox.Show("Inregistrare deja existenta");
                }
                else if (s.IndexOf("cannot be deleted") > 0)
                {
                    MessageBox.Show("Ati sters inreegistrari referite in alte tabele !");
                }
            }
        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            config(true);
            refresh();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Format eronat");
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) e.Cancel = true;
        }
    }
}
