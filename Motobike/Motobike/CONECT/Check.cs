using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Motobike.CONECT
{
    internal class Check
    {
        public bool checkprimary(string a, string tencot, DataGridView tenbang)
        {
            foreach (DataGridViewRow row in tenbang.Rows)
            {
                if (row.Cells[tencot].Value != null &&
                    row.Cells[tencot].Value.ToString().IndexOf(a, StringComparison.OrdinalIgnoreCase) >= 0)
                {

                    return true;
                }
            }
            return false;
        }
        public bool checkkhoa(string a,string tencot, string tenbang)
        {
            SqlConnection conn = null;
            CONECT.KetNoiXE ketNoi = new CONECT.KetNoiXE();
            conn = ketNoi.CON();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType=System.Data.CommandType.Text;
            cmd.CommandText = @"select " + tencot + " from " + tenbang+";";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            string ma="";
            while (reader.Read())
            {
                ma=reader.GetString(0);
                if (ma == a)
                {
                    return true;
                }
            }
            reader.Close();
            return false ;
        }
    }
}
