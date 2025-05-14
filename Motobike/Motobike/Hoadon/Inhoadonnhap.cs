using System;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Motobike.Mathang
{
    internal class Inhoadonnhap
    {
        public void GenerateInvoice(
            string mahd,           
            string ngaynhap,      
            string manv,          
            string tennv,         
            string mahang,        
            string tenhang,
            string mancc,
            string tenncc,
            string diachi,
            string sdt,
            int soluong,         
            int giamgia,     
            int dongia,     
            int thanhtien,    
            int tongtien)         
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog.Title = "Chọn nơi lưu hóa đơn";
            saveFileDialog.FileName = $"HoaDon_{DateTime.Now:yyyyMMddHHmmss}.pdf";

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

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

                
                Paragraph title = new Paragraph("HÓA ĐƠN NHẬP HÀNG", titleFont);
                title.Alignment = Element.ALIGN_CENTER;
                doc.Add(title);
                doc.Add(new Paragraph(" ")); 

              
                doc.Add(new Paragraph("THÔNG TIN CHUNG", boldFont));
                doc.Add(new Paragraph($"Mã hóa đơn: {mahd}", normalFont));
                doc.Add(new Paragraph($"Ngày nhập hàng: {DateTime.Parse(ngaynhap):dd/MM/yyyy}", normalFont));
                doc.Add(new Paragraph($"Mã nhân viên: {manv}", normalFont));
                doc.Add(new Paragraph($"Tên nhân viên: {tennv}", normalFont));

                doc.Add(new Paragraph(" "));


                doc.Add(new Paragraph("THÔNG TIN NHÀ CUNG CẤP", boldFont));
                doc.Add(new Paragraph($"Mã nhà cung cấp: {mancc}", normalFont));
                doc.Add(new Paragraph($"Tên nhà cung cấp: {tenncc}", normalFont));
                doc.Add(new Paragraph($"Địa chỉ: {diachi}", normalFont));
                doc.Add(new Paragraph($"Số điện thoại: {sdt}", normalFont));


                doc.Add(new Paragraph(" ")); 

               
                doc.Add(new Paragraph("ThÔNG TIN MẶT HÀNG", boldFont));
                doc.Add(new Paragraph(" "));
                PdfPTable table = new PdfPTable(6);
                table.WidthPercentage = 100;
                table.SetWidths(new float[] { 1, 3, 2, 2, 2, 2 });

               
                table.AddCell(new Phrase("Mã hàng", boldFont));
                table.AddCell(new Phrase("Tên hàng", boldFont));
                table.AddCell(new Phrase("Số lượng", boldFont));
                table.AddCell(new Phrase("Giảm giá (%)", boldFont));
                table.AddCell(new Phrase("Đơn giá", boldFont));
                table.AddCell(new Phrase("Thành tiền", boldFont));

                
                table.AddCell(new Phrase(mahang, normalFont));
                table.AddCell(new Phrase(tenhang, normalFont));
                table.AddCell(new Phrase(soluong.ToString(), normalFont));
                table.AddCell(new Phrase(giamgia.ToString("N0"), normalFont));
                table.AddCell(new Phrase(dongia.ToString("N0"), normalFont));
                table.AddCell(new Phrase(thanhtien.ToString("N0"), normalFont));

                doc.Add(table);
                doc.Add(new Paragraph(" ")); 

               
                Paragraph total = new Paragraph($"TỔNG TIỀN: {tongtien.ToString("N0")} VND", titleFont);
                total.Alignment = Element.ALIGN_RIGHT;
                doc.Add(total);

                doc.Add(new Paragraph($"Ngày xuất: {DateTime.Now:dd/MM/yyyy HH:mm}", normalFont));

                MessageBox.Show($"Đã tạo hóa đơn thành công tại:\n{filePath}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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