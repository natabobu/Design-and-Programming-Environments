using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace L02
{
    public partial class Form1 : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
           
            //Configurez obiectele conexiune si comanda
            con.ConnectionString = calculStocTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;

            //Sterg continut tabele CalculStoc si Stoc
            con.Open();
            cmd.CommandText = "Delete * from CalculStoc";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "Delete * from Stoc";
            cmd.ExecuteNonQuery();

            con.Close();

            this.calculStocTableAdapter.Fill(this.dataSet1.CalculStoc);
            this.stocTableAdapter.Fill(this.dataSet1.Stoc);
        }

        private void btnStocInitial_Click(object sender, EventArgs e){
            con.Open();

            //Stoc Initial
            cmd.CommandText = "Insert into CalculStoc(IdOperatie, Data, IdRF, Cantitate) " +
                              "Select 1,Data, IdRF, Cantitate " +
                              "From StocInitial";

            try { cmd.ExecuteNonQuery(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            con.Close();

            //Incarc dataTable-ul CalculStoc
            dataSet1.CalculStoc.Clear();
            calculStocTableAdapter.Fill(this.dataSet1.CalculStoc);

        }

        private void btnIntrari_Click(object sender, EventArgs e) {
            // Intrari
            con.Open();

            cmd.CommandText = "Insert into CalculStoc(IdOperatie, Data, IdRF, Cantitate) " +
                              "Select 2,DataInc as Data, IdRF, Cantitate " +
                              "From Incasari";
            try { cmd.ExecuteNonQuery(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            con.Close();

            //Incarc dataTable-ul CalculStoc
            dataSet1.CalculStoc.Clear();
            calculStocTableAdapter.Fill(this.dataSet1.CalculStoc);
        }

        private void btnIesiri_Click(object sender, EventArgs e) {
            //Iesiri
            con.Open();
            cmd.CommandText = "Insert into CalculStoc(IdOperatie, Data, IdRF, Cantitate) " +
                   "Select 3,DataPl as Data, IdRF, -Cantitate " +
                   "From Plati";
            try { cmd.ExecuteNonQuery(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            con.Close();

            //Incarc dataTable-ul CalculStoc
            dataSet1.CalculStoc.Clear();
            calculStocTableAdapter.Fill(this.dataSet1.CalculStoc);
        }

        private void btnStocFinal_Click(object sender, EventArgs e) {
            con.Open();

            // Calculez totaluri pe Cantitate si grupez pe IdProdus 
            // inserez rezultatul in tabela Stoc
            cmd.CommandText = "INSERT INTO Stoc ( IdRF, Cantitate ) " +
                              "SELECT  IdRF, Sum(CalculStoc.Cantitate) AS Cantitate " +
                              "FROM CalculStoc GROUP BY CalculStoc.IdRF";
            cmd.ExecuteNonQuery();

            //Stoc final 

            cmd.CommandText = "INSERT INTO CalculStoc ( IdOperatie, IdRF, Cantitate, Data ) " +
                              "SELECT  4,CalculStoc.IdRF, Sum(CalculStoc.Cantitate) AS Cantitate, now() " +
                              "FROM CalculStoc GROUP BY CalculStoc.IdRF";
            cmd.ExecuteNonQuery();

            con.Close();

            //Incarc dataTable-ul CalculStoc si Stoc
            dataSet1.CalculStoc.Clear();
            calculStocTableAdapter.Fill(this.dataSet1.CalculStoc);

            dataSet1.Stoc.Clear();
            stocTableAdapter.Fill(this.dataSet1.Stoc);
        }
    }
}
