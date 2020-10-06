using System;
using System.Windows.Forms;

namespace ProiectMPP
{
    public partial class AgentTipuriInscrieri : Form
    {
        public AgentTipuriInscrieri()
        {
            InitializeComponent();
        }

        private void Agent_tipuri_inscrieri_Load(object sender, EventArgs e)
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
            this.tipuriInscrieriTableAdapter.Fill(this.dataSet1.TipuriInscrieri);
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
                this.tipuriInscrieriTableAdapter.Update(this.dataSet1.TipuriInscrieri); 
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

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            //A3
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
