using Motobike.Timkiem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Motobike.Baocao
{
    public partial class Baocaomain : Form
    {
        public Baocaomain()
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
            pbody.Controls.Add(Child);
            Child.BringToFront();
            Child.Show();
        }
        public void chuyenmau()
        {
            btnnhaphang.FillColor = Color.FromArgb(94, 148, 255);
            btnnhaphang.ForeColor = Color.White;
            btnbanhang.FillColor = Color.FromArgb(94, 148, 255);
            btnbanhang.ForeColor = Color.White;
            btnkinhdoanh.FillColor = Color.FromArgb(94, 148, 255);
            btnkinhdoanh.ForeColor = Color.White;
            btnsanpham.FillColor = Color.FromArgb(94, 148, 255);
            btnsanpham.ForeColor = Color.White;
        }

        private void btnnhaphang_Click(object sender, EventArgs e)
        {
            chuyenmau();
            btnnhaphang.FillColor = Color.FromArgb(130, 142, 151);
            btnnhaphang.ForeColor = Color.Wheat;
            Open(new Baocaonhaphang());
        }

        private void btnbanhang_Click(object sender, EventArgs e)
        {
            chuyenmau();
            btnbanhang.FillColor = Color.FromArgb(130, 142, 151);
            btnbanhang.ForeColor = Color.Wheat;
            Open(new Baocaobanhang());
        }

        private void btnkinhdoanh_Click(object sender, EventArgs e)
        {
            chuyenmau();
            btnkinhdoanh.FillColor = Color.FromArgb(130, 142, 151);
            btnkinhdoanh.ForeColor = Color.Wheat;
            Open(new Baocaohoatdongkinhdoanh());
        }

        private void btnsanpham_Click(object sender, EventArgs e)
        {
            chuyenmau();
            btnsanpham.FillColor = Color.FromArgb(130, 142, 151);
            btnsanpham.ForeColor = Color.Wheat;
            Open(new Baocaotopsanpham());
        }
    }
}
