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
    public partial class Danhmucnhacungcap : Form
    {
        public Danhmucnhacungcap()
        {
            InitializeComponent();
        }

        private void Danhmucnhacungcap_Load(object sender, EventArgs e)
        {
            hienthi();
        }
        private void hienthi()
        {
            SqlConnection conn = null;
            CONECT.KetNoiXE ketNoi = new CONECT.KetNoiXE();
            conn = ketNoi.CON();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"select *from NhaCungCap";
            cmd.Connection = conn;
            List<NhaCC> ds = new List<NhaCC>();
            NhaCC nhacc;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string mancc=reader.GetString(0);
                string tenncc=reader.GetString(1);
                string diachi=reader.GetString(2);
                string sdt=reader.GetString(3);
                nhacc = new NhaCC() { MaNCC = mancc, TenNCC = tenncc,DiaChi=diachi,SDT=sdt };
                ds.Add(nhacc);
            }
            dgvnhacc.DataSource = ds;
            reader.Close();

        }

        private void dgvnhacc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvnhacc.Rows[e.RowIndex];
                string code = selectedRow.Cells[0].Value?.ToString();
                string name = selectedRow.Cells[1].Value?.ToString();
                
                string diachi = selectedRow.Cells[2].Value?.ToString();

                string sdt = selectedRow.Cells[3].Value?.ToString();
                txtdiachi.Text = diachi;
                txtma.Text = code;
                txtsdt.Text = sdt;
                txtten.Text = name;
                

            }
            txtma.Enabled = false;
        }
        private void clear()
        {
            txtma.Text = "";
            txtdiachi.Text = "";
            txtsdt.Text = "";
            txtten.Text = "";
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
           clear();
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnboqua.Enabled = true;
            txtma.Enabled = true;
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            clear();
            btnxoa.Enabled=true;
            btnsua.Enabled=true;
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

            if (txtdiachi.Text == "")
            {
                errorProvider1.SetError(txtdiachi, "Yêu cầu nhập thông tin");
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin");
                return false;
            }
            if (txtsdt.Text == "")
            {
                errorProvider1.SetError(txtsdt, "Yêu cầu nhập thông tin");
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
            if (check == false)
            {
                return;
            }
            SqlConnection conn = null;
            CONECT.KetNoiXE ketNoi = new CONECT.KetNoiXE();
            conn = ketNoi.CON();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"update NhaCungCap
                                set TenNCC='"+txtten.Text+"',DiaChi='"+txtdiachi.Text+"',DienThoai='"+txtsdt.Text+
                                "'   where MaNCC='"+txtma.Text+"'";
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
            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn xóa", "Hỏi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                SqlConnection conn = null;
                CONECT.KetNoiXE ketNoi = new CONECT.KetNoiXE();
                conn = ketNoi.CON();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"delete NhaCungCap
                                where MaNCC='" + txtma.Text + "'";
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
            ktra = check.checkprimary(txtma.Text, "MaMau", dgvnhacc);
            if (ktra)
            {
                MessageBox.Show("Lỗi trùng MaNCC");
                txtma.Text = "";
                return;
            }
            ERR();
            bool err = ERR();
            if (err == false)
            {
                return;
            }
            SqlConnection conn = null;
            CONECT.KetNoiXE ketNoi = new CONECT.KetNoiXE();
            conn = ketNoi.CON();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"insert into NhaCungCap values('"+txtma.Text+"','"+txtten.Text+"','"+txtdiachi.Text+"','"+txtsdt.Text+"')";
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
