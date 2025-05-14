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

namespace Motobike.Danhmuc
{
    public partial class Danhmucnhanvien : Form
    {
        public Danhmucnhanvien()
        {
            InitializeComponent();
        }
        private void hienthi()
        {
            SqlConnection conn = null;
            CONECT.KetNoiXE ketNoi = new CONECT.KetNoiXE();
            conn = ketNoi.CON();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"select a.MaNV,a.TenNV,a.GioiTinh,a.NgaySinh,a.DiaChi,b.TenCV,a.SoDienThoai from NhanVien a
                              join CongViec b on a.MaCV=b.MaCV";
            cmd.Connection = conn;
            List<NhanVien> ds = new List<NhanVien>();
            NhanVien nhanVien;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string manv = reader.GetString(0);
                string tennv = reader.GetString(1);
                string gioitinh=reader.GetString(2);
                DateTime ngaysinh=reader.GetDateTime(3);
                string diachi=reader.GetString(4);
                string congviec=reader.GetString(5);
                string sdt=reader.GetString(6);
                nhanVien = new NhanVien() { MaNV=manv, TenNV = tennv,GioiTinh=gioitinh,NgaySinh=ngaysinh,DiaChi=diachi,ChucVu=congviec,SDT=sdt};
                ds.Add(nhanVien);
            }
            dgvnhanvien.DataSource = ds;
            reader.Close();

        }
        private void Danhmucnhanvien_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        private void dgvnhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvnhanvien.Rows[e.RowIndex];
                string code = selectedRow.Cells[0].Value?.ToString();
                string name = selectedRow.Cells[1].Value?.ToString();
                string gioitinh=selectedRow.Cells[2].Value?.ToString();
                string ngaysinh=selectedRow.Cells[3].Value?.ToString();
                string diachi = selectedRow.Cells[4].Value?.ToString();
                string congviec=selectedRow.Cells[5].Value?.ToString();
                string sdt=selectedRow.Cells[6].Value?.ToString();
                txtma.Text = code;
                txtten.Text = name;
                txtdate.Text = ngaysinh;
                txtdiachi.Text = diachi;
                cbogioitinh.Text = gioitinh;
                txtsdt.Text = sdt;
                cbochucvu.Text = congviec;
               
            }
            txtma.Enabled = false;
        }
        private void clear()
        {
            txtma.Text = "";
            txtten.Text = "";
            txtdiachi.Text = "";
            txtdate.Text = "";
            cbochucvu.Text = "";
            txtsdt.Text = "";
            cbogioitinh.SelectedIndex = -1;
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            clear();
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            btnboqua.Enabled = true;
            txtma.Enabled = true;
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            clear();
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            txtma.Enabled = false;
        }
        public bool ERR()
        {

            if (txtma.Text == "")
            {
                errorProvider1.SetError(txtma, "Yêu cầu nhập thông tin");
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin");
                return false;
            }
            if (txtten.Text == "")
            {
                errorProvider1.SetError(txtten, "Yêu cầu nhập thông tin");
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin");
                return false;
            }
            if (cbochucvu.Text == "")
            {
                errorProvider1.SetError(cbochucvu, "Yêu cầu nhập thông tin");
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin");
                return false;
            }

            if (txtdiachi.Text == "")
            {
                errorProvider1.SetError(txtdiachi, "Yêu cầu nhập thông tin");
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin");
                return false;
            }

            if (txtdate.Text == "")
            {
                errorProvider1.SetError(txtdate, "Yêu cầu nhập thông tin");
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin");
                return false;
            }

            if (txtdiachi.Text == "")
            {
                errorProvider1.SetError(txtdiachi, "Yêu cầu nhập thông tin");
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin");
                return false;
            }

            if (cbogioitinh.Text == "")
            {
                errorProvider1.SetError(cbogioitinh, "Yêu cầu nhập thông tin");
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin");
                return false;
            }
            return true;
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            ERR();
            bool check = ERR();
            if (check==false)
            {
                return;
            }
            string macv = TimMaCV(cbochucvu.Text.Trim());
            SqlConnection conn = null;
            CONECT.KetNoiXE ketNoi = new CONECT.KetNoiXE();
            conn = ketNoi.CON();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"update NhanVien
                                set TenNV=N'"+txtten.Text+"',GioiTinh='"+cbogioitinh.Text+"',NgaySinh='"+txtdate.Text+
                                "',DiaChi='"+txtdiachi.Text+"',MaCV='"+macv+"', SoDienThoai='"+txtsdt.Text+"'  where MaNV='"+txtma.Text+"'";
            cmd.Connection = conn;
            int x = cmd.ExecuteNonQuery();
            if (x > 0)
            {
                MessageBox.Show("Sửa thành công");
                hienthi();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txtma.Text == "")
            {
                errorProvider1.SetError(txtma, "Không có thông tin để xóa");
                MessageBox.Show("Không có thông tin để xóa");
                return;
            }
            DialogResult res= MessageBox.Show("Bạn có chắn muốn xóa","Hỏi",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                SqlConnection conn = null;
                CONECT.KetNoiXE ketNoi = new CONECT.KetNoiXE();
                conn = ketNoi.CON();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"delete NhanVien
                                Where MaNV='" + txtma.Text + "'";
                cmd.Connection = conn;
                int x = cmd.ExecuteNonQuery();
                if (x > 0)
                {
                    MessageBox.Show("Xóa thành công");
                    hienthi();
                    clear();
                }
            }
            
        }
        private string TimMaCV(string a)
        {
            string macv ="";
            SqlConnection conn = null;
            CONECT.KetNoiXE ketNoi = new CONECT.KetNoiXE();
            conn = ketNoi.CON();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = @"select MaCV from CongViec
                              where TenCV=N'"+a+"'";
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                macv = reader.GetString(0);
            }
            reader.Close();
            return macv;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool ktra = false;
            CONECT.Check check = new CONECT.Check();
            ktra = check.checkprimary(txtma.Text, "MaNV", dgvnhanvien);
            if (ktra)
            {
                MessageBox.Show("Lỗi trùng mã Nhân viên");
                txtma.Text = "";
                return;
            }
            ERR();
            bool err = ERR();
            if (err == false)
            {
                return;
            }
            string macv=TimMaCV(cbochucvu.Text.Trim());
            SqlConnection conn = null;
            CONECT.KetNoiXE ketNoi = new CONECT.KetNoiXE();
            conn = ketNoi.CON();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"insert into NhanVien values('"+txtma.Text+"',N'"+txtten.Text+"','"+cbogioitinh.Text+
                "','"+txtdate.Text+"',N'"+txtdiachi.Text+"',N'"+macv+"','"+txtsdt.Text+"')";
            cmd.Connection = conn;
            int x = cmd.ExecuteNonQuery();
            if (x > 0)
            {
                MessageBox.Show("Lưu thành công");
                hienthi();
            }
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
        }

       

        
    }
}
