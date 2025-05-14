using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using iTextSharp.text.pdf.codec;


namespace Motobike.Baocao
{
    public partial class Baocaohoatdongkinhdoanh : Form
    {
        public Baocaohoatdongkinhdoanh()
        {
            InitializeComponent();
        }

        private void Baocaohoatdongkinhdoanh_Load(object sender, EventArgs e)
        {
            txtbdau.Visible = false;
            txtketthuc.Visible = false;
            txtMM.Visible = false;
            txtYYYY.Visible = false;
            lbldau.Visible = false;
            lblden.Visible = false;
            lblMM.Visible = false;
            lblYYYY.Visible = false;
        }
       private void ChartColum(string tencot)
       {
            Chartbaocao.Series.Clear();

            Series series = new Series("Số lượng bán");
            series.ChartType = SeriesChartType.Column;

            foreach (DataGridViewRow row in dgvban.Rows)
            {
                if (row.Cells[tencot].Value != null && row.Cells["SoLuong"].Value != null)
                {
                    string tenHang = row.Cells[tencot].Value.ToString();
                    int soLuong = int.Parse(row.Cells["SoLuong"].Value.ToString());

                    series.Points.AddXY(tenHang, soLuong);
                }
            }
            Chartbaocao.Series.Add(series);

       }
        private void buttimkiem_Click(object sender, EventArgs e)
        {
            if (rdotenhang.Checked && rdoMMYYYY.Checked)
            {
                SqlConnection conn = null;
                CONECT.KetNoiXE ketNoi = new CONECT.KetNoiXE();
                conn = ketNoi.CON();

                try
                {
                    string query = @"SELECT TOP 3
                            h.TenHang,
                            ddh.NgayMua,
                             SUM(ct.SoLuong) AS SoLuong
                        FROM CTDonDatHang ct
                        JOIN DMHang h ON ct.MaHang = h.MaHang
                        JOIN DonDatHang ddh ON ct.SoDDH = ddh.SoDDH
                        WHERE MONTH(ddh.NgayMua) = @Thang AND YEAR(ddh.NgayMua) = @Nam
                        GROUP BY h.TenHang, ddh.NgayMua
                        ORDER BY ddh.NgayMua, SoLuong DESC";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Thang", int.Parse(txtMM.Text));
                    cmd.Parameters.AddWithValue("@Nam", int.Parse(txtYYYY.Text));

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvban.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
                finally
                {
                    if (conn != null && conn.State == ConnectionState.Open)
                        conn.Close();
                }
                ChartColum("TenHang");
                return;
            }
            if (rdotenhang.Checked && rdothoigian.Checked)
            {
                SqlConnection conn = null;
                CONECT.KetNoiXE ketNoi = new CONECT.KetNoiXE();
                conn = ketNoi.CON();

                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"
                                        SELECT 
                                            h.TenHang,
                                            ddh.NgayMua,
                                            ct.SoLuong
                                        FROM CTDonDatHang ct
                                        JOIN DMHang h ON ct.MaHang = h.MaHang
                                        JOIN DonDatHang ddh ON ct.SoDDH = ddh.SoDDH
                                        WHERE ddh.NgayMua BETWEEN @NgayBatDau AND @NgayKetThuc
                                          AND h.MaHang IN (
                                              SELECT TOP 3 h.MaHang
                                              FROM CTDonDatHang ct
                                              JOIN DMHang h ON ct.MaHang = h.MaHang
                                              JOIN DonDatHang ddh ON ct.SoDDH = ddh.SoDDH
                                              WHERE ddh.NgayMua BETWEEN @NgayBatDau AND @NgayKetThuc
                                              GROUP BY h.MaHang
                                              ORDER BY SUM(ct.SoLuong)  DESC
                                          )
                                        ORDER BY h.TenHang, ddh.NgayMua;
                                    ";

                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@NgayBatDau", DateTime.Parse(txtbdau.Text));
                    cmd.Parameters.AddWithValue("@NgayKetThuc", DateTime.Parse(txtketthuc.Text));

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvban.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
                finally
                {
                    if (conn != null && conn.State == ConnectionState.Open)
                        conn.Close();
                }
                ChartColum("TenHang");
                return;
            }
            if (rdotenhangx.Checked && rdoMMYYYY.Checked)
            {
                SqlConnection conn = null;
                CONECT.KetNoiXE ketNoi = new CONECT.KetNoiXE();
                conn = ketNoi.CON();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"
                                SELECT 
                                    hs.TenHangSX,
                                    ddh.NgayMua,
                                    ct.SoLuong
                                FROM CTDonDatHang ct
                                JOIN DMHang h ON ct.MaHang = h.MaHang
                                JOIN HangSX hs ON h.MaHangSX = hs.MaHangSX
                                JOIN DonDatHang ddh ON ct.SoDDH = ddh.SoDDH
                                WHERE MONTH(ddh.NgayMua) = @Thang 
                                  AND YEAR(ddh.NgayMua) = @Nam
                                  AND hs.TenHangSX IN (
                                      SELECT TOP 3 hs.TenHangSX
                                      FROM CTDonDatHang ct
                                      JOIN DMHang h ON ct.MaHang = h.MaHang
                                      JOIN DonDatHang ddh ON ct.SoDDH = ddh.SoDDH
                                      JOIN HangSX hs ON h.MaHangSX = hs.MaHangSX
                                      WHERE MONTH(ddh.NgayMua) = @Thang 
                                        AND YEAR(ddh.NgayMua) = @Nam
                                      GROUP BY hs.TenHangSX
                                      ORDER BY SUM(ct.SoLuong) DESC
                                  )
                                ORDER BY hs.TenHangSX, ddh.NgayMua;
                            ";

                cmd.Parameters.AddWithValue("@Thang", int.Parse(txtMM.Text));
                cmd.Parameters.AddWithValue("@Nam", int.Parse(txtYYYY.Text));

                cmd.Connection = conn;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvban.DataSource = dt;
                ChartColum("TenHangSX");
                return;
            }
            if (rdotenhangx.Checked && rdothoigian.Checked)  
            {
                SqlConnection conn = null;
                CONECT.KetNoiXE ketNoi = new CONECT.KetNoiXE();
                conn = ketNoi.CON();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"
                                    SELECT 
                                        hs.TenHangSX,
                                        ddh.NgayMua,
                                        ct.SoLuong
                                    FROM CTDonDatHang ct
                                    JOIN DMHang h ON ct.MaHang = h.MaHang
                                    JOIN HangSX hs ON h.MaHangSX = hs.MaHangSX
                                    JOIN DonDatHang ddh ON ct.SoDDH = ddh.SoDDH
                                    WHERE ddh.NgayMua BETWEEN @NgayBatDau AND @NgayKetThuc
                                      AND hs.TenHangSX IN (
                                          SELECT TOP 3 hs.TenHangSX
                                          FROM CTDonDatHang ct
                                          JOIN DMHang h ON ct.MaHang = h.MaHang
                                          JOIN DonDatHang ddh ON ct.SoDDH = ddh.SoDDH
                                          JOIN HangSX hs ON h.MaHangSX = hs.MaHangSX
                                          WHERE ddh.NgayMua BETWEEN @NgayBatDau AND @NgayKetThuc
                                          GROUP BY hs.TenHangSX
                                          ORDER BY SUM(ct.SoLuong)  DESC
                                      )
                                    ORDER BY hs.TenHangSX, ddh.NgayMua;
                                ";

                cmd.Parameters.AddWithValue("@NgayBatDau", DateTime.Parse(txtbdau.Text));
                cmd.Parameters.AddWithValue("@NgayKetThuc", DateTime.Parse(txtketthuc.Text));

                cmd.Connection = conn;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvban.DataSource = dt;
                ChartColum("TenHangSX");
                return;
            }
        }

