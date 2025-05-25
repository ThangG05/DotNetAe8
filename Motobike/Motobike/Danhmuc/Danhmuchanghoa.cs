using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Motobike.Danhmuc
{
    public partial class Danhmuchanghoa : Form
    {
        public Danhmuchanghoa()
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
            cmd.CommandText = @"select *from DMHang";
            cmd.Connection = conn;
            List<Hanghoa> ds = new List<Hanghoa>();
            Hanghoa hanghoa;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string mahang= reader.GetString(0);
                string tenhang = reader.GetString(1);
                string maloai= reader.GetString(2);
                string mansx= reader.GetString(3);
                string mahsx= reader.GetString(4);
                string maphanh= reader.GetString(5);
                string mamau= reader.GetString(6);
                string madc= reader.GetString(7);
                string mattrang= reader.GetString(8);
                string dungtichkhoang= reader.GetString(9);
                string anh= reader.GetString(10);
                int slg= reader.GetInt32(11);
                int dongianhap= reader.GetInt32(12);
                int dongiaban= reader.GetInt32(13);
                string thoigianbaohanh= reader.GetString(14);
                hanghoa = new Hanghoa() {MaHang = mahang, TenHang = tenhang,MaLoai=maloai,MaNuocSX=mansx,MaHangSX=mahsx,MaPhanh=maphanh,
                MaMau=mamau,MaDongCo=madc,MaTinhTrang=mattrang,DungTichKhoang=dungtichkhoang,Anh=anh,SoLuong=slg,DonGiaNhap=dongianhap,DonGiaBan=dongiaban,ThoiGianBaoHanh=thoigianbaohanh};
                ds.Add(hanghoa);
            }
            dvghanghoa.DataSource = ds;
            reader.Close();

        }
        private void Danhmuchanghoa_Load(object sender, EventArgs e)
        {
            hienthi();
            NapMaDongCo();
            NapMaLoai();
            NapMaMau();
            NapMaNuocXS();
            NapMaPhanh();
            NapMaTinhTrang();
            NapHangXe();
        }
        public void NapMaMau()
        {
            SqlCommand cmd = null;
            CONECT.FillData fillData = new CONECT.FillData();
            cmd = fillData.FillMamau(cmd);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbomamau.Items.Add(reader["MaMau"].ToString());
            }
            reader.Close();
        }
        public void NapMaPhanh()
        {
            SqlCommand cmd = null;
            CONECT.FillData fillData = new CONECT.FillData();
            cmd = fillData.FillMaPhanh(cmd);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbomaphanh.Items.Add(reader["MaPhanh"].ToString());
            }
            reader.Close();
        }
        public void NapMaLoai()
        {
            SqlCommand cmd = null;
            CONECT.FillData fillData = new CONECT.FillData();
            cmd = fillData.FillMaLoai(cmd);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbomaloai.Items.Add(reader["MaLoai"].ToString());
            }
            reader.Close();
        }
        public void NapMaDongCo()
        {
            SqlCommand cmd = null;
            CONECT.FillData fillData = new CONECT.FillData();
            cmd = fillData.FillMaDongCo(cmd);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbomadongco.Items.Add(reader["MaDongCo"].ToString());
            }
            reader.Close();

        }
        public void NapHangXe()
        {
            SqlCommand cmd = null;
            CONECT.FillData fillData = new CONECT.FillData();
            cmd = fillData.FillMaHangXe(cmd);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbomahsx.Items.Add(reader["MaHangSX"].ToString());
            }
            reader.Close();
        }
        public void NapMaNuocXS()
        {
            SqlCommand cmd = null;
            CONECT.FillData fillData = new CONECT.FillData();
            cmd = fillData.FillMaNuocSx(cmd);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbomansx.Items.Add(reader["MaNuocSX"].ToString());
            }
            reader.Close();
        }
        public void NapMaTinhTrang()
        {
            SqlCommand cmd = null;
            CONECT.FillData fillData = new CONECT.FillData();
            cmd = fillData.FillMaTinhTrang(cmd);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbotinhtrang.Items.Add(reader["MaTinhTrang"].ToString());
            }
            reader.Close();
        }

        private void dvghanghoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dvghanghoa.Rows[e.RowIndex];
                string mahang = selectedRow.Cells[0].Value?.ToString();
                string tenhang = selectedRow.Cells[1].Value?.ToString();
                string maloai = selectedRow.Cells[2].Value?.ToString();
                string mansx = selectedRow.Cells[3].Value?.ToString();
                string mahsx = selectedRow.Cells[4].Value?.ToString();
                string maphanh = selectedRow.Cells[5].Value?.ToString();
                string mamau = selectedRow.Cells[6].Value?.ToString();
                string madc = selectedRow.Cells[7].Value?.ToString();
                string matinhtrang = selectedRow.Cells[8].Value?.ToString();
                string dungtich= selectedRow.Cells[9].Value?.ToString();
                string anh = selectedRow.Cells[10].Value?.ToString();
                string soluong = selectedRow.Cells[11].Value?.ToString();
                string gianhap = selectedRow.Cells[12].Value?.ToString();
                string giaban = selectedRow.Cells[13].Value?.ToString();
                string baohanh = selectedRow.Cells[14].Value?.ToString();
                txtmahang.Text= mahang;
                txttenhang.Text= tenhang;
                cbomaloai.Text= maloai;
                cbomansx.Text= mansx;
                cbomahsx.Text= mahsx;
                cbomaphanh.Text= maphanh;
                cbomamau.Text= mamau;
                cbomadongco.Text = madc;
                cbotinhtrang.Text= matinhtrang;
                txtdungtich.Text= dungtich;
                txtanh.Text= anh;
                txtsoluong.Text= soluong;
                txtgianhap.Text= gianhap;
                txtgiaban.Text= giaban;
                txtbaohanh.Text= baohanh;
            }
            txtmahang.Enabled= false;
            string duongdan = txtanh.Text.Trim();

            if (File.Exists(duongdan))
            {
                if (picanh.Image != null)
                {
                    picanh.Image.Dispose();
                    picanh.Image = null;
                }

                using (var fs = new FileStream(duongdan, FileMode.Open, FileAccess.Read))
                {
                    picanh.Image = Image.FromStream(fs);
                }
            }
            else
            {
                picanh.Image = null;
                MessageBox.Show("Không tìm thấy ảnh!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void clear()
        {
            txtbaohanh.Text = "";
            txtanh.Text = "";
            txtgiaban.Text = "";
            txtdungtich.Text = "";
            txtgianhap.Text = "";
            txtmahang.Text = "";
            txtsoluong.Text = "";
            txttenhang.Text = "";
            cbomadongco.Text = "";
            cbomahsx.Text = "";
            cbomaloai.Text = "";
            cbomamau.Text = "";
            cbomansx.Text = "";
            cbomaphanh.Text = "";
            cbotinhtrang.Text = "";
            picanh.Image = null;
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            clear();
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnboqua.Enabled = true;
            txtmahang.Enabled = true;
           
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            clear();
            btnxoa.Enabled=true;
            btnsua.Enabled=true;
            txtmahang.Enabled = false;
           
        }
        private void ERR()
        {
            
            if (txtbaohanh.Text == "")
            {
                errorProvider1.SetError(txtbaohanh, "Yêu cầu nhập thông tin");
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin");
                return;
            }
            if (txtanh.Text == "")
            {
                errorProvider1.SetError(txtanh, "Yêu cầu nhập thông tin");
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin");
                return;
            }
            if (txtdungtich.Text == "")
            {
                errorProvider1.SetError(txtdungtich, "Yêu cầu nhập thông tin");
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin");
                return;
            }
            if (txtgiaban.Text == "")
            {
                errorProvider1.SetError(txtgiaban, "Yêu cầu nhập thông tin");
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin");
                return;
            }
            if (txtgianhap.Text == "")
            {
                errorProvider1.SetError(txtgianhap, "Yêu cầu nhập thông tin");
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin");
                return;
            }
            if (txtmahang.Text == "")
            {
                errorProvider1.SetError(txtmahang, "Yêu cầu nhập thông tin");
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin");
                return;
            }
            if (txtsoluong.Text == "")
            {
                errorProvider1.SetError(txtsoluong, "Yêu cầu nhập thông tin");
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin");
                return;
            }
            if (txttenhang.Text == "")
            {
                errorProvider1.SetError(txttenhang, "Yêu cầu nhập thông tin");
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin");
                return;
            }
            if (cbomadongco.Text == "")
            {
                errorProvider1.SetError(cbomadongco, "Yêu cầu nhập thông tin");
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin");
                return;
            }
            if (cbomahsx.Text == "")
            {
                errorProvider1.SetError(cbomahsx, "Yêu cầu nhập thông tin");
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin");
                return;
            }
            if (cbomaloai.Text == "")
            {
                errorProvider1.SetError(cbomaloai, "Yêu cầu nhập thông tin");
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin");
                return;
            }
            if (cbomamau.Text == "")
            {
                errorProvider1.SetError(cbomamau, "Yêu cầu nhập thông tin");
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin");
                return;
            }
            if (cbomansx.Text == "")
            {
                errorProvider1.SetError(cbomansx, "Yêu cầu nhập thông tin");
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin");
                return;
            }
            if (cbomaphanh.Text == "")
            {
                errorProvider1.SetError(cbomaphanh, "Yêu cầu nhập thông tin");
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin");
                return;
            }
            if (cbotinhtrang.Text == "")
            {
                errorProvider1.SetError(cbotinhtrang, "Yêu cầu nhập thông tin");
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin");
                return;
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            ERR();
            SqlConnection conn = null;
            CONECT.KetNoiXE ketNoi = new CONECT.KetNoiXE();
            conn = ketNoi.CON();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"update DMHang
                                set TenHang='" + txttenhang.Text + "',MaLoai='" + cbomaloai.Text + "',MaNuocSX='" + cbomansx.Text + "',MaHangSX='" + cbomahsx.Text + "',MaPhanh='" + cbomaphanh.Text + "',MaMau='" + cbomamau.Text + "',MaDongCo='" + cbomadongco.Text +
                                 "',MaTinhTrang='" + cbotinhtrang.Text + "',DungTichKhoang='" + txtdungtich.Text + "',SoLuong=" + txtsoluong.Text + " ,DonGiaNhap=" + txtgianhap.Text + " ,DonGiaBan=" + txtgiaban.Text + " ,ThoiGianBaoHanh='"+txtbaohanh.Text+"'  where MaHang='" + txtmahang.Text + "'";

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
            if (txtmahang.Text == "")
            {
                errorProvider1.SetError(txtmahang, "Không có thông tin để xóa");
                MessageBox.Show("Không có thông tin để xóa");
                return;
            }
            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn xóa", "Hỏi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                SqlConnection conn = null;
                CONECT.KetNoiXE ketNoi = new CONECT.KetNoiXE();
                conn = ketNoi.CON();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"delete DMHang
                                  where MaHang='"+txtmahang.Text+"'";
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

        private void btnluu_Click(object sender, EventArgs e)
        {
            bool ktra = false;
            CONECT.Check check = new CONECT.Check();
            ktra = check.checkprimary(txtmahang.Text, "MaHang", dvghanghoa);
            if (ktra)
            {
                MessageBox.Show("Lỗi trùng mã màu");
                txtmahang.Text = "";
                return;
            }
            ERR();
            SqlConnection conn = null;
            CONECT.KetNoiXE ketNoi = new CONECT.KetNoiXE();
            conn = ketNoi.CON();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"INSERT INTO DMHang (
                                MaHang, TenHang, MaLoai, MaNuocSX, MaHangSX, MaPhanh, MaMau, MaDongCo, 
                                MaTinhTrang, DungTichKhoang, Anh, SoLuong, DonGiaNhap, DonGiaBan, ThoiGianBaoHanh
                            )
                            VALUES (
                                '"+txtmahang.Text+"', '"+txttenhang.Text+"', '"+cbomaloai.Text+"', '"+cbomansx.Text+"', '"+cbomahsx.Text+"', '"+cbomaphanh.Text+"', '"+cbomamau.Text+"', '"+cbomadongco.Text+
                                 "', '"+cbotinhtrang.Text+"', '"+txtdungtich.Text+"', '"+txtanh.Text+"',"+txtsoluong.Text+", "+txtgianhap.Text+", "+txtgiaban.Text+",'"+txtbaohanh.Text+"');";
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
