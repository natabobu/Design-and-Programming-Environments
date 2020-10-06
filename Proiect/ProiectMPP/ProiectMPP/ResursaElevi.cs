using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ProiectMPP
{
    public partial class ResursaElevi : Form
    {
        public ResursaElevi()
        {
            InitializeComponent();
        }

        private void ResursaElevi_Load(object sender, EventArgs e)
        {
            A1();
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            A2();
        }

        private void btnModificare_Click(object sender, EventArgs e)
        {
            A5();
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No)
                return;
            A6();
        }

        private void btnConfirmare_Click(object sender, EventArgs e)
        {
            A4();
        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            A3();
        }
        private void A1()
        {
            //Umple cu date obiectele DataTable
            eleviDetaliiTableAdapter.Fill(dataSet1.EleviDetalii);

            //Configurare comboBox-uri    
            cmbSex.DropDownStyle = ComboBoxStyle.Simple;

            //Protectie grid        
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;

            //Protectie txtIdElev      
            txtId.ReadOnly = true;
            txtId.Visible = false;
            A3();
        }
        private void A2()
        {
            //Configurare butoane    
            configureazaButoane(false);

            //Dezlegare controale Panel       
            legareControale(false);

            //Ridicare protectie controale Panel    
            protectiePanel(false);

            //Configurare(ComboBox - Uri)   
            cmbSex.DropDownStyle = ComboBoxStyle.DropDownList;
        

            //Modifcare lblOp        
            lblOp.Text = "ADAUGARE";

            //Pozitionare cursor pe primul camp    
            txtNume.Focus();

            // Golire campuri          
            golireCampuri();
        }
        private void A3()
        {
            //Configurare comboBox-uri   
            cmbSex.DropDownStyle = ComboBoxStyle.Simple;

            //Initializare lblOp         
            lblOp.Text = "";

            //Çonfigurare(butoane)  
            configureazaButoane(true);

            //Protectie componente Panel    
            protectiePanel(true);

            //Legare controale           
            legareControale(true);
        }
        private void A4()
        {
            if (!validareCampuri())
                return;
            if (lblOp.Text == "ADAUGARE")
            {              
                adauga_inregistrare();
                golireCampuri();

                //Pune cursor pe primul camp      
                txtNume.Focus();
                refresh_grid(eleviDetaliiBindingSource.Position);
            }
            else if (lblOp.Text == "MODIFICARE")
            {
                modifica_inregistrare();
                refresh_grid(eleviDetaliiBindingSource.Position);
                A3();
            }
            else
            {
                MessageBox.Show("Operatie actualizare neefectuata");
            }
        }
        private void A5()
        {
            //Configurare butoane      
            configureazaButoane(false);

            //Dezlegare controale Panel 
            legareControale(true);

            //Ridicare protectie controale Panel  
            protectiePanel(false);

            //Configurare(ComboBox - Uri)   
            cmbSex.DropDownStyle = ComboBoxStyle.DropDownList;

            //Modifcare lblOp        
            lblOp.Text = "MODIFICARE";

            //Pozitionare cursor pe primul camp      
            txtNume.Focus();
        }

        private void A6()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            con.ConnectionString = eleviDetaliiTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            cmd.CommandText = "Delete From Elevi Where IdElev = " + txtId.Text;        
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }catch(Exception e)
            {
                if (e.HResult == (-2147467259))
                {
                    MessageBox.Show("Nu puteti sterge acest elev !");
                    return;
                }
            }
            //MessageBox.Show(cmd.CommandText);
            con.Close();
            refresh_grid(eleviDetaliiBindingSource.Position);
        }
        private void configureazaButoane(bool v)
        {
            btnRenuntare.Visible = !v;
            btnConfirmare.Visible = !v;
            btnAdaugare.Enabled = v;
            btnModificare.Enabled = v;
            btnStergere.Enabled = v;
        }
        private void protectiePanel(bool v)
        {
            txtNume.Enabled = !v;
            txtCNP.Enabled = !v;
            cmbSex.Enabled =!v;
            dateTimePicker1.Enabled = !v;
        }

        private void golireCampuri()
        {
            cmbSex.SelectedIndex = -1;
            txtNume.Text = "";
            txtId.Text = "";
            txtCNP.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }
        public void clearDataBindings()
        {
            txtNume.DataBindings.Clear();
            txtCNP.DataBindings.Clear();
            dateTimePicker1.DataBindings.Clear();
            cmbSex.DataBindings.Clear();
            txtId.DataBindings.Clear();
        }
        private void refresh_grid(int p)
        {
            dataSet1.Inscrieri.Clear();
            eleviDetaliiTableAdapter.Fill(dataSet1.EleviDetalii);
            eleviDetaliiBindingSource.Position = p;
        }
        private void legareControale(bool v)
        {
            clearDataBindings();
            if (v)
            {
                cmbSex.DataBindings.Add("Text", eleviDetaliiBindingSource, "Sex");
                txtNume.DataBindings.Add("Text", eleviDetaliiBindingSource, "Nume");
                txtCNP.DataBindings.Add("Text", eleviDetaliiBindingSource, "CNP");
                txtId.DataBindings.Add("Text", eleviDetaliiBindingSource, "IdElev");
                dateTimePicker1.DataBindings.Add("Text", eleviDetaliiBindingSource, "DataNastere");
            }
        }

        
        private bool validareCampuri()
        {
            //Validare de completare obligatorie campurile
            if (txtNume.Text == "")
            {
                MessageBox.Show("Introduceti numele elevului  !");
                txtNume.Focus();
                return false;
            }
            if (txtCNP.Text == "")
            {
                MessageBox.Show("Introduceti CNP !");
                txtCNP.Focus();
                return false;
            }
            if (cmbSex.Text == "")
            {
                MessageBox.Show("Selectati sex-ul !");
                cmbSex.Focus();
                return false;
            }
            try
            {
                int a = Int32.Parse(txtCNP.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("CNP contine caractere invalide!");
                return false;
            }
            System.String cnp = txtCNP.Text;
            foreach(DataRow r in dataSet1.EleviDetalii.Rows)
            {
                if (String.Equals(cnp, r["CNP"]))
                {
                    MessageBox.Show("CNP duplicat !!!");
                    txtCNP.Focus();
                    return false;
                }
            }

            return true;
        }

        
        private void modifica_inregistrare()
        {
            string listaSet;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            con.ConnectionString = eleviDetaliiTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            listaSet = "Set DataNastere = #" + dateTimePicker1.Value.Month + "/" + dateTimePicker1.Value.Day + "/" + dateTimePicker1.Value.Year + "#," + "Nume = '" + txtNume.Text + "'," + "CNP = '" + txtCNP.Text + "'," + "Sex = '" + cmbSex.Text+"'";
            cmd.CommandText = "Update EleviDetalii " + listaSet + " Where IdElev=" + txtId.Text;
            MessageBox.Show(cmd.CommandText);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void adauga_inregistrare()
        {
            string listaCampuri;
            string listaValori;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            con.ConnectionString = eleviDetaliiTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            listaCampuri = "Nume, CNP, DataNastere, Sex";
            listaValori = "'"+txtNume.Text+"','"+txtCNP.Text+"',"+"#" + dateTimePicker1.Value.Month + "/" + dateTimePicker1.Value.Day + "/" + dateTimePicker1.Value.Year + "#,'" + cmbSex.Text+"'";
            cmd.CommandText = "Insert into Elevi(" + listaCampuri + ") Select " + listaValori;
            MessageBox.Show(cmd.CommandText);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }
}
