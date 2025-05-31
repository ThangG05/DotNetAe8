using Microsoft.ReportingServices.Diagnostics.Internal;
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
using System.Globalization;
using Motobike.Mathang;

namespace Motobike.Hoadon
{
    public partial class Hoadonban : Form
    {
        public Hoadonban()
        {
            InitializeComponent();
        }
        BindingList<HoadonbanCT> ds = new BindingList<HoadonbanCT>();
        private void Hoadonban_Load(object sender, EventArgs e)
        {
            NapMaKh();
            NapManv();
            NapMaHang();
            NapMaHD();
            int maend = Getma();
            txtmahd.Text = (maend+1).ToString();
            txtthanhtien.Enabled = false;
            txtngaymua.Text = DateTime.Now.ToString();
            txtngaymua.Enabled = false;
            databanxe.DataSource = ds;
            btnquaythuong.Enabled = true;

        }
        public void NapMaKh()
        {
            SqlCommand cmd = null;
            CONECT.FillData fillData = new CONECT.FillData();
            cmd = fillData.FillMaKH(cmd);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbnmakhach.Items.Add(reader["MaKH"].ToString());
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
                cbnmanv.Items.Add(reader["MaNV"].ToString());
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
            cmd = fillData.FillMaHD2(cmd);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbnmahd.Items.Add(reader["SoDDH"].ToString());
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
                txttennv.Text = reader.GetString(0);
            }
            reader.Close();
        }

