using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Motobike.Mathang
{
    public partial class Honda : Form
    {
        public Honda()
        {
            InitializeComponent();
        }
        private void Thongtinxe(string link)
        {
            SqlConnection conn = null;
            CONECT.KetNoiXE ketNoi = new CONECT.KetNoiXE();
            conn = ketNoi.CON();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"SELECT 
                                h.TenHang,
                                tl.TenLoai AS TheLoai,
                                nsx.TenNuocSX AS NuocSanXuat,
                                hsx.TenHangSX AS HangSanXuat,
                                p.TenPhanh AS PhanhXe,
                                ms.TenMau AS MauSac,
                                dc.TenDongCo AS DongCo,
                                tt.TenTinhTrang AS TinhTrang,
                                h.ThoiGianBaoHanh
                            FROM 
                                DMHang h
                            LEFT JOIN TheLoai tl ON h.MaLoai = tl.MaLoai
                            LEFT JOIN NuocSX nsx ON h.MaNuocSX = nsx.MaNuocSX
                            LEFT JOIN HangSX hsx ON h.MaHangSX = hsx.MaHangSX
                            LEFT JOIN PhanhXe p ON h.MaPhanh = p.MaPhanh
                            LEFT JOIN MauSac ms ON h.MaMau = ms.MaMau
                            LEFT JOIN DongCo dc ON h.MaDongCo = dc.MaDongCo
                            LEFT JOIN TinhTrang tt ON h.MaTinhTrang = tt.MaTinhTrang
                            WHERE h.Anh = '" + link + "'";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txttenhang.Text = reader.GetString(0);
                txttheloai.Text = reader.GetString(1);
                txtnuocsx.Text = reader.GetString(2);
                txthangsx.Text = reader.GetString(3);
                txtphanhxe.Text = reader.GetString(4);
                txtmausac.Text = reader.GetString(5);
                txtdc.Text = reader.GetString(6);
                txttt.Text = reader.GetString(7);
                txtbaoh.Text = reader.GetString(8);
            }
            reader.Close();
        }
        private void picyamaha1_Click(object sender, EventArgs e)
        {
            string link = @"D:\FINAL_PROJECT\.Net\DotNet\HangHoa\yahamaexciter.png";
            Thongtinxe(link);
        }

        private void picyamaha2_Click(object sender, EventArgs e)
        {
            string link = @"D:\FINAL_PROJECT\.Net\DotNet\HangHoa\yamahafreego.png";
            Thongtinxe(link);
        }

        private void picyamaha3_Click(object sender, EventArgs e)
        {
            string link = @"D:\FINAL_PROJECT\.Net\DotNet\HangHoa\yamahajanus.png";
            Thongtinxe(link);
        }

        private void picyamaha4_Click(object sender, EventArgs e)
        {
            string link = @"D:\FINAL_PROJECT\.Net\DotNet\HangHoa\yamahanvx.png";
            Thongtinxe(link);
        }
    }
}
