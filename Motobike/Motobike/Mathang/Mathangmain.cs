using iTextSharp.text.rtf.document;
using Motobike.Hoadon;
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

namespace Motobike.Mathang
{
    public partial class Mathangmain : Form
    {
        public Mathangmain()
        {
            InitializeComponent();
        }

        private void Mathangmain_Load(object sender, EventArgs e)
        {

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
            btnhonda.FillColor = Color.FromArgb(94, 148, 255);
            btnhonda.ForeColor = Color.White;
            btnyamaha.FillColor = Color.FromArgb(94, 148, 255);
            btnyamaha.ForeColor = Color.White;
            btnsuzuki.FillColor = Color.FromArgb(94, 148, 255);
            btnsuzuki.ForeColor = Color.White;

        }

        private void btnhonda_Click(object sender, EventArgs e)
        {
            chuyenmau();
            btnhonda.FillColor = Color.FromArgb(130, 142, 151);
            btnhonda.ForeColor = Color.Wheat;
            Open(new Honda());
        }

        private void btnyamaha_Click(object sender, EventArgs e)
        {
            chuyenmau();
            btnyamaha.FillColor = Color.FromArgb(130, 142, 151);
            btnyamaha.ForeColor = Color.Wheat;
            Open(new Yamaha());
        }

        private void btnsuzuki_Click(object sender, EventArgs e)
        {
            chuyenmau();
            btnsuzuki.FillColor = Color.FromArgb(130, 142, 151);
            btnsuzuki.ForeColor = Color.Wheat;
            Open(new Suzuki());
        }
    }
       
       
}
