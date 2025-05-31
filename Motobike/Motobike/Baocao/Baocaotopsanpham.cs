using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Motobike.ACC;

namespace Motobike.Baocao
{
    public partial class Baocaotopsanpham : Form
    {
        public Baocaotopsanpham()
        {
            InitializeComponent();
        }
        private int Kinhte(string tenbang, string tencot, DateTime batdau, DateTime ketthuc)
        {
            SqlConnection conn = null;
            CONECT.KetNoiXE ketNoi = new CONECT.KetNoiXE();
            conn = ketNoi.CON();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $@"SELECT 
                            SUM(TongTien) AS [Tổng Tiền]
                         FROM {tenbang}
                         WHERE {tencot} BETWEEN @batdau AND @ketthuc";

            cmd.Parameters.AddWithValue("@batdau", batdau);
            cmd.Parameters.AddWithValue("@ketthuc", ketthuc);
            cmd.Connection = conn;

            SqlDataReader rdr = cmd.ExecuteReader();
            int tien = 0;
            while (rdr.Read())
            {
                tien = rdr.IsDBNull(0) ? 0 : rdr.GetInt32(0);
            }
            rdr.Close();
            return tien;
        }

        private void btntinhtoan_Click(object sender, EventArgs e)
        {
            DateTime batdau = dtpbatdau.Value;
            DateTime ketthuc = dtpketthuc.Value;

            int thu = Kinhte("DonDatHang", "NgayMua", batdau, ketthuc);
            txtdoanhthu.Text = thu.ToString();

            int chi = Kinhte("HoaDonNhap_New", "NgayNhap", batdau, ketthuc);
            txtdautu.Text = chi.ToString();

            int loinhuan = thu - chi;
            txtloinhuan.Text = loinhuan.ToString();
        }


        private void Baocaotopsanpham_Load(object sender, EventArgs e)
        {
            lblname.Text = Dangnhap.TenDangNhap;
        }

        private void btnin_Click(object sender, EventArgs e)
        {
            inhoatdongkinhdaonh inkinhdoanh = new inhoatdongkinhdaonh();
            inkinhdoanh.Inbaocaohoatdong(dtpbatdau.Text, dtpketthuc.Text,int.Parse(txtdoanhthu.Text),int.Parse(txtdautu.Text),int.Parse(txtloinhuan.Text));

        }
    }
}
