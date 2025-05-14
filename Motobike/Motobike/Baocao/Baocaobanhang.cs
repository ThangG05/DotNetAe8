using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Win32;
using System.Data.SqlClient;
using Motobike.Timkiem;
using System.Runtime.InteropServices;
using System.Globalization;
namespace Motobike.Baocao
{
    public partial class Baocaobanhang : Form
    {
        public Baocaobanhang()
        {
            InitializeComponent();
        }
        private void ExportExcel(string path)
        {
            Excel.Application app = new Excel.Application();
            Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];
            worksheet.Name = "Báo cáo";

            // Header
            for (int i = 0; i < dgvbaocaoban.Columns.Count; i++)
            {
                Excel.Range headerCell = (Excel.Range)worksheet.Cells[1, i + 1];
                headerCell.Value = dgvbaocaoban.Columns[i].HeaderText;
                headerCell.Font.Bold = true;
                headerCell.Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.LightGray);
                headerCell.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                headerCell.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            }

            // Data
            for (int i = 0; i < dgvbaocaoban.Rows.Count; i++)
            {
                for (int j = 0; j < dgvbaocaoban.Columns.Count; j++)
                {
                    var cell = (Excel.Range)worksheet.Cells[i + 2, j + 1];
                    cell.Value = dgvbaocaoban.Rows[i].Cells[j].Value;
                    cell.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    cell.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                }
            }

            worksheet.Columns.AutoFit();
            workbook.SaveAs(path);
            workbook.Close();
            app.Quit();

