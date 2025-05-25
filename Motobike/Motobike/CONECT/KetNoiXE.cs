using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motobike.CONECT
{
    internal class KetNoiXE
    {
        public SqlConnection con = null;
        public string connectionString = ConfigurationManager.ConnectionStrings["SQLT"].ConnectionString;
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
