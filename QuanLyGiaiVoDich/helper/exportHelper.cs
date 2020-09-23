using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace QuanLyGiaiVoDich.helper
{
    class exportHelper
    {
        public static void exportToCSV(DataGridView gdv, string filename)
        {
            try
            {
                int columnCount = gdv.Columns.Count;
                string columnNames = "";
                string[] outputCsv = new string[gdv.Rows.Count + 1];
                for (int i = 0; i < columnCount; i++)
                {
                    columnNames += gdv.Columns[i].HeaderText.ToString() + ",";
                }
                outputCsv[0] = columnNames;

                for (int i = 1; (i - 1) < gdv.Rows.Count; i++)
                {
                    for (int j = 0; j < columnCount; j++)
                    {
                        outputCsv[i] += gdv.Rows[i - 1].Cells[j].Value.ToString() + ",";
                    }
                }

                File.WriteAllLines(filename, outputCsv, Encoding.UTF8);
                MessageBox.Show("Dữ liệu được xuất thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi xảy ra");
            }
        }

        public static void exportToPDF(DataGridView gdv, string filename)
        {
            try
            {
                Font fontNormal = FontFactory.GetFont(Environment.GetEnvironmentVariable("windir") + @"\Fonts\arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED, 12, Font.UNDEFINED, BaseColor.BLACK);
                PdfPTable pdfTable = new PdfPTable(gdv.Columns.Count);
                pdfTable.DefaultCell.Padding = 3;
                pdfTable.WidthPercentage = 100;
                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                foreach (DataGridViewColumn column in gdv.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, fontNormal) );
                    pdfTable.AddCell(cell);
                }

                foreach (DataGridViewRow row in gdv.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        pdfTable.AddCell(new PdfPCell(new Phrase(cell.Value.ToString(), fontNormal)));
                    }
                }

                using (FileStream stream = new FileStream(filename, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                    stream.Close();
                }

                MessageBox.Show("Dữ liệu được xuất thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi xảy ra");
            }
        }
    }
}
