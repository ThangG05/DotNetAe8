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

namespace Motobike.Timkiem
{
    public partial class Timkiemmain : Form
    {
        public Timkiemmain()
        {
            InitializeComponent();
        }
        private Form currentChild;
        private void Open(Form Child)
        {
            if (currentChild != null)
            {
                currentChild.Close();
            }
            currentChild = Child;
            Child.TopLevel = false;
            Child.FormBorderStyle = FormBorderStyle.None;
            Child.Dock = DockStyle.Fill;
            patimkiem.Controls.Add(Child);
            Child.BringToFront();
            Child.Show();
        }
        public void chuyenmau()
        {
            btnhanghoa.FillColor = Color.FromArgb(94, 148, 255);
            btnhanghoa.ForeColor = Color.White;
            btnhoadonnhap.FillColor = Color.FromArgb(94, 148, 255);
            btnhoadonnhap.ForeColor = Color.White;
            btnkhachhang.FillColor = Color.FromArgb(94, 148, 255);
            btnkhachhang.ForeColor = Color.White;
            btnhoadonban.FillColor = Color.FromArgb(94, 148, 255);
            btnhoadonban.ForeColor = Color.White;
        }
        private void btnhoadonban_Click(object sender, EventArgs e)
        {
            chuyenmau();
            btnhoadonban.FillColor = Color.FromArgb(130, 142, 151);
            btnhoadonban.ForeColor = Color.Wheat;
            Open(new timkiemhoadonban());

        }

        private void btnhanghoa_Click(object sender, EventArgs e)
        {
            chuyenmau();
            btnhanghoa.FillColor = Color.FromArgb(130, 142, 151);
            btnhanghoa.ForeColor = Color.Wheat;
            Open(new timkiemhanghoa());
            
        }

        private void btnhoadonnhap_Click(object sender, EventArgs e)
        {
            chuyenmau();
            btnhoadonnhap.FillColor = Color.FromArgb(130, 142, 151);
            btnhoadonnhap.ForeColor = Color.Wheat;
            Open(new timkiemhoadonnhap());
        }

        private void btnkhachhang_Click(object sender, EventArgs e)
        {
            chuyenmau();
            btnkhachhang.FillColor = Color.FromArgb(130, 142, 151);
            btnkhachhang.ForeColor = Color.Wheat;
            Open(new timkiemkhachhang());
        }
    }
}
