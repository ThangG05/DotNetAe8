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
    public partial class Danhmuctheloai : Form
    {
        public Danhmuctheloai()
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
            cmd.CommandText = @"select *from TheLoai";
            cmd.Connection = conn;
            List<TheLoaiXe> ds = new List<TheLoaiXe>();
            TheLoaiXe theLoaiXe;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string math=reader.GetString(0);
                string tenth=reader.GetString(1);
                theLoaiXe = new TheLoaiXe() { MaLoai=math,TenLoai=tenth};
                ds.Add(theLoaiXe);  
            }
            dgvtheloai.DataSource = ds;
            reader.Close();
            
        }
        private void Danhmuctheloai_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        private void dgvtheloai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvtheloai.Rows[e.RowIndex];
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
            btnboqua.Enabled = true;
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            txtma.Enabled = true;
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            clear();
            btnsua.Enabled=true;
            btnxoa.Enabled = true;
            txtma.Enabled = false;
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
            cmd.CommandText = @"update TheLoai
                                set TenLoai='"+txtten.Text+ "' where MaLoai='"+txtma.Text+"'";
            cmd.Connection = conn;
            int x=cmd.ExecuteNonQuery();
            if (x > 0)
            {
                MessageBox.Show("Sửa thành công");
                hienthi();
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool ktra = false;
            CONECT.Check check = new CONECT.Check();
            ktra = check.checkprimary(txtma.Text, "MaLoai", dgvtheloai);
            if (ktra)
            {
                MessageBox.Show("Lỗi trùng mã thể loại");
                txtma.Text = "";
                return;
            }
            if (txtma.Text == "")
            {
                errorProvider1.SetError(txtma, "Yêu cầu nhập thông tin");
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin");
                return;
            }
            if (txtten.Text == "" )
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
            cmd.CommandText = @"insert into TheLoai values('" + txtma.Text + "','" + txtten.Text + "')";
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

        private void btnxoa_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txtma.Text == "")
            {
                errorProvider1.SetError(txtma, "Không có thông tin để xóa");
                MessageBox.Show("Không có thông tin để xóa");
                return;
            }
            DialogResult res= MessageBox.Show("Bạn có chắc chắn muốn xóa","Hỏi",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                SqlConnection conn = null;
                CONECT.KetNoiXE ketNoi = new CONECT.KetNoiXE();
                conn = ketNoi.CON();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"delete TheLoai
                              where MaLoai='" + txtma.Text + "'";
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
