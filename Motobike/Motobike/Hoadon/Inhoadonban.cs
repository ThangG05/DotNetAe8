using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Motobike.Hoadon
{
    internal class Inhoadonban
    {
        public void GenerateInvoiceBan(List<Hoadon.HoadonbanCT> danhSachCT,string Kq)
        {
            if (danhSachCT == null || danhSachCT.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để in hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var thongtin = danhSachCT[0];

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog.Title = "Chọn nơi lưu hóa đơn";
            saveFileDialog.FileName = $"HoaDonBan_{DateTime.Now:yyyyMMddHHmmss}.pdf";

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            string filePath = saveFileDialog.FileName;
            Document doc = new Document(PageSize.A4, 20, 20, 30, 30);

            try
            {
                PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
                doc.Open();

                string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "times.ttf");
                BaseFont baseFont = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                Font titleFont = new Font(baseFont, 18, Font.BOLD);
                Font normalFont = new Font(baseFont, 12, Font.NORMAL);
                Font boldFont = new Font(baseFont, 12, Font.BOLD);

                Paragraph title = new Paragraph("HÓA ĐƠN BÁN HÀNG", titleFont);
                title.Alignment = Element.ALIGN_CENTER;
                doc.Add(title);
                doc.Add(new Paragraph(" "));

                doc.Add(new Paragraph("THÔNG TIN CHUNG", boldFont));
                doc.Add(new Paragraph($"Mã hóa đơn: {thongtin.SoDDH}", normalFont));
                doc.Add(new Paragraph($"Ngày bán: {DateTime.Parse(thongtin.NgayMua):dd/MM/yyyy}", normalFont));
                doc.Add(new Paragraph($"Mã nhân viên: {thongtin.MaNV}", normalFont));
                doc.Add(new Paragraph($"Tên nhân viên: {thongtin.TenNV}", normalFont));

                doc.Add(new Paragraph(" "));

                doc.Add(new Paragraph("THÔNG TIN KHÁCH HÀNG", boldFont));
                doc.Add(new Paragraph($"Mã khách hàng: {thongtin.MaKH}", normalFont));
                doc.Add(new Paragraph($"Tên khách hàng: {thongtin.TenKH}", normalFont));
                doc.Add(new Paragraph($"Địa chỉ: {thongtin.Diachi}", normalFont));
                doc.Add(new Paragraph($"Số điện thoại: {thongtin.SDT}", normalFont));

                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph("THÔNG TIN MẶT HÀNG", boldFont));
                doc.Add(new Paragraph(" "));

                PdfPTable table = new PdfPTable(7);
                table.WidthPercentage = 100;
                table.SetWidths(new float[] { 2, 3, 2, 2, 2, 2, 2 });

                table.AddCell(new Phrase("Mã hàng", boldFont));
                table.AddCell(new Phrase("Tên hàng", boldFont));
                table.AddCell(new Phrase("Số lượng", boldFont));
                table.AddCell(new Phrase("Giảm giá (%)", boldFont));
                table.AddCell(new Phrase("Đơn giá", boldFont));
                table.AddCell(new Phrase("Thuế (%)", boldFont));
                table.AddCell(new Phrase("Thành tiền", boldFont));

                int tongTien = 0;

                foreach (var ct in danhSachCT)
                {
                    int soluong = int.Parse(ct.SoLuong);
                    int dongia = int.Parse(ct.GiaBan);
                    int giamgia = int.Parse(ct.GiamGia);
                    int thue = int.Parse(ct.Thue);
                    int tamtinh = soluong * dongia;
                    int thanhtien = tamtinh - (tamtinh * giamgia / 100) + (tamtinh * thue / 100);

                    tongTien += thanhtien;

                    table.AddCell(new Phrase(ct.MaHang, normalFont));
                    table.AddCell(new Phrase(ct.TenHang, normalFont));
                    table.AddCell(new Phrase(soluong.ToString(), normalFont));
                    table.AddCell(new Phrase(giamgia.ToString(), normalFont));
                    table.AddCell(new Phrase(dongia.ToString("N0"), normalFont));
                    table.AddCell(new Phrase(thue.ToString(), normalFont));
                    table.AddCell(new Phrase(thanhtien.ToString("N0"), normalFont));
                }

                doc.Add(table);
                doc.Add(new Paragraph(" "));

                Paragraph total = new Paragraph($"TỔNG TIỀN: {tongTien.ToString("N0")} VND", titleFont);
                total.Alignment = Element.ALIGN_RIGHT;
                doc.Add(total);
                doc.Add(new Paragraph(" "));

                if (!string.IsNullOrWhiteSpace(Kq))
                {
                    doc.Add(new Paragraph(" ", normalFont));
                    Paragraph ketQua = new Paragraph($"🎉 KẾT QUẢ TRÚNG THƯỞNG: {Kq}", boldFont);
                    ketQua.Alignment = Element.ALIGN_CENTER;
                    ketQua.SpacingBefore = 10f;
                    ketQua.SpacingAfter = 10f;
                    doc.Add(ketQua);
                }
                doc.Add(new Paragraph($"Ngày xuất: {DateTime.Now:dd/MM/yyyy HH:mm}", normalFont));

                MessageBox.Show($"Đã tạo hóa đơn bán hàng thành công tại:\n{filePath}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tạo PDF: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                doc.Close();
            }
        }

    }
}
