using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OfficeOpenXml.ExcelErrorValue;

namespace Motobike.Timkiem
{
    public partial class timkiemhoadonban : Form
    {
        public timkiemhoadonban()
        {
            InitializeComponent();
        }

        private void timkiemhoadonban_Load(object sender, EventArgs e)
        {
            NapMaHD();
            NapMaKh();
            NapManv();
            txtthue.Enabled = false;
            txttongten.Enabled = false;
        }
        public void NapMaHD()
        {
            SqlCommand cmd = null;
            CONECT.FillData fillData = new CONECT.FillData();
            cmd = fillData.FillMaHD2(cmd);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cboshd.Items.Add(reader["SoDDH"].ToString());
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
        public void NapMaKh()
        {
            SqlCommand cmd = null;
            CONECT.FillData fillData = new CONECT.FillData();
            cmd = fillData.FillMaKH(cmd);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbomakh.Items.Add(reader["MaKH"].ToString());
            }
            reader.Close();
        }
        public void hienthiSoDDH()
        {
            SqlConnection conn = null;
            CONECT.KetNoiXE ketNoi = new CONECT.KetNoiXE();
            conn = ketNoi.CON();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"select a.SoDDH, a.MaNV, a.NgayMua, a.MaKH, 
                              b.MaHang, b.SoLuong,b.GiaBan,b.ThanhTien,a.Thue, b.GiamGia, a.TongTien
                              from DonDatHang a
                              join CTDonDatHang b on a.SoDDH = b.SoDDH
                              where a.SoDDH='"+cboshd.Text+"'";
            cmd.Connection = conn;
            List<Thongtindonban> ds= new List<Thongtindonban>();
            Thongtindonban donban;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int sohd = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                string manv = reader.IsDBNull(1) ? null : reader.GetString(1);
                DateTime ngaymua = reader.IsDBNull(2) ? DateTime.MinValue : reader.GetDateTime(2);
                string makh = reader.IsDBNull(3) ? null : reader.GetString(3);
                string mahang = reader.IsDBNull(4) ? null : reader.GetString(4);
                int soluong = reader.IsDBNull(5) ? 0 : reader.GetInt32(5);
                int giaban = reader.IsDBNull(6) ? 0 : reader.GetInt32(6);
                int thanhtien = reader.IsDBNull(7) ? 0 : reader.GetInt32(7);
                int thue = reader.IsDBNull(8) ? 0 : reader.GetInt32(8);
                int giamgia = reader.IsDBNull(9) ? 0 : reader.GetInt32(9);
                int tongtien = reader.IsDBNull(10) ? 0 : reader.GetInt32(10);


                donban = new Thongtindonban() {SoHDD=sohd,MaNV=manv,NgayMua=ngaymua,MaKH=makh,MaHang=mahang,SoLuong=soluong
                ,GiaBan=giaban,ThanhTien=thanhtien,Thue=thue,GiamGia=giamgia,TongTien=tongtien};
                ds.Add(donban);
            }
            dgvhoadon.DataSource = ds;
            reader.Close();

        }
        public void hienthijoin(string tencot,string value)
        {
            SqlConnection conn = null;
            CONECT.KetNoiXE ketNoi = new CONECT.KetNoiXE();
            conn = ketNoi.CON();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"select a.SoDDH, a.MaNV, a.NgayMua, a.MaKH, 
                                       b.MaHang, b.SoLuong,b.GiaBan,b.ThanhTien,a.Thue, b.GiamGia, a.TongTien
                                from DonDatHang a
                                join CTDonDatHang b on a.SoDDH = b.SoDDH
                                where a.SoDDH in (
                                    select SoDDH
                                    from DonDatHang
                                    where "+tencot+"='"+value+"')";
            cmd.Connection = conn;
            List<Thongtindonban> ds = new List<Thongtindonban>();
            Thongtindonban donban;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int sohd = reader.GetInt32(0);
                string manv = reader.GetString(1);
                DateTime ngaymua = reader.GetDateTime(2);
                string makh = reader.GetString(3);
                string mahang = reader.GetString(4);
                int soluong = reader.GetInt32(5);
                int giaban = reader.GetInt32(6);
                int thanhtien = reader.GetInt32(7);
                int thue = reader.GetInt32(8);
                int giamgia = reader.GetInt32(9);
                int tongtien = reader.GetInt32(10);

                donban = new Thongtindonban()
                {
                    SoHDD = sohd,
                    MaNV = manv,
                    NgayMua = ngaymua,
                    MaKH = makh,
                    MaHang = mahang,
                    SoLuong = soluong,
                    GiaBan = giaban,
                    ThanhTien = thanhtien,
                    Thue = thue,
                    GiamGia = giamgia,
                    TongTien = tongtien
                };
                ds.Add(donban);
            }
            dgvhoadon.DataSource = ds;
            reader.Close();

        }
        public void thangnam(string tencot,string gtri, string trangthai,string nam,string thang)
        {
            SqlConnection conn = null;
            CONECT.KetNoiXE ketNoi = new CONECT.KetNoiXE();
            conn = ketNoi.CON();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"SELECT a.SoDDH, a.MaNV, a.NgayMua, a.MaKH, 
                             b.MaHang, b.SoLuong, b.GiaBan, b.ThanhTien, a.Thue, b.GiamGia, a.TongTien
                      FROM DonDatHang a
                      JOIN CTDonDatHang b ON a.SoDDH = b.SoDDH
                      WHERE a.SoDDH IN (
                          SELECT SoDDH
                          FROM DonDatHang
                          WHERE " + tencot + " = '" + gtri + "' " + trangthai +
                          " (YEAR(NgayMua) = '" + nam + "' AND MONTH(NgayMua) = '" + thang + "'))";



            cmd.Connection = conn;
            List<Thongtindonban> ds = new List<Thongtindonban>();
            Thongtindonban donban;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int sohd = reader.GetInt32(0);
                string manv = reader.GetString(1);
                DateTime ngaymua = reader.GetDateTime(2);
                string makh = reader.GetString(3);
                string mahang = reader.GetString(4);
                int soluong = reader.GetInt32(5);
                int giaban = reader.GetInt32(6);
                int thanhtien = reader.GetInt32(7);
                int thue = reader.GetInt32(8);
                int giamgia = reader.GetInt32(9);
                int tongtien = reader.GetInt32(10);

                donban = new Thongtindonban()
                {
                    SoHDD = sohd,
                    MaNV = manv,
                    NgayMua = ngaymua,
                    MaKH = makh,
                    MaHang = mahang,
                    SoLuong = soluong,
                    GiaBan = giaban,
                    ThanhTien = thanhtien,
                    Thue = thue,
                    GiamGia = giamgia,
                    TongTien = tongtien
                };
                ds.Add(donban);
            }
            dgvhoadon.DataSource = ds;
            reader.Close();
        }
        private void btntimlai_Click(object sender, EventArgs e)
        {
            cboshd.SelectedIndex = -1;
            cbomakh.SelectedIndex = -1;
            cbomanv.SelectedIndex = -1;
            cbothang.SelectedIndex = -1;
            cbonam.SelectedIndex = -1;
            txttongten.Text = "";
            txtthue.Text = "";
            cbomakh.Enabled = true;
            cboshd.Enabled = true;
            cbomanv.Enabled = true;
            cbonam.Enabled = true;
            cbothang.Enabled = true;
            dgvhoadon.DataSource = null;
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            if (cboshd.Text != "")
            {
                hienthiSoDDH();
                return;
            }
            if (cbomanv.Text != "")
            {
                if (cbonam.Text != "" && cbothang.Text != "")
                {
                    thangnam("MaNV",cbomanv.Text,"AND",cbonam.Text,cbothang.Text);
                    return;
                }
                else if((cbonam.Text == "" && cbothang.Text != "")||(cbonam.Text != "" && cbothang.Text == "")){
                    MessageBox.Show("Hãy nhập đủ thông tin ngày và tháng","Cảnh báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    cbonam.Focus();
                    return;
                }
                else
                {
                    thangnam("MaNV",cbomanv.Text, "OR", "", "");
                    return;
                }
            }
            if (cbomakh.Text != "")
            {
                if (cbonam.Text != "" && cbothang.Text != "")
                {
                    thangnam("MaKH", cbomakh.Text, "AND", cbonam.Text, cbothang.Text);
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
                    thangnam("MaKH", cbomakh.Text, "OR", "", "");
                    return;
                }
            }
            if(cbonam.Text !="" && cbothang.Text != "")
            {
                thangnam("MaNV", "", "OR", cbonam.Text, cbothang.Text);
                return;
            }
            if (cbonam.Text != "")
            {
                hienthijoin("YEAR(NgayMua)",cbonam.Text);
                return;
            }
            if (cbothang.Text != "")
            {
                hienthijoin("MONTH(NgayMua)",cbothang.Text);
            }
           
        }

        private void cboshd_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbomakh.Enabled = false;
            cbomanv.Enabled = false;
            cbonam.Enabled = false;
            cbothang.Enabled = false;
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


        private void dgvhoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvhoadon.Rows[e.RowIndex];
                string mahd = selectedRow.Cells[0].Value?.ToString();
                string  manv = selectedRow.Cells[1].Value?.ToString();
                string ngaymua = selectedRow.Cells[2].Value?.ToString();
                string makh = selectedRow.Cells[3].Value?.ToString();
                string thue=selectedRow.Cells[8].Value?.ToString();
                string tongtien=selectedRow.Cells[10].Value?.ToString();
                cboshd.Text = mahd;
                cbomanv.Text = manv;
                string month = layThang(ngaymua);
                cbothang.Text = month;
                string year = layNam(ngaymua);
                cbonam.Text = year;
                cbomakh.Text = makh;
                txtthue.Text = thue;
                txttongten.Text = tongtien;

            }
        }

        private void cbomanv_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbomakh.Enabled = false;
            cboshd.Enabled = false;
        }

        private void cbomakh_SelectedIndexChanged(object sender, EventArgs e)
        {
           cbomanv.Enabled = false;
           cboshd.Enabled = false;
        }

        private void cbothang_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbomanv.Enabled = true;
            cboshd.Enabled = false;
            cbomakh.Enabled = true;
        }

        private void cbonam_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbomanv.Enabled = true;
            cboshd.Enabled = false;
            cbomakh.Enabled = true;
        }
    }
}
