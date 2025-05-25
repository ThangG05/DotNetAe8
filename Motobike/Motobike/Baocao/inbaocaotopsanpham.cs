using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Motobike.Baocao
{
    internal class inbaocaotopsanpham
    {
        public void Inbaocao(string ngaybatdau, string ngayketthuc, int doanhthu, int chitieu, int loinhuan)

        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog.Title = "Chọn nơi lưu hóa đơn";
            saveFileDialog.FileName = $"Baocao_{DateTime.Now:yyyyMMddHHmmss}.pdf";

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


                Paragraph title = new Paragraph("BÁO CÁO HOẠT ĐÔNG KINH DOANH", titleFont);
                title.Alignment = Element.ALIGN_CENTER;
                doc.Add(title);
                doc.Add(new Paragraph(" "));


                doc.Add(new Paragraph("Thời gian thống kê hoạt động kinh doanh", boldFont));
                doc.Add(new Paragraph($"Thời gian bắt đầu: {DateTime.Parse(ngaybatdau):dd/MM/yyyy}", normalFont));
                doc.Add(new Paragraph($"Thời gian kết thúc: {DateTime.Parse(ngayketthuc):dd/MM/yyyy}", normalFont));

                doc.Add(new Paragraph(" "));

                doc.Add(new Paragraph("Thống kê", boldFont));
                doc.Add(new Paragraph(" "));
                PdfPTable table = new PdfPTable(3);
                table.WidthPercentage = 100;
                table.SetWidths(new float[] { 3, 3, 3 });


                table.AddCell(new Phrase("Tổng doanh thu", boldFont));
                table.AddCell(new Phrase("Tổng đầu tư", boldFont));
                table.AddCell(new Phrase("Lợi nhuận", boldFont));


                table.AddCell(new Phrase(doanhthu.ToString("#,##0đ").Replace(",", "."), normalFont));
                table.AddCell(new Phrase(chitieu.ToString("#,##0đ").Replace(",", "."), normalFont));
                table.AddCell(new Phrase(loinhuan.ToString("#,##0đ").Replace(",", "."), normalFont));

                doc.Add(table);
                doc.Add(new Paragraph(" "));

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
