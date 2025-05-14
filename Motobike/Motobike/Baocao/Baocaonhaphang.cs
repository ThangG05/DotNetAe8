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
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Globalization;
namespace Motobike.Baocao
{
    public partial class Baocaonhaphang : Form
    {
        public Baocaonhaphang()
        {
            InitializeComponent();
        }
        public void NapMaHD()
        {
            SqlCommand cmd = null;
            CONECT.FillData fillData = new CONECT.FillData();
            cmd = fillData.FillMaHD(cmd);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbnmahd.Items.Add(reader["SoHDN"].ToString());
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
        public void NapTenNCC()
        {
            SqlCommand cmd = null;
            CONECT.FillData fillData = new CONECT.FillData();
            cmd = fillData.FillTenNCC (cmd);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbnncc.Items.Add(reader["TenNCC"].ToString());
            }
            reader.Close();
        }
        private void Baocaonhaphang_Load(object sender, EventArgs e)
        {
            NapMaHD();
            NapManv();
            NapTenHang();
            NapTenNCC();
            An();
        }
        private void An()
        {
            txtbdau.Visible = false;
            txtketthuc.Visible = false;
            txtngay.Visible = false;
            lblbdau.Visible = false;
            lblketthuc.Visible = false;
        }
        private void ckbngay_CheckedChanged(object sender, EventArgs e)
        {
            txtngay.Visible = true;
        }
      
        private void ckbthoigian_CheckedChanged_1(object sender, EventArgs e)
        {
            txtbdau.Visible = true;
            txtketthuc.Visible = true;
            lblbdau.Visible = true;
            lblketthuc.Visible = true;
        }

