using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.RF' table. You can move, or remove it, as needed.
            this.rFTableAdapter.Fill(this.dataSet1.RF);
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
            rFTableAdapter.Fill(this.dataSet1.RF);
        }

        private void btnActualizare_Click(object sender, EventArgs e)
        {
            //A2
            config(false);

        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            //A4
            try
            {
                rFTableAdapter.Update(this.dataSet1.RF);
                config(true);
                refresh();
            }
            catch (Exception exc)
            {
                string s = exc.Message;
                if (s.IndexOf("duplicate values") > 0)
                    MessageBox.Show("Inregistrare deja existenta ! Cheie semantica duplicat");
                else if (s.IndexOf("cannot be deleted") > 0)
                    MessageBox.Show("Ati sters inregistrari referite in alte tabele !");
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
