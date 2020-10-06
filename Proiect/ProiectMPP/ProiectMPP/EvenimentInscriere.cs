using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectMPP
{
    public partial class EvenimentInscriere : Form
    {
        public EvenimentInscriere()
        {
            InitializeComponent();
        }

        private void EvenimentInscriere_Load(object sender, EventArgs e)
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
            this.eleviTableAdapter.Fill(this.dataSet11.Elevi);
            this.claseTableAdapter.Fill(this.dataSet1.Clase);
            this.tipuriInscrieriTableAdapter.Fill(this.dataSet1.TipuriInscrieri);
            this.inscrieriTableAdapter.Fill(this.dataSet1.Inscrieri);

            //Configurare comboBox-uri    
            configurareComboBoxuri(false);

            //Protectie grid        
            dataGridView1.AllowUserToAddRows = false;     
            dataGridView1.AllowUserToDeleteRows = false; 
            dataGridView1.ReadOnly = true;
            
            //Protectie txtIdPersoana       
            txtNr.ReadOnly = true;
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
            if (lblOp.Text == "ADAUGARE")
            {
                if (!validareCampuri())
                    return;
                adauga_inregistrare();
                golireCampuri();

                //Pune cursor pe primul camp      
                dateTimePicker1.Focus();
                refresh_grid(inscrieriBindingSource.Position);
            }
            else if (lblOp.Text == "MODIFICARE")
            {
                modifica_inregistrare();
                refresh_grid(inscrieriBindingSource.Position);
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
        } 

            private void A6()
            {
                OleDbConnection con = new OleDbConnection();
                OleDbCommand cmd = new OleDbCommand();

                con.ConnectionString = inscrieriTableAdapter.Connection.ConnectionString;
                cmd.Connection = con;
                cmd.CommandText = "Delete From Inscrieri Where NrInscriere = " + txtNr.Text;
                MessageBox.Show(cmd.CommandText);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                refresh_grid(inscrieriBindingSource.Position);
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
                cmbStudent.DataBindings.Add("Text", inscrieriBindingSource, "Nume");
                cmbType.DataBindings.Add("Text", inscrieriBindingSource, "NumeTip");
                cmbClass.DataBindings.Add("Text", inscrieriBindingSource, "Clasa");
                txtNr.DataBindings.Add("Text", inscrieriBindingSource, "NrInscriere");
                dateTimePicker1.DataBindings.Add("Text", inscrieriBindingSource, "DataInscriere");
            }
        }
        
        private void protectiePanel(bool v) 
        {
            cmbStudent.Enabled = !v;
            cmbType.Enabled = !v; 
            cmbClass.Enabled = !v;
            lblCurrentClass.Visible = !v;
            txtCurrentClass.Text = "";
        }

        private void golireCampuri()
        {
            cmbStudent.SelectedIndex = -1;
            cmbType.SelectedIndex = -1;
            cmbClass.SelectedIndex = -1; 
            txtNr.Text = "";
            txtCurrentClass.Text = "";
            dateTimePicker1.DataBindings.Clear();
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
            if (cmbType.Text == "") 
            {               
                MessageBox.Show("Selectati tipul inscrierii !");     
                cmbType.Focus();         
                return false;        
            }         
            if (cmbClass.Text == "") {       
                MessageBox.Show("Selectati clasa in care va fi inscris elevul !");    
                cmbClass.Focus();          
                return false;          
            }
            if((cmbType.Text=="Inceput studii" ||cmbType.Text=="Transfer interscolar")&& txtCurrentClass.Text != "") 
            {
                MessageBox.Show("Acest elev este deja inscris intr-o clasa, selectati un elev care nu are clasa curenta sau alt tip de inscriere !");
                cmbType.Focus();
                return false;
            }
            if(cmbType.Text=="Transfer clasa" && txtCurrentClass.Text == cmbClass.Text)
            {
                MessageBox.Show("Clasa curenta este egala cu clasa de transfer");
                cmbClass.Focus();
                return false;
            }

            return true;
        }

        private void refresh_grid(int p) 
        { 
            dataSet1.Inscrieri.Clear();
            inscrieriTableAdapter.Fill(dataSet1.Inscrieri);
            inscrieriBindingSource.Position = p; 
        }

        private void adauga_inregistrare() 
        {
            string listaCampuri;
            string listaValori;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            con.ConnectionString = inscrieriTableAdapter.Connection.ConnectionString; 
            cmd.Connection = con;
            listaCampuri = "DataInscriere, IdTip, IdElev, IdClasa";
            listaValori = "#" + dateTimePicker1.Value.Month + "/" + dateTimePicker1.Value.Day + "/" + dateTimePicker1.Value.Year + "#," + cmbType.SelectedValue + "," + cmbStudent.SelectedValue+ ","+cmbClass.SelectedValue;
            cmd.CommandText = "Insert into Inscrieri(" + listaCampuri + ") Select " + listaValori;
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
            cmd.CommandText = "Update Registru Set IdClasa=" + cmbClass.SelectedValue + " Where IdElev=" + cmbStudent.SelectedValue;
            MessageBox.Show(cmd.CommandText);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void modifica_inregistrare()
        {
            string listaSet;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand(); 
            con.ConnectionString = inscrieriTableAdapter.Connection.ConnectionString; cmd.Connection = con;
            listaSet = "Set DataInscriere = #" + dateTimePicker1.Value.Month + "/" + dateTimePicker1.Value.Day + "/" + dateTimePicker1.Value.Year + "#," + "IdTip = " + cmbType.SelectedValue + "," + "IdClasa = " + cmbClass.SelectedValue + "," + "IdElev = " + cmbStudent.SelectedValue;
            cmd.CommandText = "Update Inscrieri " + listaSet + " Where NrInscriere=" + txtNr.Text;
            MessageBox.Show(cmd.CommandText);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }catch(Exception e)
            {
                if (e.HResult == -2147467259)
                {
                    MessageBox.Show("Cheie semantica duplicat! Schimbati data sau selectati alt elev!");
                    return;
                }
            }        
            cmd.CommandText = "Update Registru Set IdClasa=" + cmbClass.SelectedValue + " Where IdElev=" + cmbStudent.SelectedValue;
            MessageBox.Show(cmd.CommandText);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void legareComboBoxuri(Boolean v)
        {
            clearDataBindings();
            if (v)
            {
                cmbType.DataSource = tipuriInscrieriBindingSource;
                cmbType.DisplayMember = "NumeTip";
                cmbType.ValueMember = "IdTip";
                cmbClass.DataSource = claseBindingSource;
                cmbClass.DisplayMember = "Clasa";
                cmbClass.ValueMember = "IdClasa";
                cmbStudent.DataSource = eleviBindingSource;
                cmbStudent.DisplayMember = "Nume";
                cmbStudent.ValueMember = "IdElev";
                txtCurrentClass.DataBindings.Add("Text", eleviBindingSource, "Clasa");
            }
        }
        public void configurareComboBoxuri(Boolean v)
        {
            if (v)
            {
                cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbClass.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            else
            {
                cmbType.DropDownStyle = ComboBoxStyle.Simple;
                cmbClass.DropDownStyle = ComboBoxStyle.Simple;
                cmbStudent.DropDownStyle = ComboBoxStyle.Simple;
            }
            
        }
        public void clearDataBindings()
        {
            cmbStudent.DataBindings.Clear();
            cmbType.DataBindings.Clear();
            cmbClass.DataBindings.Clear();
            txtNr.DataBindings.Clear();
            dateTimePicker1.DataBindings.Clear();
            txtCurrentClass.DataBindings.Clear();
        }

    }
}
