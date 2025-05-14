using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Motobike.Hoadon
{
    public partial class Hoadonmain : Form
    {
        public Hoadonmain()
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
            btnhoadonban.FillColor = Color.FromArgb(94, 148, 255);
            btnhoadonban.ForeColor = Color.White;
            btnhoadonnhap.FillColor = Color.FromArgb(94, 148, 255);
            btnhoadonnhap.ForeColor = Color.White;
        }

        private void btnhoadonban_Click(object sender, EventArgs e)
        {
            chuyenmau();
            btnhoadonban.FillColor = Color.FromArgb(130, 142, 151);
            btnhoadonban.ForeColor = Color.Wheat;
            Open(new Hoadonban());
        }

        private void btnhoadonnhap_Click(object sender, EventArgs e)
        {
            chuyenmau();
            btnhoadonnhap.FillColor = Color.FromArgb(130, 142, 151);
            btnhoadonnhap.ForeColor = Color.Wheat;
            Open(new Hoadonnhap());
        }

        private void Hoadonmain_Load(object sender, EventArgs e)
        {

        }
    }
}
