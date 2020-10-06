using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab11
{
    public partial class Logare : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            { 
                GridView1.Visible = false; 
                Label1.Visible = false; 
            }
        }
        protected void CV1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand(); 
            OleDbDataReader rdr;

            con.ConnectionString = DS1.ConnectionString; 
            cmd.Connection = con;
            cmd.CommandText = "Select IdUtilizator, Parola from Utilizatori Where Nume='" + txtUser.Text + "'";
            con.Open(); 
            rdr = cmd.ExecuteReader(); 
            if (!rdr.Read()) { 
                CV1.ErrorMessage = "Utilizator eronat"; 
                args.IsValid = false; 
                con.Close();
                return;
            } 
            else if (rdr.GetString(1) != txtPassword.Text)
            {
                CV1.ErrorMessage = "Parola eronata"; 
                args.IsValid = false; 
                con.Close();
                return;
            }
            con.Close();
            Panel1.Visible = false;
            GridView1.Visible = true;
            Label1.Visible = true;
        }
    }
}