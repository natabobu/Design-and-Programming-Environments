using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Lab5_2
{
    class Calcule
    {
        private static OleDbConnection con = new OleDbConnection();
        private static OleDbCommand cmd = new OleDbCommand();
        public static void calculStoc(string cs)
        {
            con.ConnectionString = cs;
            cmd.Connection = con;
            con.Open();
            //Sterg continut tabele CalculStoc
            cmd.CommandText = "Delete * from CalculStoc";
            cmd.ExecuteNonQuery();

            stocInitial(); intrari(); iesiri();

            stocFinal();
            con.Close();
        }
        private static void stocInitial()
        {
            cmd.CommandText = "Insert into CalculStoc(IdOperatie, Data, IdMaterial, Cantitate) " +
                              "Select 1,Data, IdMaterial, Cantitate " +
                              "From StocInitial";

            try { cmd.ExecuteNonQuery(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private static void intrari()
        {
            cmd.CommandText = "Insert into CalculStoc(IdOperatie, Data, IdMaterial, Cantitate) " +
                              "Select 2,DataInc as DataF, IdMaterial, Cantitate " +
                              "From (Facturi LEFT OUTER JOIN FacturiContinut ON Facturi.IdF=FacturiContinut.IdF)";
            try { cmd.ExecuteNonQuery(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private static void iesiri()
        {
            cmd.CommandText = "Insert into CalculStoc(IdOperatie, Data, IdMaterial, Cantitate) " +
                   "Select 3,DataBonConsum as Data, IdMaterial, -Cantitate " +
                   "From (BonuriConsum LEFT OUTER JOIN BonuriConsumContinut ON BonuriConsum.IdBonConsum=BonuriConsumContinut.IdBonConsum)";
            try { cmd.ExecuteNonQuery(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private static void stocFinal()
        {

            // Calculez totaluri pe Cantitate si grupez pe IdProdus 

            cmd.CommandText = "INSERT INTO CalculStoc ( IdOperatie, IdMaterial, Cantitate, Data ) " +
                              "SELECT  4,CalculStoc.IdMaterial, Sum(CalculStoc.Cantitate) AS Cantitate, now() " +
                              "FROM CalculStoc GROUP BY CalculStoc.IdMaterial";
            cmd.ExecuteNonQuery();
        }
/*
        private static void trSursa()
        {
            cmd.CommandText = "Insert into CalculStoc(IdOperatie, Data, IdRF, Cantitate) " +
                   "Select 4,DataTr as Data, IdRFSursa, -Cantitate " +
                   "From Transferuri";
            try { cmd.ExecuteNonQuery(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private static void trDest()
        {
            cmd.CommandText = "Insert into CalculStoc(IdOperatie, Data, IdRF, Cantitate) " +
                   "Select 5,DataTr as Data, IdRFDest, Cantitate " +
                   "From Transferuri";
            try { cmd.ExecuteNonQuery(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private static void svSursa()
        {
            cmd.CommandText = "Insert into CalculStoc(IdOperatie, Data, IdRF, Cantitate) " +
                   "Select 7,DataSV as Data, IdRFSursa, -CantitateS " +
                   "From SchimburiValutare";
            try { cmd.ExecuteNonQuery(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private static void svDest()
        {
            cmd.CommandText = "Insert into CalculStoc(IdOperatie, Data, IdRF, Cantitate) " +
                   "Select 8,DataSV as Data, IdRFDest, CantitateD " +
                   "From SchimburiValutare";
            try { cmd.ExecuteNonQuery(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }*/


    }
}
