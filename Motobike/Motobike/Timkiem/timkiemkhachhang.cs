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

namespace Motobike.Timkiem
{
    public partial class timkiemkhachhang : Form
    {
        public timkiemkhachhang()
        {
            InitializeComponent();
        }

        private void timkiemkhachhang_Load(object sender, EventArgs e)
        {
            NapMaKh();
            txtdiachi.Enabled = false;
            txtsdt.Enabled = false;
            txttenkh.Enabled = false;

        }
        public void NapMaKh()
        {
            SqlCommand cmd = null;
            CONECT.FillData fillData = new CONECT.FillData();
            cmd = fillData.FillMaKH(cmd);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbomakh.Items.Add(reader["MaKH"].ToString());
            }
            reader.Close();
        }
        public void hienthi()
        {
            SqlConnection conn = null;
            CONECT.KetNoiXE ketNoi = new CONECT.KetNoiXE();
            conn = ketNoi.CON();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"select *  from KhachHang
                             where MaKH='" + cbomakh.Text + "'";
            cmd.Connection = conn;
            List<Thongtinkhach> list = new List<Thongtinkhach>();
            Thongtinkhach khach;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string makh=reader.GetString(0);
                string tenkh=reader.GetString(1);
                string diachi=reader.GetString(2);
                string sdt=reader.GetString(3);
                khach =new Thongtinkhach() {MaKH=makh,TenKH=tenkh,DiaChi=diachi,SĐT=sdt};
                list.Add(khach);
            }
            dgvkhach.DataSource = list;
            reader.Close();

        }
        private void btntimkiem_Click(object sender, EventArgs e)
        {
            if (cbomakh.Text != "")
            {
                hienthi();
            }
        }
        private void btntimlai_Click(object sender, EventArgs e)
        {
            cbomakh.SelectedIndex =-1 ;
            txttenkh.Text = "";
            txtdiachi.Text = "";
            txtsdt.Text = "";
            dgvkhach.DataSource = null;


        }
        private void cbomakh_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvkhach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvkhach.Rows[e.RowIndex];
                string makh = selectedRow.Cells[0].Value?.ToString();
                string tenkh = selectedRow.Cells[1].Value?.ToString();
                string diachi = selectedRow.Cells[2].Value?.ToString();
                string sdt = selectedRow.Cells[3].Value?.ToString();
                cbomakh.Text = makh;
                txtdiachi.Text = diachi;
                txtsdt.Text = sdt;
                txttenkh .Text = tenkh;
               
            }
        }
    }
}