        private void btntimlai_Click_1(object sender, EventArgs e)
        {
            cbnmahd.Text = "";
            cbnmnv.Text = "";
            cbntenhang.Text = "";
            cbnncc.Text = "";
            ckbthoigian.Checked = false;
            ckbngay.Checked = false;
            txtbdau.Text = "";
            txtketthuc.Text = "";
            txtngay.Text = "";
            txtngay.Visible = false;
            txtbdau.Visible = false;
            txtketthuc.Visible = false;
            lblbdau.Visible = false;
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
                                HoaDonNhap_New.SoHDN,
                                HoaDonNhap_New.NgayNhap,
                                NhanVien.TenNV,
                                NhaCungCap.TenNCC,
                                DMHang.TenHang,
	                            CTHoaDonNhap.SoLuong,
	                            CTHoaDonNhap.DonGia,
	                            CTHoaDonNhap.GiamGia,
                                HoaDonNhap_New.TongTien
                            FROM HoaDonNhap_New
                            JOIN NhanVien ON HoaDonNhap_New.MaNV = NhanVien.MaNV
                            JOIN NhaCungCap ON HoaDonNhap_New.MaNCC = NhaCungCap.MaNCC
                            JOIN CTHoaDonNhap ON HoaDonNhap_New.SoHDN = CTHoaDonNhap.SoHDN
                            JOIN DMHang ON CTHoaDonNhap.MaHang = DMHang.MaHang
                            where "+Tenbang+"."+Tencot+"=N'"+value+"'";
            cmd.Connection = conn;
            List<Hoadonnhap> ds = new List<Hoadonnhap>();
            Hoadonnhap hd;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int sohd = reader.GetInt32(0);
                DateTime ngay = reader.GetDateTime(1);
                string Tennv = reader.GetString(2);
                string tenncc = reader.GetString(3);
                string tenh = reader.GetString(4);
                int Slg = reader.GetInt32(5);
                int dongia=reader.GetInt32(6);
                int giamgia=reader.GetInt32(7);
                int tongtien = reader.GetInt32(8);
                hd = new Hoadonnhap() {SoHDN=sohd,NgayNhap=ngay,TenNV=Tennv,TenNCC=tenncc,TenHang=tenh,SoLuong=Slg,
                DonGia=dongia,GiamGia=giamgia,TongTien=tongtien};
                ds.Add(hd);
            }
            dgvhoadonnhap.DataSource = ds;
            reader.Close();
        }
        private void btntimkiem_Click(object sender, EventArgs e)
        {
            if (cbnmahd.Text != "")
            {
                hienthi("HoaDonNhap_New", "SoHDN", cbnmahd.Text);
                return;
            }
            if (cbnmnv.Text != "")
            {
                hienthi("NhanVien", "MaNV", cbnmnv.Text);
                return;
            }
            if (cbntenhang.Text != "")
            {
                hienthi("DMHang", "TenHang", cbntenhang.Text);
                return;
            }
            if (cbnncc.Text != "")
            {
                hienthi("NhaCungCap", "TenNCC", cbnncc.Text);
                return;
            }
            if (ckbngay.Checked)
            {
                string input = txtngay.Text;
                DateTime ngayChon;

                if (DateTime.TryParseExact(input, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngayChon))
                {
                    string ngayFormatSQL = ngayChon.ToString("yyyy-MM-dd");
                    hienthi("HoaDonNhap_New", "NgayNhap", ngayFormatSQL);
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
                cmd.CommandText = @"SELECT 
                                    HoaDonNhap_New.SoHDN,
                                    HoaDonNhap_New.NgayNhap,
                                    NhanVien.TenNV,
                                    NhaCungCap.TenNCC,
                                    DMHang.TenHang,
	                                CTHoaDonNhap.SoLuong,
	                                CTHoaDonNhap.DonGia,
	                                CTHoaDonNhap.GiamGia,
                                    HoaDonNhap_New.TongTien
                                FROM HoaDonNhap_New
                                JOIN NhanVien ON HoaDonNhap_New.MaNV = NhanVien.MaNV
                                JOIN NhaCungCap ON HoaDonNhap_New.MaNCC = NhaCungCap.MaNCC
                                JOIN CTHoaDonNhap ON HoaDonNhap_New.SoHDN = CTHoaDonNhap.SoHDN
                                JOIN DMHang ON CTHoaDonNhap.MaHang = DMHang.MaHang
                                WHERE HoaDonNhap_New.NgayNhap BETWEEN @bdau AND @kthuc";
                                   
                cmd.Parameters.AddWithValue("@bdau", ngayChon.Date);
                cmd.Parameters.AddWithValue("@kthuc", ngayChon2.Date);
                cmd.Connection = conn;
                List<Hoadonnhap> ds = new List<Hoadonnhap>();
                Hoadonnhap hd;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int sohd = reader.GetInt32(0);
                    DateTime ngay = reader.GetDateTime(1);
                    string Tennv = reader.GetString(2);
                    string tenncc = reader.GetString(3);
                    string tenh = reader.GetString(4);
                    int Slg = reader.GetInt32(5);
                    int dongia = reader.GetInt32(6);
                    int giamgia = reader.GetInt32(7);
                    int tongtien = reader.GetInt32(8);
                    hd = new Hoadonnhap()
                    {
                        SoHDN = sohd,
                        NgayNhap = ngay,
                        TenNV = Tennv,
                        TenNCC = tenncc,
                        TenHang = tenh,
                        SoLuong = Slg,
                        DonGia = dongia,
                        GiamGia = giamgia,
                        TongTien = tongtien
                    };
                    ds.Add(hd);
                }
                dgvhoadonnhap.DataSource = ds;
                reader.Close();
                return;
            }
        }
        private void ExportExcel(string path)
        {
            Excel.Application app = new Excel.Application();
            Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];
            worksheet.Name = "Báo cáo";

            // Header
            for (int i = 0; i < dgvhoadonnhap.Columns.Count; i++)
            {
                Excel.Range headerCell = (Excel.Range)worksheet.Cells[1, i + 1];
                headerCell.Value = dgvhoadonnhap.Columns[i].HeaderText;
                headerCell.Font.Bold = true;
                headerCell.Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.LightGray);
                headerCell.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                headerCell.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            }

            // Data
            for (int i = 0; i < dgvhoadonnhap.Rows.Count; i++)
            {
                for (int j = 0; j < dgvhoadonnhap.Columns.Count; j++)
                {
                    var cell = (Excel.Range)worksheet.Cells[i + 2, j + 1];
                    cell.Value = dgvhoadonnhap.Rows[i].Cells[j].Value;
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
            if (save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExcel(save.FileName);
                    MessageBox.Show("Xuất file thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất file thấy bại" + ex.Message);
                }
            }
        }
    }
}
