using Guna.UI2.WinForms;
using Motobike.ACC;
using Motobike.Header;
using Motobike.Mathang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Motobike
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
            
        }
        private Form currentChild;
        private Form parentchild;
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
        private void Header(Form Child)
        {
            if (parentchild != null)
            {
                parentchild.Close();
            }
            parentchild = Child;
            Child.TopLevel = false;
            Child.FormBorderStyle = FormBorderStyle.None;
            Child.Dock = DockStyle.Fill;
            phead.Controls.Add(Child);
            Child.BringToFront();
            Child.Show();
        }
        public void chuyenmau()
        {
            Danhmuc.FillColor = Color.Black;
            Danhmuc.ForeColor = Color.White;
            Hoadon.FillColor= Color.Black;
            Hoadon.ForeColor = Color.White;
            Timkiem.FillColor= Color.Black;
            Timkiem.ForeColor = Color.White;
            Baocao.FillColor= Color.Black;
            Baocao.ForeColor = Color.White;
            Mathang.FillColor= Color.Black;
            Mathang.ForeColor = Color.White;
        }
        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Open(new Index2());
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            chuyenmau();
            if (currentChild != null)
            {
                currentChild.Close();
            }
            if (parentchild != null)
            {
                parentchild.Close();
            }
        }

        private void Timkiem_Click(object sender, EventArgs e)
        {
            chuyenmau();
            Timkiem.FillColor = Color.FromArgb(130, 142, 151);
            Timkiem.ForeColor = Color.Black;
            Header(new Timkiemlogo());
            Open(new Timkiem.Timkiemmain());
        }

        private void Baocao_Click(object sender, EventArgs e)
        {
            Dangnhap dn = new Dangnhap(this);
            var result = dn.ShowDialog();  
           
            if (dn.CheckValue == true)
            {
                chuyenmau();
                Baocao.FillColor = Color.FromArgb(130, 142, 151);
                Baocao.ForeColor = Color.Black;
                Header(new Baocaologo());
                Open(new Baocao.Baocaomain());
            }
        }

        private void Mathang_Click(object sender, EventArgs e)
        {
            chuyenmau();
            Mathang.FillColor = Color.FromArgb(130, 142, 151);
            Mathang.ForeColor = Color.Black;
            Header(new Mathanglogo());
            Open(new Mathang.Mathangmain());
        }

        private void Hoadon_Click(object sender, EventArgs e)
        {
            chuyenmau();
            Hoadon.FillColor = Color.FromArgb(130, 142, 151);
            Hoadon.ForeColor = Color.Black;
            Header(new Hoadonlogo());
            Open(new Hoadon.Hoadonmain());
        }

        private void Danhmuc_Click(object sender, EventArgs e)
        {
            chuyenmau();
            Danhmuc.FillColor = Color.FromArgb(130, 142, 151);
            Danhmuc.ForeColor = Color.Black;
            Header(new Danhmuclogo());
            Open(new Danhmuc.DanhMucChinh());
        }
    }
}
