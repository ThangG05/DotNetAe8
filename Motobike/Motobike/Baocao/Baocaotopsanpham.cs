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

namespace Motobike.Baocao
{
    public partial class Baocaotopsanpham : Form
    {
        public Baocaotopsanpham()
        {
            InitializeComponent();
        }
        private int Kinhte(string tenbang,string tencot ,string batdau,string ketthuc)
        {
            SqlConnection conn = null;
            CONECT.KetNoiXE ketNoi = new CONECT.KetNoiXE();
            conn = ketNoi.CON();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"SELECT 
                                SUM(TongTien) AS 'Tổng Tiền'
                            FROM "+tenbang+
                            " WHERE "+tencot+" BETWEEN '"+batdau+"' AND '"+ketthuc+"';";
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
           
            string input = txtbatdau.Text;
            string input2 = txtketthuc.Text;
            DateTime ngayChon;
            DateTime ngayChon2;
            string batdau = "";
            string ketthuc = "";
            if (DateTime.TryParseExact(input, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngayChon))
            {
                batdau = ngayChon.ToString("yyyy-MM-dd");
            }
            else
            {
                MessageBox.Show("Ngày không hợp lệ. Vui lòng nhập đúng định dạng dd/MM/yyyy.");
            }
            if (DateTime.TryParseExact(input2, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngayChon2))
            {
                ketthuc = ngayChon2.ToString("yyyy-MM-dd");
            }
            else
            {
                MessageBox.Show("Ngày không hợp lệ. Vui lòng nhập đúng định dạng dd/MM/yyyy.");
            }

            int thu = Kinhte("DonDatHang", "NgayMua", batdau, ketthuc);
            txtdoanhthu.Text=thu.ToString();
            int chi = Kinhte("HoaDonNhap_New", "NgayNhap",txtbatdau.Text, txtketthuc.Text);
            txtdautu.Text=chi.ToString();
            int loinhuan = thu - chi;
            txtloinhuan.Text=loinhuan.ToString();
        }

        private void Baocaotopsanpham_Load(object sender, EventArgs e)
        {

        }

        private void btnin_Click(object sender, EventArgs e)
        {
            inhoatdongkinhdaonh inkinhdoanh = new inhoatdongkinhdaonh();
            inkinhdoanh.Inbaocaohoatdong(txtbatdau.Text, txtketthuc.Text,int.Parse(txtdoanhthu.Text),int.Parse(txtdautu.Text),int.Parse(txtloinhuan.Text));

        }
    }
}
