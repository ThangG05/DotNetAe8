using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Windows.Forms;
namespace Motobike.Mathang
{
    internal class In
    {
        public void GenerateCarInvoice(string tenkh, string sdt, string diachi,string tenxe, int  soluong, decimal price)
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
                Paragraph title = new Paragraph("HÓA ĐƠN MUA XE", titleFont);
                title.Alignment = Element.ALIGN_CENTER;
                doc.Add(title);

                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph(" "));


                doc.Add(new Paragraph($"Tên khách hàng: {tenkh}", titleFont));
                doc.Add(new Paragraph($"SĐT: {sdt}", titleFont));
                doc.Add(new Paragraph($"Địa chỉ: {diachi}", titleFont));
                doc.Add(new Paragraph($"Xe: {tenxe}", titleFont));

                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph(" "));


                PdfPTable table = new PdfPTable(3);
                table.WidthPercentage = 100;
                table.SetWidths(new float[] { 3, 1, 2 });

                table.AddCell(new Phrase("Sản phẩm", titleFont));
                table.AddCell(new Phrase("Số lượng", titleFont));
                table.AddCell(new Phrase("Thành tiền", titleFont));

                table.AddCell(tenxe);
                table.AddCell(soluong.ToString());
                table.AddCell(string.Format("{0:N0} VND", price));

                doc.Add(table);

                Paragraph total = new Paragraph($"Tổng tiền: {string.Format("{0:N0} VND", price)}", titleFont);
                total.Alignment = Element.ALIGN_RIGHT;
                doc.Add(total);

                doc.Add(new Paragraph($"Ngày: {DateTime.Now:dd/MM/yyyy HH:mm}", titleFont));

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
