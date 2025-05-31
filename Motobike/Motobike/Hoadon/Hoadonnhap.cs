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
using System.Globalization;
using Motobike.Danhmuc;


namespace Motobike.Hoadon
{
    public partial class Hoadonnhap : Form
    {
        public Hoadonnhap()
        {
            InitializeComponent();
            
        }
        BindingList<HoadonnhapCT> ds = new BindingList<HoadonnhapCT>();
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
            datanhapxe.DataSource = ds;

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

        private void btnInhoadon_Click(object sender, EventArgs e)
        {
            if (datanhapxe.Rows.Count == 0 || datanhapxe.Rows.Cast<DataGridViewRow>().All(r => r.IsNewRow))
            {
                MessageBox.Show("Không có dữ liệu để in");
                return;
            }
            List<HoadonnhapCT> ds = new List<HoadonnhapCT>();
            foreach (DataGridViewRow row in datanhapxe.Rows)
            {
                if (row.IsNewRow) continue;

                var item = new HoadonnhapCT
                {
                    SoHDN = row.Cells["SoHDN"].Value?.ToString(),
                    NgayNhap = row.Cells["NgayNhap"].Value?.ToString(),
                    MaNV = row.Cells["MaNV"].Value?.ToString(),
                    TenNV = row.Cells["TenNV"].Value?.ToString(),
                    MaNCC = row.Cells["MaNCC"].Value?.ToString(),
                    TenNCC = row.Cells["TenNCC"].Value?.ToString(),
                    Diachi = row.Cells["Diachi"].Value?.ToString(),
                    DienThoai = row.Cells["DienThoai"].Value?.ToString(),
                    MaHang = row.Cells["MaHang"].Value?.ToString(),
                    TenHang = row.Cells["TenHang"].Value?.ToString(),
                    SoLuong = row.Cells["SoLuong"].Value?.ToString(),
                    DonGia = row.Cells["DonGia"].Value?.ToString(),
                    GiamGia = row.Cells["GiamGia"].Value?.ToString(),
                    TongTien = row.Cells["TongTien"].Value?.ToString()
                };

                ds.Add(item);
            }

            Inhoadonnhap printer = new Inhoadonnhap();
            printer.GenerateInvoice(ds);
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
            if (datanhapxe.Rows.Count == 0 || datanhapxe.Rows.Cast<DataGridViewRow>().All(r => r.IsNewRow))
            {
                MessageBox.Show("Không có dữ liệu để lưu");
                return;
            }
            else 
            {
                SqlConnection conn = null;
                CONECT.KetNoiXE ketNoi = new CONECT.KetNoiXE();
                conn = ketNoi.CON();
                DateTime ngayNhap = DateTime.ParseExact(txtngaynhap.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                int tongThanhTien = 0;
                foreach (DataGridViewRow row in datanhapxe.Rows)
                {
                    if (row.IsNewRow) continue;

                    object thanhTienValue = row.Cells["TongTien"].Value;

                    if (thanhTienValue != null && int.TryParse(thanhTienValue.ToString(), out int thanhTien))
                    {
                        tongThanhTien += thanhTien;
                    }
                }
                cmd.CommandText = @"INSERT INTO HoaDonNhap_New(MaNV, NgayNhap, MaNCC, TongTien)
                    VALUES (@manv, @ngaynhap, @mancc, @tongtien)";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@manv", cbnmanv.Text);
                cmd.Parameters.AddWithValue("@ngaynhap", ngayNhap); 
                cmd.Parameters.AddWithValue("@mancc", cbnmancc.Text);
                cmd.Parameters.AddWithValue("@tongtien", tongThanhTien);
                int x = cmd.ExecuteNonQuery();
                int y = 0;
                foreach (DataGridViewRow row in datanhapxe.Rows)
                {
                    if (!row.IsNewRow)
                    {

                        string maHang = row.Cells["MaHang"].Value?.ToString();
                        int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);
                        int donGiaNhap = Convert.ToInt32(row.Cells["DonGia"].Value);
                        int giamGia = Convert.ToInt32(row.Cells["GiamGia"].Value);
                        int thanhTien = Convert.ToInt32(row.Cells["TongTien"].Value);

                        double donGiaBan = donGiaNhap * 1.1;

 
                        SqlCommand insertCmd = new SqlCommand(@"
            INSERT INTO CTHoaDonNhap (SoHDN, MaHang, SoLuong, DonGia, GiamGia, ThanhTien)
            VALUES (@SoHDN, @MaHang, @SoLuong, @DonGia, @GiamGia, @ThanhTien)", conn);

                        insertCmd.Parameters.AddWithValue("@SoHDN", txtmahd.Text);
                        insertCmd.Parameters.AddWithValue("@MaHang", maHang);
                        insertCmd.Parameters.AddWithValue("@SoLuong", soLuong);
                        insertCmd.Parameters.AddWithValue("@DonGia", donGiaNhap);
                        insertCmd.Parameters.AddWithValue("@GiamGia", giamGia);
                        insertCmd.Parameters.AddWithValue("@ThanhTien", thanhTien);

                        insertCmd.ExecuteNonQuery();


                        SqlCommand updateCmd = new SqlCommand(@"
            UPDATE DMHang
            SET SoLuong = SoLuong + @SoLuong,
                DonGiaNhap = @DonGiaNhap,
                DonGiaBan = @DonGiaBan
            WHERE MaHang = @MaHang", conn);

                        updateCmd.Parameters.AddWithValue("@SoLuong", soLuong);
                        updateCmd.Parameters.AddWithValue("@DonGiaNhap", donGiaNhap);
                        updateCmd.Parameters.AddWithValue("@DonGiaBan", (int)donGiaBan);
                        updateCmd.Parameters.AddWithValue("@MaHang", maHang);

                        updateCmd.ExecuteNonQuery();
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
            cmd.CommandText = @"select MaHang,SoLuong,DonGia,GiamGia,ThanhTien from CTHoaDonNhap
                             where SoHDN='" + cbnmahd.Text + "'";
            cmd.Connection = conn;
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            List<Hienthihoadonban> ds= new List<Hienthihoadonban>();
            Hienthihoadonban hd;
            while (sqlDataReader.Read())
            {
                string mah=sqlDataReader.GetString(0);
                string slg=sqlDataReader.GetInt32(1).ToString();
                string dongia=sqlDataReader.GetInt32(2).ToString();
                string giamgia=sqlDataReader.GetInt32(3).ToString();
                string thanhtien=sqlDataReader.GetInt32(4).ToString();
                hd = new Hienthihoadonban() {SoHDN=cbnmahd.Text,MaHang=mah,SoLuong=slg,DonGia=dongia,GiamGia=giamgia,TongTien = thanhtien };
                ds.Add(hd);
            }
            datanhapxe.DataSource = ds;
            sqlDataReader.Close();
        }
        private void btntimkiem_Click(object sender, EventArgs e)
        {
            hienthi();
            datanhapxe.ClearSelection();
            btnxoa.Enabled = false;
        }
        int sum = 0;
        private void cbngiamgia_SelectedIndexChanged(object sender, EventArgs e)
        {
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
        private void btnthem_Click(object sender, EventArgs e)
        {
            bool check = true;
            check = ERR();
            if (check==false)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin bắt buộc.");
                return;
            }
            try
            {
                HoadonnhapCT hd = new HoadonnhapCT();
                hd = new HoadonnhapCT() { SoHDN = txtmahd.Text,NgayNhap=txtngaynhap.Text,MaNV=cbnmanv.Text,TenNV=txttennhanvien.Text,MaNCC=cbnmancc.Text
                    ,TenNCC=txttenncc.Text,Diachi=txtdiachi.Text,DienThoai=txtdt.Text, MaHang =cbnmahang.Text ,TenHang=txttenhang.Text,SoLuong = txtsolg.Text, DonGia = txtdongianhap.Text, GiamGia = cbngiamgia.Text, TongTien = sum.ToString() };
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
            txtdongianhap.Text = "";
            txtthanhtien.Text = "";
            txttongtien.Text = "";
            cbnmanv.Enabled = false;
            txttennhanvien.Enabled = false;
            cbnmancc.Enabled = false;
            txttenncc.Enabled = false;
            txtdiachi.Enabled = false;
            txtdt.Enabled = false;
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            btnxoa.Enabled = true;
            cbnmahang.SelectedIndex = -1;
            txttenhang.Text = "";
            txtsolg.Text = "";
            cbngiamgia.SelectedIndex = -1;
            txtdongianhap.Text = "";
            txtthanhtien.Text = "";
            txttongtien.Text = "";
            cbnmancc.SelectedIndex = -1;
            txtdiachi.Text = "";
            txtdt.Text = "";
            cbnmanv.SelectedIndex = -1;
            txttennhanvien.Text = "";
            txttenncc.Text = "";
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (datanhapxe.Rows.Count == 0)
            {
                MessageBox.Show("Bảng hiện không có dữ liệu để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (datanhapxe.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng đã chọn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in datanhapxe.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        datanhapxe.Rows.Remove(row);
                    }
                }
            }
        }

       
    }
}
