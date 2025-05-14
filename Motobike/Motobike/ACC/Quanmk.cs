using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using Motobike.CONECT;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
namespace Motobike.ACC
{
    public partial class Quanmk : Form
    {
        public Quanmk()
        {
            InitializeComponent();
        }
        private string macode; // Lưu mã xác nhận

        // Thông tin SMTP cố định (thay bằng thông tin của bạn)
        private const string SMTP_EMAIL = "nguyenmanhthang2k5@gmail.com"; // Email dùng để gửi
        private const string SMTP_PASSWORD = "zyee ckhi uacb wjrk"; // App Password
        private const string SMTP_HOST = "smtp.gmail.com";
        private const int SMTP_PORT = 587;
        private void Quanmk_Load(object sender, EventArgs e)
        {
            btnluu.Visible = false;
            btnmaxn.Visible = false;
            btnmkmoi.Visible = false;
            txtmaxn.Visible = false;
            txtmkmoi.Visible = false;
            btnok.Visible = false;
        }
        public bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
        private bool checkmail(string a)
        {
            SqlConnection conn = null;
            CONECT.KetNoi ketNoi = new CONECT.KetNoi();
            conn = ketNoi.CON();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"select Email from Acc";
            cmd.Connection = conn;
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                string email = r.GetString(0);
                if (a == email.Trim())
                {
                    return true;
                }
            }
            return false;
        }
        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
           
            string Mail = txtmail.Text.Trim();

            if (!IsValidEmail(Mail))
            {
                MessageBox.Show("Email không hợp lệ. Vui lòng nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmail.Focus();
                return;
            }
            if (checkmail(Mail)==false)
            {
                MessageBox.Show("Email chưa được đăng ký","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtmail.Focus();
                return;
                
            }

            Random rand = new Random();
            macode = rand.Next(100000, 999999).ToString();

            try
            {
                using (SmtpClient smtp = new SmtpClient(SMTP_HOST, SMTP_PORT))
                {
                    smtp.EnableSsl = true;
                    smtp.Credentials = new NetworkCredential(SMTP_EMAIL, SMTP_PASSWORD);


                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress(SMTP_EMAIL); // Email gửi cố định
                    mail.To.Add(Mail); // Email nhận từ người dùng
                    mail.Subject = "Mã xác nhận đổi mật khẩu";
                    mail.Body = $@"
                        <h3>Xin chào!</h3>
                        <p>Mã xác nhận của bạn là: <strong>{macode}</strong></p>
                        <p>Mã có hiệu lực trong 5 phút.</p>
                        <p>Bạn nợ tôi 1 lời cảm ơn!!!.</p>

                    ";
                    mail.IsBodyHtml = true;


                    smtp.Send(mail);
                    MessageBox.Show("Đã gửi mã xác nhận. Vui lòng kiểm tra email!");
                    btnmaxn.Visible = true;
                    txtmaxn.Visible = true;
                    btnok.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi gửi email: {ex.Message}");
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
           
            string Mkmoi = txtmkmoi.Text;
            if (string.IsNullOrEmpty(Mkmoi))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới!");
                txtmkmoi.Focus();
                return;
            }
            SqlConnection con = null;
            CONECT.KetNoi ketNoi = new CONECT.KetNoi();
            con = ketNoi.CON();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"UPDATE Acc 
                               SET Mk = '" + Mkmoi + "' WHERE Email = '" + txtmail.Text.Trim() + "';";
            cmd.Connection = con;
            int x=cmd.ExecuteNonQuery();
            if (x > 0)
            {
                MessageBox.Show("Đổi mật khẩu thành công!");
                this.Close(); 
            }  
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            string Maxn = txtmaxn.Text.Trim();
            if (Maxn != macode)
            {
                MessageBox.Show("Mã xác nhận không đúng!");
                txtmaxn.Focus();
                return;
            }
            else
            {
                btnmaxn.Visible = false;
                txtmaxn.Visible = false;
                btnok.Visible = false;
                txtmkmoi.Visible = true;
                btnmkmoi.Visible = true;
                btnluu.Visible = true;
            }

        }
    }
}
