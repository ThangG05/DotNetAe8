using iTextSharp.text.pdf.codec;
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
    public partial class Danhmucmausac : Form
    {
        public Danhmucmausac()
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
            cmd.CommandText = @"select *from MauSac";
            cmd.Connection = conn;
            List<Mau> ds = new List<Mau>();
            Mau mau;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string math = reader.GetString(0);
                string tenth = reader.GetString(1);
                mau = new Mau() { Mamau = math, Tenmau = tenth };
                ds.Add(mau);
            }
            dgvmausac.DataSource = ds;
            reader.Close();

        }
        private void Danhmucmausac_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        private void dgvmausac_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvmausac.Rows[e.RowIndex];
                string code = selectedRow.Cells[0].Value?.ToString();
                string name = selectedRow.Cells[1].Value?.ToString();
                txtma.Text = code;
                txtten.Text = name;
            }
            txtma.Enabled = false;

        }
        private void clear()
        {
            txtma.Text = "";
            txtten.Text = "";
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

        private void btnluu_Click(object sender, EventArgs e)
        {
            bool ktra = false;
            CONECT.Check check = new CONECT.Check();
            ktra = check.checkprimary(txtma.Text, "MaMau",dgvmausac);
            if (ktra)
            {
                MessageBox.Show("Lỗi trùng mã màu");
                txtma.Text = "";
                return;
            }
            if (txtma.Text == "")
            {
                errorProvider1.SetError(txtma, "Yêu cầu nhập thông tin");
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin");
                return;
            }
            if (txtten.Text == "")
            {
                errorProvider1.SetError(txtten, "Yêu cầu nhập thông tin");
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin");
                return;
            }
            SqlConnection conn = null;
            CONECT.KetNoiXE ketNoi = new CONECT.KetNoiXE();
            conn = ketNoi.CON();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"insert into MauSac values('"+txtma.Text+"',N'"+txtten.Text+"')";
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

        private void btnsua_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txtten.Text == "")
            {
                errorProvider1.SetError(txtten, "Yêu cầu nhập thông tin");
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin");
                return;
            }
            SqlConnection conn = null;
            CONECT.KetNoiXE ketNoi = new CONECT.KetNoiXE();
            conn = ketNoi.CON();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"update MauSac
                                set TenMau='" + txtten.Text + "'  where MaMau='" + txtma.Text + "'";
                               
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
           
            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn xóa","Hỏi",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                SqlConnection conn = null;
                CONECT.KetNoiXE ketNoi = new CONECT.KetNoiXE();
                conn = ketNoi.CON();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"delete MauSac
                               where MaMau='" + txtma.Text + "'";
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
    }
}