            // Giải phóng COM
            Marshal.ReleaseComObject(worksheet);
            Marshal.ReleaseComObject(workbook);
            Marshal.ReleaseComObject(app);
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void btnin_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.SaveFileDialog save = new System.Windows.Forms.SaveFileDialog();
            save.Title = "Xuat File";
            save.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
            if(save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExcel(save.FileName);
                    MessageBox.Show("Xuất file thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất file thấy bại"+ex.Message);
                }
            }

            
        }
        public void NapMaHD()
        {
            SqlCommand cmd = null;
            CONECT.FillData fillData = new CONECT.FillData();
            cmd = fillData.FillMaHD2(cmd);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbnmahd.Items.Add(reader["SoDDH"].ToString());
            }
            reader.Close();
        }
        public void NapManv()
        {
            SqlCommand cmd = null;
            CONECT.FillData fillData = new CONECT.FillData();
            cmd = fillData.FillManv(cmd);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbnmnv.Items.Add(reader["MaNV"].ToString());
            }
            reader.Close();
        }
        public void NapTenHang()
        {
            SqlCommand cmd = null;
            CONECT.FillData fillData = new CONECT.FillData();
            cmd = fillData.FillTenhang(cmd);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbntenhang.Items.Add(reader["TenHang"].ToString());
            }
            reader.Close();
        }
        public void NapTenKhach()
        {
            SqlCommand cmd = null;
            CONECT.FillData fillData = new CONECT.FillData();
            cmd = fillData.FillTenKhach(cmd);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbntenkhach.Items.Add(reader["TenKH"].ToString());
            }
            reader.Close();
        }
        private void Baocaobanhang_Load(object sender, EventArgs e)
        {
            NapMaHD();
            NapManv();
            NapTenHang();
            NapTenKhach();
            An();
        }
        private void An()
        {
            txtbdau.Visible = false;
            txtketthuc.Visible = false;
            txtngay.Visible = false;
            lbldau.Visible = false;
            lblketthuc.Visible = false;
        }

        private void hienthi(string Tenbang, string Tencot, string value)
        {
            SqlConnection conn = null;
            CONECT.KetNoiXE ketNoi = new CONECT.KetNoiXE();
            conn = ketNoi.CON();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"SELECT 
                            DonDatHang.SoDDH,
                            NhanVien.TenNV, 
                            KhachHang.TenKH, 
                            DMHang.TenHang,
                            DonDatHang.NgayMua, 
                            DonDatHang.Thue,
                            DonDatHang.TongTien
                        FROM DonDatHang
                        JOIN NhanVien ON DonDatHang.MaNV = NhanVien.MaNV
                        JOIN KhachHang ON DonDatHang.MaKH = KhachHang.MaKH
                        JOIN CTDonDatHang ON DonDatHang.SoDDH = CTDonDatHang.SoDDH
                        JOIN DMHang ON CTDonDatHang.MaHang = DMHang.MaHang
                        WHERE "+Tenbang+"."+Tencot+" = N'"+value+"';";
            cmd.Connection = conn;
            List<Hoadonban> ds= new List<Hoadonban>();
            Hoadonban hd;
           SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int sohd = reader.GetInt32(0);
                string Tennv=reader.GetString(1);
                string tenkh=reader.GetString(2);
                string tenh=reader.GetString(3);
                DateTime ngay= reader.GetDateTime(4);
                int thue=reader.GetInt32(5);
                int tongtien=reader.GetInt32(6);
                hd = new Hoadonban() { SoHHD=sohd,TenNV=Tennv,TenKH=tenkh,TenHang=tenh,NgayMua=ngay,Thue=thue,TongTien=tongtien};
                ds.Add(hd);
            }
            dgvbaocaoban.DataSource = ds;
            reader.Close();
        }
        private void btntimkiem_Click(object sender, EventArgs e)
        {
            if (cbnmahd.Text != "")
            {
                hienthi("DonDatHang","SoDDH",cbnmahd.Text);
                return;
            }
            if (cbnmnv.Text != "")
            {
                hienthi("NhanVien","MaNV",cbnmnv.Text);
                return;
            }
            if (cbntenhang.Text != "")
            {
                hienthi("DMHang", "TenHang", cbntenhang.Text);
                return;
            }
            if (cbntenkhach.Text != "")
            {
                hienthi("KhachHang", "TenKH", cbntenkhach.Text);
                return;
            }
            if (ckbngay.Checked)
            {
                string input = txtngay.Text;
                DateTime ngayChon;

                if (DateTime.TryParseExact(input, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngayChon))
                {
                    string ngayFormatSQL = ngayChon.ToString("yyyy-MM-dd");
                    hienthi("DonDatHang", "NgayMua", ngayFormatSQL);
                }
                else
                {
                    MessageBox.Show("Ngày không hợp lệ. Vui lòng nhập đúng định dạng dd/MM/yyyy.");
                }
                return;
            }
            if (ckbthoigian.Checked)
            {
                string input = txtbdau.Text;
                string input2 = txtketthuc.Text;
                DateTime ngayChon;
                DateTime ngayChon2;
                if (!DateTime.TryParseExact(input, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngayChon) ||
                    !DateTime.TryParseExact(input2, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngayChon2))
                {
                    MessageBox.Show("Ngày không hợp lệ. Vui lòng nhập đúng định dạng dd/MM/yyyy.");
                    return;
                }
                SqlConnection conn = null;
                CONECT.KetNoiXE ketNoi = new CONECT.KetNoiXE();
                conn = ketNoi.CON();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"
                                    SELECT 
                                        DonDatHang.SoDDH,
                                        NhanVien.TenNV, 
                                        KhachHang.TenKH, 
                                        DMHang.TenHang,
                                        DonDatHang.NgayMua, 
                                        DonDatHang.Thue,
                                        DonDatHang.TongTien
                                    FROM DonDatHang
                                    JOIN NhanVien ON DonDatHang.MaNV = NhanVien.MaNV
                                    JOIN KhachHang ON DonDatHang.MaKH = KhachHang.MaKH
                                    JOIN CTDonDatHang ON DonDatHang.SoDDH = CTDonDatHang.SoDDH
                                    JOIN DMHang ON CTDonDatHang.MaHang = DMHang.MaHang
                                    WHERE DonDatHang.NgayMua BETWEEN @bdau AND @kthuc";
                cmd.Parameters.AddWithValue("@bdau", ngayChon.Date);
                cmd.Parameters.AddWithValue("@kthuc", ngayChon2.Date);
                cmd.Connection = conn;
                List<Hoadonban> ds = new List<Hoadonban>();
                Hoadonban hd;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int sohd = reader.GetInt32(0);
                    string Tennv = reader.GetString(1);
                    string tenkh = reader.GetString(2);
                    string tenh = reader.GetString(3);
                    DateTime ngay = reader.GetDateTime(4);
                    int thue = reader.GetInt32(5);
                    int tongtien = reader.GetInt32(6);
                    hd = new Hoadonban()
                    {
                        SoHHD = sohd,
                        TenNV = Tennv,
                        TenKH = tenkh,
                        TenHang = tenh,
                        NgayMua = ngay,
                        Thue = thue,
                        TongTien = tongtien
                    };
                    ds.Add(hd);
                }
                reader.Close();
                dgvbaocaoban.DataSource = ds;
                return;
            }
        }

        private void ckbngay_CheckedChanged(object sender, EventArgs e)
        {
            txtngay.Visible = true;
        }

        private void ckbthoigian_CheckedChanged(object sender, EventArgs e)
        {
            txtbdau.Visible = true;
            txtketthuc.Visible = true;
            lbldau.Visible = true;
            lblketthuc.Visible = true;
        }

        private void btntimlai_Click(object sender, EventArgs e)
        {
            cbnmahd.Text = "";
            cbnmnv.Text = "";
            cbntenhang.Text = "";
            cbntenkhach.Text = "";
            ckbthoigian.Checked = false;
            ckbngay.Checked = false;
            txtbdau.Text= "";
            txtketthuc.Text = "";
            txtngay.Text = "";
            txtngay.Visible= false;
            txtbdau.Visible= false;
            txtketthuc.Visible= false;
            lbldau.Visible=false;
            lblketthuc.Visible=false;
           

        }
    }
}
