using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Motobike.Hoadon
{
    public partial class VongQuayMayMan : Form
    {
        private float gocHienTai = 0f;
        private Timer timerQuay;
        private Random random = new Random();
        private float tocDoQuay;
        private float gocDich;
        public static string Ketqua = "";

        public VongQuayMayMan()
        {
            InitializeComponent();

            this.BackColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            timerQuay = new Timer();
            timerQuay.Interval = 20;
            timerQuay.Tick += TimerQuay_Tick;

            guna2PictureBox2.Image = Properties.Resources.Thuong2;
            guna2PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            guna2Button1.Text = "QUAY";
            guna2Button1.FillColor = Color.Black;
            guna2Button1.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            guna2Button1.Click += btnQuay_Click;
        }

        private void btnQuay_Click(object sender, EventArgs e)
        {
            tocDoQuay = random.Next(30, 50);
            float gocThem = random.Next(720, 1440); 
            gocDich = gocHienTai + gocThem;
            timerQuay.Start();
        }

        private void TimerQuay_Tick(object sender, EventArgs e)
        {
            if (gocHienTai < gocDich)
            {
                gocHienTai += tocDoQuay;
                tocDoQuay = Math.Max(1f, tocDoQuay - 0.1f);
                guna2PictureBox2.Image = QuayAnh(Properties.Resources.Thuong2, gocHienTai);
            }
            else
            {
                timerQuay.Stop();
                int ketqua = XacDinhGiaiThuong(gocHienTai);
                if(LayTenGiaiThuong(ketqua)== "Chúc bạn may mắn lần sau")
                {
                    Ketqua = LayTenGiaiThuong(ketqua);
                    DialogResult result = MessageBox.Show($"Bạn hơi đen: {LayTenGiaiThuong(ketqua)}", "Kết quả quay", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                else
                {
                    Ketqua = LayTenGiaiThuong(ketqua);
                    DialogResult res = MessageBox.Show($"🎉 Bạn trúng: {LayTenGiaiThuong(ketqua)}", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (res == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                
            }
        }

        private Image QuayAnh(Image img, float angle)
        {
            Bitmap bmp = new Bitmap(img.Width, img.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.TranslateTransform(img.Width / 2, img.Height / 2);
                g.RotateTransform(angle);
                g.TranslateTransform(-img.Width / 2, -img.Height / 2);
                g.DrawImage(img, new Point(0, 0));
            }
            return bmp;
        }

        private int XacDinhGiaiThuong(float goc)
        {
            float goc360 = goc % 360;
            float gocQuay = (360 - goc360 + 22.5f) % 360;
            int phan = (int)(gocQuay / 60);
            return phan;
        }

        private string LayTenGiaiThuong(int index)
        {
            string[] giai = {
                "Chúc bạn may mắn lần sau", "Quạt", "Chúc bạn may mắn lần sau", "Ấm siêu tốc",
                "Chúc bạn may mắn lần sau", "Nồi cơm điện"
            };
            return giai[index];
        }

        private void VongQuayMayMan_Load(object sender, EventArgs e)
        {

        }
    }
}
