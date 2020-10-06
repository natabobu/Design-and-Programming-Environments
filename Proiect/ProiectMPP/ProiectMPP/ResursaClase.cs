using System;
using System.Windows.Forms;

namespace ProiectMPP
{
    public partial class ResursaClase : Form
    {
        public ResursaClase()
        {
            InitializeComponent();
        }

        private void ResursaClase_Load(object sender, EventArgs e)
        {
            //A1
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
            this.claseTableAdapter.Fill(this.dataSet1.Clase);
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

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            //A3
            config(true);
            refresh();
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            //A4
            try
            {
                this.claseTableAdapter.Update(this.dataSet1.Clase);
                config(true);
                refresh();
            }
            catch (Exception exc)
            {
                string s = exc.Message;
                if (s.IndexOf("duplicate values") > 0)
                    MessageBox.Show("Inregistrare deja existenta !");
                else if (s.IndexOf("cannot be deleted") > 0)
                    MessageBox.Show("Ati sters inregistrari referite in alte tabele !");
            }
        }

        private void btnActualizare_Click(object sender, EventArgs e)
        {
            //A2
            config(false);
        }
    }
}