        private void cbnmakhach_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            CONECT.KetNoiXE ketNoi = new CONECT.KetNoiXE();
            conn = ketNoi.CON();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"select TenKH,DiaChi,DienThoai from KhachHang
                              where MaKH='" + cbnmakhach.Text + "'";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) { 
                txttenkhach.Text = reader.GetString(0);
                txtdchi.Text = reader.GetString(1);
                txtdienthoai.Text = reader.GetString(2);
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
            cmd.CommandText = @"select TenHang,DonGiaBan from DMHang
                               where MaHang='" + cbnmahang.Text + "'";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txttenhang.Text = reader.GetString(0);
                txtgiatien.Text = reader.GetInt32(1).ToString();

            }
            reader.Close();
        }

        private void txtsolg_Leave(object sender, EventArgs e)
        {
            if (cbnmahang.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy nhập mã hàng trước","Lỗi",MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtsolg.Text = "";
                return;
            }
            int gia = int.Parse(txtgiatien.Text);
            int slg = int.Parse(txtsolg.Text);
            txtthanhtien.Text = (gia * slg).ToString();
        }
        int sum = 0;
        private void cbngiamgia_Leave(object sender, EventArgs e)
        {
            if (txtthanhtien.Text=="")
            {
                MessageBox.Show("Chưa có thành tiền", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbngiamgia.SelectedIndex = -1 ;
                return;
            }
            int thanhtien = int.Parse(txtthanhtien.Text);
            if (cbngiamgia.Text == "")
            {
                txttongtien.Text = thanhtien.ToString();
                sum = thanhtien;
            }
            else
            {
                int giam = int.Parse(cbngiamgia.Text);
                double tongtien = thanhtien - (thanhtien * (giam / 100.0));
                txttongtien.Text = tongtien.ToString();
                sum = (int)tongtien;
            }
        }
        private void txtthue_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txttongtien.Text == "")
            {
                MessageBox.Show("Chưa có tổng tiền", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtthue.SelectedIndex = -1;
                return;
            }
            int thanhtien = int.Parse(txttongtien.Text);
            if (txtthue.Text == "")
            {
                txttongtien.Text = thanhtien.ToString();
                sum= thanhtien;
            }
            else
            {
                int vat = int.Parse(txtthue.Text);
                double tongtien = thanhtien + (thanhtien * (vat / 100.0));
                sum = (int)tongtien;
                txttongtien.Text = tongtien.ToString();
            }
           
        }
       
        private int Getma()
        {
            int maend = 0;
            SqlCommand cmd = null;
            CONECT.FillData fillData = new CONECT.FillData();
            cmd = fillData.Macuoi2(cmd);
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
        private void btnin_Click(object sender, EventArgs e)
        {
            if (databanxe.Rows.Count == 0 || databanxe.Rows.Cast<DataGridViewRow>().All(r => r.IsNewRow))
            {
                MessageBox.Show("Không có dữ liệu để in");
                return;
            }
            if (btnquaythuong.Enabled)
            {
                MessageBox.Show("Hãy quay thưởng trước khi in");
                return;
            }
            List<HoadonbanCT> ds = new List<HoadonbanCT>();
            foreach (DataGridViewRow row in databanxe.Rows)
            {
                if (row.IsNewRow) continue;

                var item = new HoadonbanCT
                {
                    SoDDH = row.Cells["SoDDH"].Value?.ToString(),
                    NgayMua = row.Cells["NgayMua"].Value?.ToString(),
                    MaNV = row.Cells["MaNV"].Value?.ToString(),
                    TenNV = row.Cells["TenNV"].Value?.ToString(),
                    MaKH = row.Cells["MaKH"].Value?.ToString(),
                    TenKH = row.Cells["TenKH"].Value?.ToString(),
                    Diachi = row.Cells["Diachi"].Value?.ToString(),
                    SDT = row.Cells["SDT"].Value?.ToString(),
                    MaHang = row.Cells["MaHang"].Value?.ToString(),
                    TenHang = row.Cells["TenHang"].Value?.ToString(),
                    SoLuong = row.Cells["SoLuong"].Value?.ToString(),
                    GiaBan = row.Cells["GiaBan"].Value?.ToString(),
                    GiamGia = row.Cells["GiamGia"].Value?.ToString(),
                    Thue = row.Cells["Thue"].Value?.ToString(),
                    ThanhTien = row.Cells["ThanhTien"].Value?.ToString(),
                };
                ds.Add(item);
            }
            String KetQua = VongQuayMayMan.Ketqua;
            Inhoadonban printer = new Inhoadonban();
            printer.GenerateInvoiceBan(ds,KetQua);
        }
        private void clear()
        {
            txtdchi.Text = "";
            txtdienthoai.Text = "";
            txtgiatien.Text = "";
            txtmahd.Text = "";
            txtngaymua.Text = "";
            txtsolg.Text = "";
            txttenhang.Text = "";
            txttenkhach.Text = "";
            txttennv.Text = "";
            txtthanhtien.Text = "";
            txtthue.Text = "";
            txttongtien.Text = "";
            cbngiamgia.SelectedIndex = -1;
            cbnmahang.SelectedIndex = -1;
            cbnmahd.SelectedIndex = -1;
            cbnmanv.SelectedIndex = -1;
            cbnmakhach.SelectedIndex = -1;
        }
        private bool ERR()
        {
            errorProvider1.Clear();

            if (txtmahd.Text == "") { errorProvider1.SetError(txtmahd, "Không được bỏ trống"); return false; }
            if (txtngaymua.Text == "") { errorProvider1.SetError(txtngaymua, "Không được bỏ trống"); return false; }
            if (cbnmanv.SelectedIndex == -1) { errorProvider1.SetError(cbnmanv, "Vui lòng chọn nhân viên"); return  false; }
            if (txttennv.Text == "") { errorProvider1.SetError(txttennv, "Không được bỏ trống"); return false; }
            if (cbnmahang.SelectedIndex == -1) { errorProvider1.SetError(cbnmahang, "Vui lòng chọn mặt hàng"); return false; }
            if (txttenhang.Text == "") { errorProvider1.SetError(txttenhang, "Không được bỏ trống"); return false; }
            if (txtsolg.Text == "") { errorProvider1.SetError(txtsolg, "Không được bỏ trống"); return  false; }
            if (cbngiamgia.SelectedIndex == -1) { errorProvider1.SetError(cbngiamgia, "Vui lòng chọn giảm giá"); return false; }
            if (txtgiatien.Text == "") { errorProvider1.SetError(txtgiatien, "Không được bỏ trống"); return false; }
            if (txtthanhtien.Text == "") { errorProvider1.SetError(txtthanhtien, "Không được bỏ trống"); return false; }
            if (txttongtien.Text == "") { errorProvider1.SetError(txttongtien, "Không được bỏ trống"); return false; }
            if (txtthue.Text == "") { errorProvider1.SetError(txtthue, "Không được bỏ trống"); return false; }

            return true;
        }
        private void btnluu_Click(object sender, EventArgs e)
        {
            if (databanxe.Rows.Count == 0 || databanxe.Rows.Cast<DataGridViewRow>().All(r => r.IsNewRow))
            {
                MessageBox.Show("Không có dữ liệu để lưu");
                return;
            }
            else {
                SqlConnection conn = null;
                CONECT.KetNoiXE ketNoi = new CONECT.KetNoiXE();
                conn = ketNoi.CON();
                DateTime ngayMua = DateTime.ParseExact(txtngaymua.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                // Tạo SqlCommand và dùng tham số
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                int tongThanhTien = 0;
                int thue = 0;
                foreach (DataGridViewRow row in databanxe.Rows)
                {
                    if (row.IsNewRow) continue;

                    object thanhTienValue = row.Cells["ThanhTien"].Value;

                    if (thanhTienValue != null && int.TryParse(thanhTienValue.ToString(), out int thanhTien))
                    {
                        tongThanhTien += thanhTien;
                    }
                    object thueValue = row.Cells["Thue"].Value;

                    if (thueValue != null && int.TryParse(thueValue.ToString(), out int tienthue))
                    {
                        thue += tienthue;
                    }
                }
                cmd.CommandText = @"INSERT INTO DonDatHang (MaNV, NgayMua, MaKH, Thue, TongTien)
                    VALUES (@manv, @ngaymua, @makh, @thue, @tongtien)";
                cmd.Connection = conn;

                cmd.Parameters.AddWithValue("@manv", cbnmanv.Text);
                cmd.Parameters.AddWithValue("@ngaymua", ngayMua);
                cmd.Parameters.AddWithValue("@makh", cbnmakhach.Text);
                cmd.Parameters.AddWithValue("@thue", thue);
                cmd.Parameters.AddWithValue("@tongtien", tongThanhTien);
                int x = cmd.ExecuteNonQuery();
                foreach (DataGridViewRow row in databanxe.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string maHang = row.Cells["MaHang"].Value?.ToString();
                        int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);
                        int giaBan = Convert.ToInt32(row.Cells["GiaBan"].Value);
                        int giamGia = Convert.ToInt32(row.Cells["GiamGia"].Value);
                        int thanhTien = Convert.ToInt32(row.Cells["ThanhTien"].Value);

                        SqlCommand cmd1 = new SqlCommand();
                        cmd1.CommandType = CommandType.Text;
                        cmd1.CommandText = @"INSERT INTO CTDonDatHang (SoDDH, MaHang, SoLuong, GiaBan, GiamGia, ThanhTien)
                VALUES 
                ('" + int.Parse(txtmahd.Text) +
                                "','" + maHang +
                                "'," + soLuong +
                                "," + giaBan +
                                "," + giamGia +
                                "," + thanhTien + ");";
                        cmd1.Connection = conn;
                        int y = cmd1.ExecuteNonQuery();

                        SqlCommand cmd2 = new SqlCommand();
                        cmd2.CommandType = CommandType.Text;
                        cmd2.CommandText = "UPDATE DMHang " +
                            "SET SoLuong = SoLuong - @soluong " +
                            "WHERE MaHang = @mahang";
                        cmd2.Parameters.AddWithValue("@soluong", soLuong);
                        cmd2.Parameters.AddWithValue("@mahang", maHang);
                        cmd2.Connection = conn;
                        int z = cmd2.ExecuteNonQuery();
                    }
                }

                if (x > 0)
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
            cmd.CommandText = @"select MaHang,SoLuong,GiaBan,GiamGia,ThanhTien from CTDonDatHang
                              where SoDDH='"+cbnmahd.Text+"'";

            cmd.Connection = conn;
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            List<Hienthihoadonbann> ds = new List<Hienthihoadonbann>();
            Hienthihoadonbann hd;
            while (sqlDataReader.Read())
            {
                string mah = sqlDataReader.GetString(0);
                string slg = sqlDataReader.GetInt32(1).ToString();
                string dongia = sqlDataReader.GetInt32(2).ToString();
                string giamgia = sqlDataReader.GetInt32(3).ToString();
                string thanhtien = sqlDataReader.GetInt32(4).ToString();
                hd = new Hienthihoadonbann() { SoDDH = cbnmahd.Text, MaHang = mah, SoLuong = slg, GiaBan = dongia, Giamgia = giamgia, ThanhTien = thanhtien };
                ds.Add(hd);
            }
            databanxe.DataSource = ds;
            sqlDataReader.Close();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            hienthi();
            databanxe.ClearSelection();
            btnhuy.Enabled = false;
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            btnhuy.Enabled = true;
            cbnmahang.SelectedIndex = -1;
            txttenhang.Text = "";
            txtsolg.Text = "";
            cbngiamgia.SelectedIndex = -1;
            txtgiatien.Text = "";
            txtthanhtien.Text = "";
            txttongtien.Text = "";
            cbnmakhach.SelectedIndex = -1;
            txtdchi.Text = "";
            txtdienthoai.Text = "";
            cbnmanv.SelectedIndex = -1;
            txttennv.Text = "";
            txttenkhach.Text = "";
            txtthue.SelectedIndex = -1;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            bool check = true;
            check = ERR();
            if (check == false)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin bắt buộc.");
                return;
            }
            try
            {
                HoadonbanCT hd = new HoadonbanCT();
                hd = new HoadonbanCT()
                {
                    SoDDH = txtmahd.Text,
                    NgayMua = txtngaymua.Text,
                    MaNV = cbnmanv.Text,
                    TenNV = txttennv.Text,
                    MaKH = cbnmakhach.Text,
                    TenKH = txttenkhach.Text,
                    Diachi = txtdchi.Text,
                    SDT = txtdienthoai.Text,
                    MaHang = cbnmahang.Text,
                    TenHang = txttenhang.Text,
                    SoLuong = txtsolg.Text,
                    GiaBan = txtgiatien.Text,
                    GiamGia = cbngiamgia.Text,
                    Thue = txtthue.Text,
                    ThanhTien = sum.ToString()
                };
                ds.Add(hd);
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số.");
            }
            cbnmahang.SelectedIndex = -1;
            txttenhang.Text = "";
            txtsolg.Text = "";
            cbngiamgia.SelectedIndex = -1;
            txtgiatien.Text = "";
            txtthanhtien.Text = "";
            txtthue.SelectedIndex = -1;
            txttongtien.Text = "";
            cbnmanv.Enabled = false;
            txttennv.Enabled = false;
            cbnmakhach.Enabled = false;
            txttenkhach.Enabled = false;
            txtdchi.Enabled = false;
            txtdienthoai.Enabled = false;
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            if (databanxe.Rows.Count == 0)
            {
                MessageBox.Show("Bảng hiện không có dữ liệu để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

    
            if (databanxe.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng đã chọn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in databanxe.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        databanxe.Rows.Remove(row);
                    }
                }
            }
        }

        private void btnquaythuong_Click(object sender, EventArgs e)
        {
            VongQuayMayMan v = new VongQuayMayMan();
            v.Show();
            btnquaythuong.Enabled = false;
        }
    }
}
