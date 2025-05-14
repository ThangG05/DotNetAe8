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

namespace Motobike.Timkiem
{
    public partial class timkiemhoadonnhap : Form
    {
        public timkiemhoadonnhap()
        {
            InitializeComponent();
        }
        private void timkiemhoadonnhap_Load_1(object sender, EventArgs e)
        {
            NapMaHD();
            NapManv();
            NapMaNCC();
            cbothang.DropDownStyle = ComboBoxStyle.DropDown; 
            cbonam.DropDownStyle = ComboBoxStyle.DropDown;
            txttongtien.Enabled=false;
        }
        public void NapMaHD()
        {
            SqlCommand cmd = null;
            CONECT.FillData fillData = new CONECT.FillData();
            cmd = fillData.FillMaHD(cmd);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbomahd.Items.Add(reader["SoHDN"].ToString());
            }
            reader.Close();
        }
        public void NapMaNCC()
        {
            SqlCommand cmd = null;
            CONECT.FillData fillData = new CONECT.FillData();
            cmd = fillData.FillMaNCC(cmd);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbomancc.Items.Add(reader["MaNCC"].ToString());
            }
            reader.Close();
        }
        public void NapManv()
        {
            SqlCommand cmd = null;
            CONECT.FillData fillData = new CONECT.FillData();
            cmd = fillData.FillManv(cmd);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbomanv.Items.Add(reader["MaNV"].ToString());
            }
            reader.Close();
        }
        public void hienthiSoHDN()
        {
            SqlConnection conn = null;
            CONECT.KetNoiXE ketNoi = new CONECT.KetNoiXE();
            conn = ketNoi.CON();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"SELECT 
                                a.SoHDN,
                                a.MaNV, 
                                a.NgayNhap, 
                                a.MaNCC, 
                                b.MaHang, 
                                b.SoLuong, 
                                b.DonGia, 
                                b.ThanhTien, 
                                b.GiamGia,
	                            a.TongTien
                            FROM HoaDonNhap_New a 
                            JOIN CTHoaDonNhap b ON a.SoHDN = b.SoHDN
                            where a.SoHDN ='"+cbomahd.Text+"'";
            cmd.Connection = conn;
            List<Thongtindonnhap> ds = new List<Thongtindonnhap>();
            Thongtindonnhap donhap;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int sohd = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                string manv = reader.IsDBNull(1) ? null : reader.GetString(1);
                DateTime ngaynhap = reader.IsDBNull(2) ? DateTime.MinValue : reader.GetDateTime(2);
                string mancc = reader.IsDBNull(3) ? null : reader.GetString(3);
                string mahang = reader.IsDBNull(4) ? null : reader.GetString(4);
                int soluong = reader.IsDBNull(5) ? 0 : reader.GetInt32(5);
                int giaban = reader.IsDBNull(6) ? 0 : reader.GetInt32(6);
                int thanhtien = reader.IsDBNull(7) ? 0 : reader.GetInt32(7);
                int giamgia = reader.IsDBNull(8) ? 0 : reader.GetInt32(8);
                int tongtien = reader.IsDBNull(9) ? 0 : reader.GetInt32(9);


                donhap = new Thongtindonnhap()
                {
                    SoHDN = sohd,
                    MaNV = manv,
                    NgayNhap = ngaynhap,
                    MaNCC = mancc,
                    MaHang = mahang,
                    SoLuong = soluong
                ,
                    DonGia = giaban,
                    ThanhTien = thanhtien,
                    GiamGia = giamgia,
                    TongTien = tongtien
                };
                ds.Add(donhap);
            }
            dgvhoadonnhap.DataSource = ds;
            reader.Close();

        }
        public void hienthijoin(string tencot, string value)
        {
            SqlConnection conn = null;
            CONECT.KetNoiXE ketNoi = new CONECT.KetNoiXE();
            conn = ketNoi.CON();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"SELECT 
                                a.SoHDN,
                                a.MaNV, 
                                a.NgayNhap, 
                                a.MaNCC, 
                                b.MaHang, 
                                b.SoLuong, 
                                b.DonGia, 
                                b.ThanhTien, 
                                b.GiamGia,
	                            a.TongTien
                            FROM HoaDonNhap_New a 
                            JOIN CTHoaDonNhap b ON a.SoHDN = b.SoHDN
                            where "+tencot+"='"+value+"'";
            cmd.Connection = conn;
            List<Thongtindonnhap> ds = new List<Thongtindonnhap>();
            Thongtindonnhap donhap;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int sohd = reader.GetInt32(0);
                string manv = reader.GetString(1);
                DateTime ngaynhap = reader.GetDateTime(2);
                string mancc = reader.GetString(3);
                string mahang = reader.GetString(4);
                int soluong = reader.GetInt32(5);
                int giaban = reader.GetInt32(6);
                int thanhtien = reader.GetInt32(7);
                int giamgia = reader.GetInt32(8);
                int tongtien = reader.GetInt32(9);

                donhap = new Thongtindonnhap()
                {
                    SoHDN = sohd,
                    MaNV = manv,
                    NgayNhap = ngaynhap,
                    MaNCC = mancc,
                    MaHang = mahang,
                    SoLuong = soluong
                ,
                    DonGia = giaban,
                    ThanhTien = thanhtien,
                    GiamGia = giamgia,
                    TongTien = tongtien
                };
                ds.Add(donhap);
            }
            dgvhoadonnhap.DataSource = ds;
            reader.Close();

        }
        public void thangnam(string tencot, string gtri, string trangthai, string nam, string thang)
        {
            SqlConnection conn = null;
            CONECT.KetNoiXE ketNoi = new CONECT.KetNoiXE();
            conn = ketNoi.CON();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"
                            SELECT 
                                a.SoHDN,
                                a.MaNV, 
                                a.NgayNhap, 
                                a.MaNCC, 
                                b.MaHang, 
                                b.SoLuong, 
                                b.DonGia, 
                                b.ThanhTien, 
                                b.GiamGia,
                                a.TongTien
                            FROM HoaDonNhap_New a 
                            JOIN CTHoaDonNhap b ON a.SoHDN = b.SoHDN
                            WHERE " + tencot + " = '" + gtri + "' "
                             + trangthai + " (MONTH(NgayNhap) = '" + thang + "' AND YEAR(NgayNhap) = '" + nam + "')";

            cmd.Connection = conn;
            List<Thongtindonnhap> ds = new List<Thongtindonnhap>();
            Thongtindonnhap donhap;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int sohd = reader.GetInt32(0);
                string manv = reader.GetString(1);
                DateTime ngaynhap = reader.GetDateTime(2);
                string mancc = reader.GetString(3);
                string mahang = reader.GetString(4);
                int soluong = reader.GetInt32(5);
                int giaban = reader.GetInt32(6);
                int thanhtien = reader.GetInt32(7);
                int giamgia = reader.GetInt32(8);
                int tongtien = reader.GetInt32(9);

                donhap = new Thongtindonnhap()
                {
                    SoHDN = sohd,
                    MaNV = manv,
                    NgayNhap = ngaynhap,
                    MaNCC = mancc,
                    MaHang = mahang,
                    SoLuong = soluong
                ,
                    DonGia = giaban,
                    ThanhTien = thanhtien,
                    GiamGia = giamgia,
                    TongTien = tongtien
                };
                ds.Add(donhap);
            }
            dgvhoadonnhap.DataSource = ds;
            reader.Close();

        }

        private void btntimkiem_Click_1(object sender, EventArgs e)
        {
            if (cbomahd.Text != "")
            {
                hienthiSoHDN();
                return;
            }
            if (cbomanv.Text != "")
            {
                if (cbonam.Text != "" && cbothang.Text != "")
                {
                    thangnam("MaNV", cbomanv.Text, "AND", cbonam.Text, cbothang.Text);
                    return;
                }
                else if ((cbonam.Text == "" && cbothang.Text != "") || (cbonam.Text != "" && cbothang.Text == ""))
                {
                    MessageBox.Show("Hãy nhập đủ thông tin ngày và tháng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbonam.Focus();
                    return;
                }
                else
                {
                    thangnam("MaNV", cbomanv.Text, "OR", "", "");
                    return;
                }
            }
            if(cbomancc.Text != "")
            {
                if (cbonam.Text != "" && cbothang.Text != "")
                {
                    thangnam("MaNCC",cbomancc.Text, "AND", cbonam.Text, cbothang.Text);
                    return;
                }
                else if ((cbonam.Text == "" && cbothang.Text != "") || (cbonam.Text != "" && cbothang.Text == ""))
                {
                    MessageBox.Show("Hãy nhập đủ thông tin ngày và tháng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbonam.Focus();
                    return;
                }
                else
                {
                    thangnam("MaNCC", cbomancc.Text, "OR", "", "");
                    return;
                }
            }
            if (cbonam.Text != "" && cbothang.Text != "")
            {
                thangnam("MaNV", "", "OR", cbonam.Text, cbothang.Text);
                return;
            }
            if (cbonam.Text != "")
            {
                hienthijoin("YEAR(NgayNhap)", cbonam.Text);
                return;
            }
            if (cbothang.Text != "")
            {
                hienthijoin("MONTH(NgayNhap)", cbothang.Text);
            }
        }

        private void cbomahd_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbomancc.Enabled = false;
            cbomanv.Enabled = false;
            cbonam.Enabled = false;
            cbothang.Enabled = false;
            
        }

        private void btntimlai_Click(object sender, EventArgs e)
        {
            txttongtien.Text = "";
            cbothang.SelectedIndex = -1;
            cbonam.SelectedIndex = -1;
            cbomanv.SelectedIndex = -1;
            cbomancc.SelectedIndex = -1;
            cbomahd.SelectedIndex = -1;
            cbomahd.Enabled = true;
            cbomancc.Enabled = true;
            cbomanv.Enabled = true;
            cbonam.Enabled = true;
            cbothang.Enabled = true;
            cbomahd.Text = "";
            dgvhoadonnhap.DataSource = null;
        }
        private string layThang(string a)
        {
            if (DateTime.TryParse(a, out DateTime dt))
            {
                return dt.Month.ToString();
            }
            return "";
        }

        private string layNam(string a)
        {
            if (DateTime.TryParse(a, out DateTime dt))
            {
                return dt.Year.ToString();
            }
            return "";
        }

        private void dgvhoadonnhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow selectedRow = dgvhoadonnhap.Rows[e.RowIndex];
                    string mahd = selectedRow.Cells[0].Value?.ToString();
                    string manv = selectedRow.Cells[1].Value?.ToString();
                    string ngaynhap = selectedRow.Cells[2].Value?.ToString();
                    string mancc = selectedRow.Cells[3].Value?.ToString();
                    string tongtien = selectedRow.Cells[9].Value?.ToString();
                    cbomahd.Text = mahd;
                    cbomanv.Text = manv;
                    string month = layThang(ngaynhap);
                    cbothang.Text = month;
                    string year = layNam(ngaynhap);
                    cbonam.Text = year; 
                    cbomancc.Text = mancc;
                    txttongtien.Text = tongtien;
                }
        }

        private void cbomancc_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbomanv.Enabled = false;
            cbomahd.Enabled = false;
        }

        private void cbomanv_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbomancc.Enabled = false;
            cbomahd.Enabled = false;
        }

        private void cbothang_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbomahd.Enabled=false;
        }

        private void cbonam_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbomahd.Enabled = false;
        }
    }
}
