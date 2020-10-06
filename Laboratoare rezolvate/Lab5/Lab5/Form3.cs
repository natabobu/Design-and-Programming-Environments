using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Lab5
{
    public partial class Form3 : Form
    {
        private static OleDbConnection con = new OleDbConnection();
        private static OleDbCommand cmd = new OleDbCommand();

        public Form3()
        {
            InitializeComponent();
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.BalantaStoc' table. You can move, or remove it, as needed.
            //this.balantaStocTableAdapter.Fill(this.dataSet1.BalantaStoc);
            // TODO: This line of code loads data into the 'dataSet1.CalculStoc' table. You can move, or remove it, as needed.
            //this.calculStocTableAdapter.Fill(this.dataSet1.CalculStoc);
            con.ConnectionString = balantaStocTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;

            con.Open();

            //Sterg continut tabela BalantaStoc
            cmd.CommandText = "Delete * from BalantaStoc";
            cmd.ExecuteNonQuery();
            con.Close();
            //Calcul stoc
            Calcule.calculStoc(balantaStocTableAdapter.Connection.ConnectionString);
            calculStocTableAdapter.Fill(dataSet1.CalculStoc);

        }

        private void btnStocFinal_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd.CommandText = "INSERT INTO BalantaStoc ( IdRF, StocFinal )" +
                            " SELECT IdRF, Cantitate FROM CalculStoc Where IdOperatie=6";
            cmd.ExecuteNonQuery();
            con.Close();
            //Afisez balanta
            balantaStocTableAdapter.Fill(dataSet1.BalantaStoc);
        }

        private void btnStocInitial_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd.CommandText = "UPDATE BalantaStoc LEFT JOIN StocInitial ON BalantaStoc.IdRF = StocInitial.IdRF " +
                              "SET BalantaStoc.StocInitial = StocInitial.Cantitate";
            cmd.ExecuteNonQuery();
            con.Close();
            //Afisez balanta
            balantaStocTableAdapter.Fill(dataSet1.BalantaStoc);

        }

        private void btnIntrari_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.IntrariTableAdapter ta = new DataSet1TableAdapters.IntrariTableAdapter();
            ta.Fill(dataSet1.Intrari);

            DataRelation balIntrari = dataSet1.Relations.Add(dataSet1.BalantaStoc.Columns["IdRF"], dataSet1.Intrari.Columns["IdRF"]);

            foreach (DataRow rb in dataSet1.BalantaStoc)
            {
                foreach (DataRow ri in rb.GetChildRows(balIntrari))
                {
                    rb["Intrari"] = ri["Total"];
                }
            }

        }

        private void btnIesiri_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.IesiriTableAdapter ta = new DataSet1TableAdapters.IesiriTableAdapter();
            ta.Fill(dataSet1.Iesiri);

            DataRelation balIesiri = dataSet1.Relations.Add(dataSet1.BalantaStoc.Columns["IdRF"], dataSet1.Iesiri.Columns["IdRF"]);

            foreach (DataRow rb in dataSet1.BalantaStoc)
            {
                foreach (DataRow ri in rb.GetChildRows(balIesiri))
                {
                    rb["Iesiri"] = ri["Total"];
                }
            }

        }
    }
}
