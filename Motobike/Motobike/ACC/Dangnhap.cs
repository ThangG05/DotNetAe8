using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Motobike.Header;
using System.Runtime.InteropServices.WindowsRuntime;
namespace Motobike.ACC
{
    public partial class Dangnhap : Form
    {
        private Index index;
        bool check = false;
        public bool CheckValue
        {
            get { return check; }
            set { check = value; }
        }
        public Dangnhap(Index mainForm)
        {
            InitializeComponent();
            index = mainForm;
        }

        private void butcreate_Click(object sender, EventArgs e)
        {
            Dangky dangky = new Dangky();
            dangky.Show();
        }

        private void ButDangnhap_Click(object sender, EventArgs e)
        {
            SqlConnection con = null;
            CONECT.KetNoi ketNoi = new CONECT.KetNoi();
            con=ketNoi.CON();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"select *from Acc";
            cmd.Connection = con;
            SqlDataReader reader = cmd.ExecuteReader();
            string ten=default;
            string mk=default;
            while (reader.Read())
            {
                ten=reader.GetString(0);
                mk=reader.GetString(1);
                if (txttaikhoan.Text.Trim() == ten.Trim() && txtmatkhau.Text.Trim() == mk.Trim()) 
                {
                    this.Close();
                    check = true;
                }
                
            }
            if (check==false)
            {
                MessageBox.Show("Tài khoản sai");
            }
            reader.Close();
        }
        private void txttaikhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lblforget_Click(object sender, EventArgs e)
        {
            Quanmk quen=new Quanmk();
            quen.Show();
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            if (txtmatkhau.UseSystemPasswordChar == true) 
            {

                txtmatkhau.UseSystemPasswordChar = false; 
                btnview.Image = Properties.Resources.thuc;
            }
            else
            {
                txtmatkhau.UseSystemPasswordChar = true; 
                btnview.Image = Properties.Resources.ngu;
            }
        }

        private void txtmatkhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
