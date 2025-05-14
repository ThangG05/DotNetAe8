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
using System.Data.SqlClient;
using System.Net.Mail;
namespace Motobike.ACC
{
    public partial class Dangky : Form
    {
        public Dangky()
        {
            InitializeComponent();
        }
        private bool check(string keyy,string cot)
        {
           
            SqlConnection conn = null;
            CONECT.KetNoi ketNoi = new CONECT.KetNoi();
            conn = ketNoi.CON();
            string query = "SELECT COUNT(*) FROM Acc WHERE "+cot+" = @keyyy";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Keyyy", keyy);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
        public bool ktramail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
            if (txtten.Text == "")
            {
                errorProvider1.SetError(txtten, "Không được bỏ trống");
                MessageBox.Show("Không được bỏ trống tên đăng nhập", "Lỗi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                return;
            }
            if (txtmk.Text == "")
            {
                errorProvider1.SetError(txtmk, "Không được bỏ trống");
                MessageBox.Show("Không được bỏ trống mật khẩu", "Lỗi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                return;
            }
            if (txtxacminh.Text == "")
            {
                errorProvider1.SetError(txtxacminh, "Không được bỏ trống");
                MessageBox.Show("Không được bỏ trống xác thực mật khẩu", " Lỗi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                return;
            }
            string tendn = txtten.Text.Trim();
       
            if (check(tendn,"Ten"))
            {

                MessageBox.Show(" Đã tồn tại tên đăng nhập", "Lỗi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                errorProvider2.SetError(txtten,"Tên đăng nhập đã tồn tại");
                return;
            }
            if (!ktramail(txtmail.Text))
            {
                MessageBox.Show("Email không hợp lệ", "Lỗi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                errorProvider2.SetError(txtmail, "Email không hợp lệ");
                return;
            }
            string gmail=txtmail.Text.Trim();
            if (check(gmail,"Email"))
            {
                MessageBox.Show(" Đã tồn tại gmail", "Lỗi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                errorProvider2.SetError(txtmail, "Gmail đã tồn tại");
                return;
            }
            if (txtmk.Text != txtxacminh.Text)
            {
                MessageBox.Show("Mã khẩu xác nhận sai", "Lỗi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                errorProvider2.SetError(txtxacminh, "Mật khẩu xác nhận chưa đúng");
                return;
            }
            else
            {
                SqlConnection conn = null;
                CONECT.KetNoi ketNoi = new CONECT.KetNoi();
                conn = ketNoi.CON();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                string ten = txtten.Text.Trim();
                string mk = txtmk.Text.Trim();
                string mail = txtmail.Text.Trim();
                cmd.CommandText = @"insert into Acc values('" + ten + "','" + mk + "','" + mail + "')";
                cmd.Connection = conn;
                int x = cmd.ExecuteNonQuery();
                if (x > 0)
                {
                    MessageBox.Show("Đăng ký thành công");
                }
            }
           
        }
        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
