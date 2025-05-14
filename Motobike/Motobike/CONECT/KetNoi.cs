using System;
using System.Data.SqlClient;
using System.Configuration;  
namespace Motobike.CONECT
{
    public class KetNoi
    {
        public SqlConnection con = null;
        public string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public SqlConnection CON()
        {
            if (con == null)
            {
                con = new SqlConnection(connectionString);
            }
            if (con != null && con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void Dong()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