        private void buttimlai_Click(object sender, EventArgs e)
        {
            rdoMMYYYY.Checked = false;
            rdotenhang.Checked = false;
            rdotenhangx.Checked = false;
            rdothoigian.Checked = false;
            txtbdau.Text = "";
            txtketthuc.Text = "";
            txtMM.Text = "";
            txtYYYY.Text = "";
            dgvban.DataSource = null;
            Chartbaocao.Series.Clear();
            txtbdau.Visible = false;
            txtketthuc.Visible = false;
            txtMM.Visible = false;
            txtYYYY.Visible = false;
            lbldau.Visible = false;
            lblden.Visible = false;
            lblMM.Visible = false;
            lblYYYY.Visible = false;

        }
        private void ExportExcel(string path)
        {
            Excel.Application app = new Excel.Application();
            Excel.Workbook wb = app.Workbooks.Add(Type.Missing);
            Excel.Worksheet ws = (Excel.Worksheet)wb.Sheets[1];
            ws.Name = "Biểu đồ";

            // Thêm thông tin khoảng thời gian
            ws.Cells[1, 1] = "Biểu đồ bán hàng";
            ws.Cells[2, 1] = "Khoảng thời gian";
            if (rdoMMYYYY.Checked)
            {
                ws.Cells[2, 2] = $"Tháng: {txtMM.Text.ToString()}";
                ws.Cells[3, 2] = $"Năm: {txtYYYY.Text.ToString()}";
            }
            if (rdothoigian.Checked)
            {
                ws.Cells[2, 2] = $"Từ: {txtbdau.Text.ToString()}";
                ws.Cells[3, 2] = $"Đến: {txtketthuc.Text.ToString()}";
            }
            

            // Tổng hợp số lượng theo tên hàng
            Dictionary<string, int> thongKe = new Dictionary<string, int>();
            if (rdotenhang.Checked)
            {
                foreach (DataGridViewRow Row in dgvban.Rows)
                {
                    if (Row.IsNewRow) continue;

                    string tenHang = Row.Cells["TenHang"].Value?.ToString() ?? "";
                    int soLuong = Convert.ToInt32(Row.Cells["SoLuong"].Value ?? 0);

                    if (thongKe.ContainsKey(tenHang))
                        thongKe[tenHang] += soLuong;
                    else
                        thongKe[tenHang] = soLuong;
                }
            }
            if (rdotenhangx.Checked)
            {
                foreach (DataGridViewRow Row in dgvban.Rows)
                {
                    if (Row.IsNewRow) continue;

                    string tenHang = Row.Cells["TenHangSX"].Value?.ToString() ?? "";
                    int soLuong = Convert.ToInt32(Row.Cells["SoLuong"].Value ?? 0);

                    if (thongKe.ContainsKey(tenHang))
                        thongKe[tenHang] += soLuong;
                    else
                        thongKe[tenHang] = soLuong;
                }
            }
            

            // Ghi dữ liệu đơn giản - bắt đầu từ dòng 5 để dành chỗ cho tiêu đề và thời gian
            ws.Cells[5, 1] = "Tên hàng";
            ws.Cells[5, 2] = "Số lượng";
            int row = 6;
            foreach (var item in thongKe)
            {
                ws.Cells[row, 1] = item.Key;
                ws.Cells[row, 2] = item.Value;
                row++;
            }

            // Tạo biểu đồ
            Excel.Range dataRange = ws.Range["A5:B" + (row - 1)];
            Excel.ChartObjects charts = (Excel.ChartObjects)ws.ChartObjects();
            Excel.ChartObject chartObject = charts.Add(300, 100, 500, 300); // Điều chỉnh vị trí biểu đồ
            Excel.Chart chart = chartObject.Chart;
            chart.SetSourceData(dataRange);
            chart.ChartType = Excel.XlChartType.xlColumnClustered;

            chart.HasTitle = true;
            if (rdothoigian.Checked)
            {
                chart.ChartTitle.Text = $"Biểu đồ bán hàng từ {txtbdau.Text.ToString()} đến {txtketthuc.Text.ToString()}";
            }
            if (rdoMMYYYY.Checked)
            {
                chart.ChartTitle.Text = $"Biểu đồ bán hàng Tháng {txtMM.Text.ToString()} Năm {txtYYYY.Text.ToString()}";
            }
           
            chart.Axes(Excel.XlAxisType.xlCategory).HasTitle = false;
            chart.Axes(Excel.XlAxisType.xlValue).HasTitle = true;
            chart.Axes(Excel.XlAxisType.xlValue).AxisTitle.Text = "Số lượng bán";
            chart.HasLegend = false;

            // Căn chỉnh đẹp
            ws.Columns.AutoFit();
            ws.Range["A5:B5"].Font.Bold = true;
            ws.Range["A1:A3"].Font.Bold = true;

            // Tùy chọn: ẩn lưới Excel để biểu đồ nổi bật hơn
            ws.Application.ActiveWindow.DisplayGridlines = false;

            // Lưu và thoát
            wb.SaveAs(path);
            wb.Close(false);
            app.Quit();

            Marshal.ReleaseComObject(ws);
            Marshal.ReleaseComObject(wb);
            Marshal.ReleaseComObject(app);
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }


        private void butin_Click(object sender, EventArgs e)
        {
            if (dgvban.Rows.Count == 0 || dgvban.Rows.Cast<DataGridViewRow>().All(r => r.IsNewRow))
            {
                MessageBox.Show("Không có dữ liệu để in!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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

        private void rdoMMYYYY_CheckedChanged(object sender, EventArgs e)
        {
            lblYYYY.Visible = true;
            lblMM.Visible = true;
            txtMM.Visible = true;
            txtYYYY.Visible = true;
            txtbdau.Visible = false;
            txtketthuc.Visible = false;
            lbldau.Visible = false;
            lblden.Visible = false;

        }

        private void rdothoigian_CheckedChanged(object sender, EventArgs e)
        {
            lbldau.Visible = true;
            lblden.Visible = true;
            txtbdau.Visible = true;
            txtketthuc.Visible = true;
            txtMM.Visible = false;
            txtYYYY.Visible = false;
            lblMM.Visible = false;
            lblYYYY.Visible = false;
        }
    }
}
