using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace NimapInfotechMachineTest.SqlDbConnection
{
    public class Connection
    {
        SqlCommand cmd;
        SqlDataAdapter sqlda;
        SqlConnection con = null;
        public static string constr = @"Data Source=DESKTOP-U4379CM; Initial Catalog=Db_Nimap; User Id=sa;Password=Game@123";

        public SqlConnection Connect()
        {
            try
            {

                con = new SqlConnection(constr);
                con.Close();
                if (con.State == ConnectionState.Open)
                    con.Close();
                    con.Open();
            }
            catch (Exception ex)
            {

            }

            return con;
        }
        public DataTable FillCombo(string query)
        {
            DataTable dt = new DataTable();

            con = Connect();
            cmd = new SqlCommand();
            cmd.Connection = con;
            sqlda = new SqlDataAdapter(query,con);
            sqlda.Fill(dt);


            return dt;
        }
    }
}