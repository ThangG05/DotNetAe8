using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using System.Runtime.InteropServices.WindowsRuntime;
using Motobike.Mathang;
using System.Runtime.InteropServices;

namespace Motobike.Hoadon
{
    public partial class Hoadonnhap : Form
    {
        public Hoadonnhap()
        {
            InitializeComponent();
            
        }
        private void Hoadonnhap_Load(object sender, EventArgs e)
        {
            NapManv();
            NapMaNCC();
            NapMaHang();
            NapMaHD();
            int maend = Getma();
            txtmahd.Text=(maend+1).ToString();
            txttongtien.Enabled=false;
            txtthanhtien.Enabled=false;
            txtngaynhap.Text = DateTime.Now.ToString();
            txtngaynhap.Enabled=false;



        }
        public void NapManv()
        {
            SqlCommand cmd = null;
            CONECT.FillData fillData = new CONECT.FillData();
            cmd = fillData.FillManv(cmd);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbnmanv.Items.Add(reader["MaNV"].ToString());
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
                cbnmancc.Items.Add(reader["MaNCC"].ToString());
            }
            reader.Close();
        }
        public void NapMaHang()
        {
            SqlCommand cmd = null;
            CONECT.FillData fillData = new CONECT.FillData();
            cmd = fillData.FillMaHang(cmd);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbnmahang.Items.Add(reader["MaHang"].ToString());
            }
            reader.Close();
        }
        public void NapMaHD()
        {
            SqlCommand cmd = null;
            CONECT.FillData fillData = new CONECT.FillData();
            cmd = fillData.FillMaHD(cmd);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbnmahd.Items.Add(reader["SoHDN"].ToString());
            }
            reader.Close();
        }
        private int Getma()
        {
            int maend = 0;
            SqlCommand cmd = null;
            CONECT.FillData fillData = new CONECT.FillData();
            cmd = fillData.Macuoi(cmd);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (!reader.IsDBNull(0))
                {
                    int value;
                    if (int.TryParse(reader[0].ToString(), out value))
                    {
                        maend += value;
                    }
                    else
                    {
                       
                        maend += 0;
                    }
                }
            }
            reader.Close();
            return maend;
        }
        private void cbnmancc_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            CONECT.KetNoiXE ketNoi = new CONECT.KetNoiXE();
            conn = ketNoi.CON();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"select TenNCC,DiaChi,DienThoai from NhaCungCap
                              where MaNCC='" + cbnmancc.Text + "'";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txttenncc.Text=reader.GetString(0);
                txtdiachi.Text=reader.GetString(1);
                txtdt.Text=reader.GetString(2);
            }
            reader.Close();
        }

        private void cbnmanv_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            CONECT.KetNoiXE ketNoi = new CONECT.KetNoiXE();
            conn = ketNoi.CON();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"select TenNV from NhanVien
                             where MaNV='" + cbnmanv.Text + "'";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txttennhanvien.Text=reader.GetString(0);
            }
            reader.Close();
        }

        private void cbnmahang_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            CONECT.KetNoiXE ketNoi = new CONECT.KetNoiXE();
            conn = ketNoi.CON();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"select TenHang,DonGiaNhap from DMHang
                               where MaHang='" + cbnmahang.Text + "'";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txttenhang.Text=reader.GetString(0);
                //int gia=reader.GetInt32(1);
                //txtdongianhap.Text = gia.ToString("N0", new CultureInfo("vi-VN"));
                txtdongianhap.Text=reader.GetInt32(1).ToString();

            }
            reader.Close();
        }
        private void cbngiamgia_SelectedIndexChanged(object sender, EventArgs e)
        {
            int giam = int.Parse(cbngiamgia.Text);
            int thanhtien = int.Parse(txtthanhtien.Text);
            if (giam == 0)
            {
                txttongtien.Text = thanhtien.ToString();
            }
            else
            {
                double tongtien = thanhtien - (thanhtien * (giam / 100.0));
                txttongtien.Text = tongtien.ToString();
            }
        }
       
        private void btnInhoadon_Click(object sender, EventArgs e)
        {
            bool ktra = true;
            ktra = ERR();
            if (ktra)
            {
                Inhoadonnhap inhoadonnhap = new Inhoadonnhap();
                inhoadonnhap.GenerateInvoice(txtmahd.Text, txtngaynhap.Text, cbnmanv.Text, txttennhanvien.Text, cbnmahang.Text,
                    txttenhang.Text, cbnmancc.Text, txttenncc.Text, txtdiachi.Text, txtdt.Text, int.Parse(txtsolg.Text), int.Parse(cbngiamgia.Text), int.Parse(txtdongianhap.Text), int.Parse(txtthanhtien.Text), int.Parse(txttongtien.Text));
            }

        }

        private void txtsolg_Leave(object sender, EventArgs e)
        {
            if(cbnmahang.SelectedIndex == -1)
            {
                MessageBox.Show("Phải chọn mã hàng trước","Lỗi",MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtsolg.Text ="";
                return;
            }
            int gia = int.Parse(txtdongianhap.Text);
            int slg = int.Parse(txtsolg.Text);
            txtthanhtien.Text = (gia * slg).ToString();
            txttongtien.Text = txtthanhtien.Text;
        }
        private void clear()
        {
            txttenncc.Text = "";
            txttennhanvien.Text = "";
            txtngaynhap.Text = "";
            txtmahd.Text = "";
            txttenncc.Text = "";
            txtsolg.Text = "";
            txttenhang.Text = "";
            txtthanhtien.Text = "";
            txttongtien.Text = "";
            txtdiachi.Text = "";
            txtdt.Text = "";
            txtdongianhap.Text = "";
            cbngiamgia.SelectedIndex = -1;
            cbnmahang.SelectedIndex = -1;
            cbnmahd.SelectedIndex = -1;
            cbnmanv.SelectedIndex = -1;
            
        }
        private bool ERR()
        {
            errorProvider1.Clear();
            if (txtmahd.Text == "") { errorProvider1.SetError(txtmahd, "Không được bỏ trống mã hóa đơn"); return false; }
            if (txtngaynhap.Text == "") { errorProvider1.SetError(txtngaynhap, "Không được bỏ trống ngày nhập"); return false; }
            if (cbnmanv.SelectedIndex == -1) { errorProvider1.SetError(cbnmanv, "Không được bỏ trống mã nhân viên"); return false; }
            if (txttennhanvien.Text == "") { errorProvider1.SetError(txttennhanvien, "Không được bỏ trống tên nhân viên"); return false; }
            if (cbnmancc.SelectedIndex == -1) { errorProvider1.SetError(cbnmancc, "Không được bỏ trống mã nhà cung cấp"); return false; }
            if (txttenncc.Text == "") { errorProvider1.SetError(txttenncc, "Không được bỏ trống tên nhà cung cấp"); return false; }
            if (txtdiachi.Text == "") { errorProvider1.SetError(txtdiachi, "Không được bỏ trống địa chỉ"); return false; }
            if (txtdt.Text == "") { errorProvider1.SetError(txtdt, "Không được bỏ trống điện thoại"); return false; }
            if (cbnmahang.SelectedIndex == -1) { errorProvider1.SetError(cbnmahang, "Không được bỏ trống mã hàng"); return false; }
            if (cbngiamgia.SelectedIndex == -1) { errorProvider1.SetError(cbngiamgia, "Không được bỏ trống giảm giá"); return false; }
            if (txttenhang.Text == "") { errorProvider1.SetError(txttenhang, "Không được bỏ trống tên hàng"); return false; }
            if (txtdongianhap.Text == "") { errorProvider1.SetError(txtdongianhap, "Không được bỏ trống đơn giá nhập"); return false; }
            if (txtsolg.Text == "") { errorProvider1.SetError(txtsolg, "Không được bỏ trống số lượng"); return false; }
            if (txtthanhtien.Text == "") { errorProvider1.SetError(txtthanhtien, "Không được bỏ trống thành tiền"); return false; }
            if (txttongtien.Text == "") { errorProvider1.SetError(txttongtien, "Không được bỏ trống tổng tiền"); return false; }

            return true;
        }
        private void btnluu_Click(object sender, EventArgs e)
        {
            bool ktra = true;
            ktra = ERR();
            if (ktra)
            {
                SqlConnection conn = null;
                CONECT.KetNoiXE ketNoi = new CONECT.KetNoiXE();
                conn = ketNoi.CON();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"INSERT INTO HoaDonNhap_New(MaNV, NgayNhap, MaNCC, TongTien)
                              VALUES (
                              '" + cbnmanv.Text +
                                  "','" + txtngaynhap.Text + "'" +
                                  ",'" + cbnmancc.Text +
                                  "'," + int.Parse(txttongtien.Text) + ");";
                cmd.Connection = conn;
                int x = cmd.ExecuteNonQuery();
                SqlCommand cmd1 = new SqlCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = @"INSERT INTO CTHoaDonNhap (SoHDN,MaHang, SoLuong, DonGia, GiamGia, ThanhTien)
                              VALUES  ('" + int.Parse(txtmahd.Text) +
                                  "','" + cbnmahang.Text +
                                  "'," + int.Parse(txtsolg.Text) +
                                  "," + int.Parse(txtdongianhap.Text) +
                                  "," + int.Parse(cbngiamgia.Text) +
                                  "," + int.Parse(txtthanhtien.Text) + ");";
                cmd1.Connection = conn;
                int y = cmd1.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "UPDATE DMHang " +
                        "SET SoLuong = SoLuong + @soluong, " +
                        "DonGiaBan = DonGiaNhap * 1.1 " +
                        "WHERE MaHang = @mahang";

                cmd2.Parameters.AddWithValue("@soluong", int.Parse(txtsolg.Text));
                cmd2.Parameters.AddWithValue("@mahang", cbnmahang.Text);
                cmd2.Connection = conn;
                int z = cmd2.ExecuteNonQuery();
                if (x > 0 && y > 0 && z > 0)
                {
                    MessageBox.Show("Lưu Hóa Đơn Thành Công");
                    cbnmahd.Items.Clear();
                    NapMaHD();
                }
            }
               
        }
        public void hienthi()
        {
            SqlConnection conn = null;
            CONECT.KetNoiXE ketNoi = new CONECT.KetNoiXE();
            conn = ketNoi.CON();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"select MaHang,SoLuong,DonGia,GiamGia,ThanhTien from CTHoaDonNhap
                             where SoHDN='" + cbnmahd.Text + "'";
            cmd.Connection = conn;
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            List<HoadonnhapCT> ds= new List<HoadonnhapCT>();
            HoadonnhapCT hd;
            while (sqlDataReader.Read())
            {
                string mah=sqlDataReader.GetString(0);
                string slg=sqlDataReader.GetInt32(1).ToString();
                string dongia=sqlDataReader.GetInt32(2).ToString();
                string giamgia=sqlDataReader.GetInt32(3).ToString();
                string thanhtien=sqlDataReader.GetInt32(4).ToString();
                hd = new HoadonnhapCT() {SoHDN=cbnmahd.Text,MaHang=mah,SoLuong=slg,DonGia=dongia,GiamGia=giamgia,ThanhTien = thanhtien };
                ds.Add(hd);
            }
            datanhapxe.DataSource = ds;
            sqlDataReader.Close();
        }
        private void btntimkiem_Click(object sender, EventArgs e)
        {
            hienthi();
            datanhapxe.ClearSelection();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (datanhapxe.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = datanhapxe.SelectedRows[0];
                object value = selectedRow.Cells[0].Value;
                SqlConnection conn = null;
                CONECT.KetNoiXE ketNoi = new CONECT.KetNoiXE();
                conn = ketNoi.CON();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"delete CTHoaDonNhap
                                   where SoHDN='" + value + "'";
                cmd.Connection = conn;
                int x = cmd.ExecuteNonQuery();
                SqlCommand cmd1 = new SqlCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = @"delete HoaDonNhap_New
                                    where SoHDN='"+value+"'";
                cmd1.Connection = conn;
                int y = cmd1.ExecuteNonQuery();
                if (x > 0 && y > 0 )
                {
                    MessageBox.Show("Xóa Hóa Đơn Thành Công");
                    NapMaHD();
                }

            }
            else
            {
                MessageBox.Show("Không có đối tượng nào để xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
