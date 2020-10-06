using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ProiectMPP
{
    public partial class EvenimentExmatriculare : Form
    {
        int idElevVechi;
        String idClasaVeche;
        public EvenimentExmatriculare()
        {
            InitializeComponent();
        }

        private void EvenimentExmatriculare_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Elevi' table. You can move, or remove it, as needed.
            this.eleviTableAdapter.Fill(this.dataSet1.Elevi);
            A1();

        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            A2();
        }

        private void btnModificare_Click(object sender, EventArgs e)
        {
            idElevVechi = (int)cmbStudent.SelectedValue;
            DataTable t;
            t = dataSet1.Elevi;
            foreach (DataRow y in t.Rows)
            {
                if ((int)y["IdElev"] == idElevVechi)
                {
                    idClasaVeche = y["IdClasa"].ToString();
                }
            }
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
            exmatriculariTableAdapter.Fill(dataSet1.Exmatriculari);
            motiveExmatriculariTableAdapter.Fill(dataSet1.MotiveExmatriculari);
            eleviTableAdapter.Fill(this.dataSet1.Elevi);

            //Configurare comboBox-uri    
            configurareComboBoxuri(false);

            //Protectie grid        
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;

            //Protectie txtIdPersoana       
            txtClasa.ReadOnly = true;
            txtNr.Visible = false;
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
            configurareComboBoxuri(true);

            //Legare comboBox-uri la sursa de date
            legareComboBoxuri(true);

            //Modifcare lblOp        
            lblOp.Text = "ADAUGARE";

            //Pozitionare cursor pe primul camp    
            dateTimePicker1.Focus();

            // Golire campuri          
            golireCampuri();
        }
        private void A3()
        {
            //Configurare comboBox-uri   
            configurareComboBoxuri(false);

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
                dateTimePicker1.Focus();
                refresh_grid(exmatriculariBindingSource.Position);
            }
            else if (lblOp.Text == "MODIFICARE")
            {
                modifica_inregistrare();
                refresh_grid(exmatriculariBindingSource.Position);
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
            configurareComboBoxuri(true);

            //Legare comboBox-uri la sursa de date           
            legareComboBoxuri(true);

            //Modifcare lblOp        
            lblOp.Text = "MODIFICARE";

            //Pozitionare cursor pe primul camp      
            dateTimePicker1.Focus();
            txtClasa.Text = "";
        }

        private void A6()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            con.ConnectionString = exmatriculariTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            cmd.CommandText = "Delete From Exmatriculari Where NrExmatriculare = " + txtNr.Text;
            MessageBox.Show(cmd.CommandText);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            refresh_grid(exmatriculariBindingSource.Position);
        }
        private void configureazaButoane(bool v)
        {
            btnRenuntare.Visible = !v;
            btnConfirmare.Visible = !v;
            btnAdaugare.Enabled = v;
            btnModificare.Enabled = v;
            btnStergere.Enabled = v;
        }


        private void legareControale(bool v)
        {
            clearDataBindings();
            if (v)
            {             
                cmbStudent.DataBindings.Add("Text", exmatriculariBindingSource, "Nume");
                cmbMotiv.DataBindings.Add("Text", exmatriculariBindingSource, "NumeMotiv");
                txtClasa.DataBindings.Add("Text", exmatriculariBindingSource, "Clasa");              
                txtNr.DataBindings.Add("Text", exmatriculariBindingSource, "NrExmatriculare");             
                dateTimePicker1.DataBindings.Add("Text", exmatriculariBindingSource, "DataExmatriculare");
            }
        }

        private void protectiePanel(bool v)
        {
            cmbStudent.Enabled = !v;
            cmbMotiv.Enabled = !v;
        }

        private void golireCampuri()
        {
            cmbStudent.SelectedIndex = -1;
            cmbMotiv.SelectedIndex = -1;
            txtNr.Text = "";
            txtClasa.Text = " ";
            dateTimePicker1.Value = DateTime.Now;
        }

        private bool validareCampuri()
        {
            //Validare de completare obligatorie campurile
            if (cmbStudent.Text == "")
            {
                MessageBox.Show("Selectati un elev  !");
                cmbStudent.Focus();
                return false;
            }
            if (cmbMotiv.Text == "")
            {
                MessageBox.Show("Selectati motivul exmatricularii !");
                cmbMotiv.Focus();
                return false;
            }
            if (txtClasa.Text == "")
            {
                MessageBox.Show("Selectati un elev inregistrat intr-o clasa !");
                txtClasa.Focus();
                return false;
            }
            

            return true;
        }

        private void refresh_grid(int p)
        {
            dataSet1.Exmatriculari.Clear();
            exmatriculariTableAdapter.Fill(dataSet1.Exmatriculari);
            exmatriculariBindingSource.Position = p;
        }

        private void adauga_inregistrare()
        {
            string listaCampuri;
            string listaValori;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            con.ConnectionString = exmatriculariTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            listaCampuri = "DataExmatriculare, IdMotiv, IdElev, IdClasa";
            DataTable t;
            int x;
            x = (int)cmbStudent.SelectedValue;
            t = dataSet1.Elevi;
            int IdClasa=0;
            foreach (DataRow y in t.Rows)
            {
                if ((int)y["IdElev"] == x)
                {
                    IdClasa = (int)y["IdClasa"];
                }
            }
            listaValori = "#" + dateTimePicker1.Value.Month + "/" + dateTimePicker1.Value.Day + "/" + dateTimePicker1.Value.Year + "#," + cmbMotiv.SelectedValue + "," + cmbStudent.SelectedValue+","+IdClasa;
            cmd.CommandText = "Insert into Exmatriculari(" + listaCampuri + ") Select " + listaValori;
            MessageBox.Show(cmd.CommandText);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                if (e.HResult == -2147467259)
                {
                    MessageBox.Show("Cheie semantica duplicat! Schimbati data sau selectati alt elev!");
                    return;
                }
            }
            cmd.CommandText = "Update Registru Set IdClasa=NULL Where IdElev=" + cmbStudent.SelectedValue;
            MessageBox.Show(cmd.CommandText);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void modifica_inregistrare()
        {
            string listaSet;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            con.ConnectionString = exmatriculariTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            DataTable t;
            int x;
            x = (int)cmbStudent.SelectedValue;
            t = dataSet1.Elevi;
            int IdClasa=0;
            foreach (DataRow y in t.Rows)
            {
                if ((int)y["IdElev"] == x)
                {
                    IdClasa = (int)y[2];
                }
            }
            listaSet = "Set DataExmatriculare = #" + dateTimePicker1.Value.Month + "/" + dateTimePicker1.Value.Day + "/" + dateTimePicker1.Value.Year + "#," + "IdMotiv = " + cmbMotiv.SelectedValue + "," + "IdClasa = " + IdClasa + "," + "IdElev = " + cmbStudent.SelectedValue;
            cmd.CommandText = "Update Exmatriculari " + listaSet + " Where NrExmatriculare=" + txtNr.Text;
            MessageBox.Show(cmd.CommandText);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                if (e.HResult == -2147467259)
                {
                    MessageBox.Show("Cheie semantica duplicat! Schimbati data sau selectati alt elev!");
                    return;
                }
            }
            cmd.CommandText = "Update Registru Set IdClasa=" + idClasaVeche + " Where IdElev=" + idElevVechi;
            MessageBox.Show(cmd.CommandText);
            cmd.ExecuteNonQuery();
            cmd.CommandText = "Update Registru Set IdClasa=null Where IdElev=" + cmbStudent.SelectedValue;
            MessageBox.Show(cmd.CommandText);
            cmd.ExecuteNonQuery();          
            con.Close();
        }
        public void legareComboBoxuri(Boolean v)
        {
            clearDataBindings();
            if (v)
            {
                cmbMotiv.DataSource = motiveExmatriculariBindingSource;
                cmbMotiv.DisplayMember = "NumeMotiv";
                cmbMotiv.ValueMember = "IdMotiv";
                cmbStudent.DataSource = eleviBindingSource;
                cmbStudent.DisplayMember = "Nume";
                cmbStudent.ValueMember = "IdElev";
            }
        }
        public void configurareComboBoxuri(Boolean v)
        {
            if (v)
            {
                cmbMotiv.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            else
            {
                cmbMotiv.DropDownStyle = ComboBoxStyle.Simple;
                cmbStudent.DropDownStyle = ComboBoxStyle.Simple;
            }

        }
        public void clearDataBindings()
        {
            cmbStudent.DataBindings.Clear();
            cmbMotiv.DataBindings.Clear();
            txtClasa.DataBindings.Clear();
            txtNr.DataBindings.Clear();
            dateTimePicker1.DataBindings.Clear();
        }

        private void cmbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable t; 
            int x;
            if (lblOp.Text == "") 
                return; 
            if (cmbStudent.Text == "") 
                return;
            x = (int)cmbStudent.SelectedValue;
            t = dataSet1.Elevi;
            foreach(DataRow y in t.Rows){
                if ((int)y["IdElev"] == x)
                {
                    txtClasa.Text = y[3].ToString();
                }
            }

        }
    }
}
