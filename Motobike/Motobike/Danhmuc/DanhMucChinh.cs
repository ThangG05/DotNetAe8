using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Motobike.Danhmuc
{
    public partial class DanhMucChinh : Form
    {
        public DanhMucChinh()
        {
            InitializeComponent();
        }
        private Form pa1;
        private Form pa2;
        private Form pa3;
        private Form pa4;
        private void Open1(Form Child)
        {
            if (pa1 != null)
            {
                pa1.Close();
            }
            pa1= Child;
            Child.TopLevel = false;
            Child.FormBorderStyle = FormBorderStyle.None;
            Child.Dock = DockStyle.Fill;
            pabodydanhmuc.Controls.Add(Child);
            Child.BringToFront();
            Child.Show();
        }
        public void chuyenmau()
        {
            btnhanghoa.FillColor = Color.Black;
            btnhanghoa.ForeColor = Color.White;
            btnnhanvien.FillColor = Color.Black;
            btnnhanvien.ForeColor = Color.White;
            btnnhacungcap.FillColor = Color.Black;
            btnnhacungcap.ForeColor = Color.White;
            btnmausac.FillColor = Color.Black;
            btnmausac.ForeColor = Color.White;
            btnkhachhang.FillColor = Color.Black;
            btnkhachhang.ForeColor = Color.White;
            btntheloai.FillColor = Color.Black;
            btntheloai.ForeColor = Color.White;
        }
        private void buttheloai_Click(object sender, EventArgs e)
        {
            Open1(new Danhmuctheloai());
            chuyenmau();
            btntheloai.FillColor = Color.FromArgb(130, 142, 151);
            btntheloai.ForeColor = Color.Black;
        }

        private void btnmausac_Click(object sender, EventArgs e)
        {
            Open1(new Danhmucmausac());
            chuyenmau();
            btnmausac.FillColor = Color.FromArgb(130, 142, 151);
            btnmausac.ForeColor = Color.Black;
        }

        private void btnkhachhang_Click(object sender, EventArgs e)
        {
            Open1(new Danhmuckhachhang());
            chuyenmau();
            btnkhachhang.FillColor = Color.FromArgb(130, 142, 151);
            btnkhachhang.ForeColor = Color.Black;
        }

        private void btnnhanvien_Click(object sender, EventArgs e)
        {
            Open1(new Danhmucnhanvien());
            chuyenmau();
            btnnhanvien.FillColor = Color.FromArgb(130, 142, 151);
            btnnhanvien.ForeColor = Color.Black;
        }

        private void btnnhacungcap_Click(object sender, EventArgs e)
        {
            Open1(new Danhmucnhacungcap());
            chuyenmau();
            btnnhacungcap.FillColor = Color.FromArgb(130, 142, 151);
            btnnhacungcap.ForeColor = Color.Black;
        }

        private void btnhanghoa_Click(object sender, EventArgs e)
        {
            Open1(new Danhmuchanghoa());
            chuyenmau();
            btnhanghoa.FillColor = Color.FromArgb(130, 142, 151);
            btnhanghoa.ForeColor = Color.Black;
        }
    }
}
