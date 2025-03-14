
using System.Net;
using System.Net.Mail;
using ClosedXML.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;
using SeyirDefteri.Core.Classlar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace SeyirDefteri.UI
{
    public partial class Form3 : Form
    {
        private List<Gonderim> Gonderimler;
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(List<Gonderim> gonderimler) : this()
        {
            Gonderimler = gonderimler;
        }
        private void ListViewKolonEkle()
        {
            lvZRaporu.View = View.Details;
            lvZRaporu.GridLines = true;

            lvZRaporu.Columns.Add("Gemi Adı", 50, HorizontalAlignment.Center);
            lvZRaporu.Columns.Add("Limandan Çıkış Tarihi", 100, HorizontalAlignment.Center);
            lvZRaporu.Columns.Add("Limana Varıs Tarihi", 100, HorizontalAlignment.Center);
            lvZRaporu.Columns.Add("Ürün adı", 80, HorizontalAlignment.Center);
            lvZRaporu.Columns.Add("Firma Adı", 80, HorizontalAlignment.Center);
            lvZRaporu.Columns.Add("Ürün tonajı ", 80, HorizontalAlignment.Center);
            lvZRaporu.Columns.Add("Kalan Tonaj", 80, HorizontalAlignment.Center);
        }
        public void ListeyiGuncelle()
        {
            DateTime baslangicTarihi = dtpBaslangic.Value.Date;
            DateTime bitisTarihi = dtpBitis.Value.Date;

            var gemiBazliGonderim = Gonderimler.Where(g => g.SeyirKaydi.LimandanCikisTarihi.Date >= baslangicTarihi && g.SeyirKaydi.LimanaVarisTarihi.Date <= bitisTarihi).GroupBy(g => g.SeyirKaydi.Gemi.GemiAdi).ToList();
            lvZRaporu.Items.Clear();
            foreach (var grup in gemiBazliGonderim)
            {
                decimal gemiTonaji = grup.First().SeyirKaydi.Gemi?.Tonaji ?? 0;
                decimal toplamKullanilanTonaj = 0;

                foreach  (Gonderim gonderim in grup)
                {
                    toplamKullanilanTonaj += gonderim.Tonaj;
                   decimal kalanTonaj= gemiTonaji - toplamKullanilanTonaj;

                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = gonderim.SeyirKaydi.Gemi.GemiAdi;
                    listViewItem.SubItems.Add(gonderim.SeyirKaydi.LimandanCikisTarihi.Date.ToString("dd/MM/yyyy"));
                    listViewItem.SubItems.Add(gonderim.SeyirKaydi.LimanaVarisTarihi.Date.ToString("dd/MM/yyyy"));
                    listViewItem.SubItems.Add(gonderim.Urun.UrunAdi);
                    listViewItem.SubItems.Add(gonderim.IlgilenenKisi.BaglıOlduguFirma.FirmaAdi);
                    listViewItem.SubItems.Add(gonderim.Tonaj.ToString());

                    if (kalanTonaj >= 0)
                    {
                        listViewItem.SubItems.Add(kalanTonaj.ToString());
                    }
                    else
                    {
                        listViewItem.SubItems.Add("Gemi Tonajından Fazla Yük Yüklenmiştir");
                    }
                    lvZRaporu.Items.Add(listViewItem);
                }
            }
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            ListeyiGuncelle();
            ListViewKolonEkle();
        }
        private void dtpBaslangic_ValueChanged(object sender, EventArgs e)
        {
            ListeyiGuncelle();
        }
        private void dtpBitis_ValueChanged(object sender, EventArgs e)
        {
            ListeyiGuncelle();
        }
        private void btnExcelOlustur_Click(object sender, EventArgs e)
        {
            using (var workbook = new XLWorkbook())
            {
                var workSheet = workbook.AddWorksheet("ZRaporu");

                workSheet.Cell(1, 1).Value = "Gemi Adı";
                workSheet.Cell(1, 2).Value = "Limandan Çıkış Tarihi";
                workSheet.Cell(1, 3).Value = "Limana Varış Tarihi";
                workSheet.Cell(1, 4).Value = "ürün Adı";
                workSheet.Cell(1, 5).Value = "Firma Adı";
                workSheet.Cell(1, 6).Value = "Ürün Tonajı";
                workSheet.Cell(1, 7).Value = "Kalan Tonaj";
                int satir = 2;
                foreach (ListViewItem item in lvZRaporu.Items)
                {
                    workSheet.Cell(satir, 1).Value = item.SubItems[0].Text;
                    workSheet.Cell(satir, 2).Value = item.SubItems[1].Text;
                    workSheet.Cell(satir, 3).Value = item.SubItems[2].Text;
                    workSheet.Cell(satir, 4).Value = item.SubItems[3].Text;
                    workSheet.Cell(satir, 5).Value = item.SubItems[4].Text;
                    workSheet.Cell(satir, 6).Value = item.SubItems[5].Text;
                    workSheet.Cell(satir, 7).Value = item.SubItems[6].Text;
                    satir++;

                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "Exel Filtresi|*xls";
                        saveFileDialog.Title = "Excel Dosyasını Kaydet";
                        saveFileDialog.FileName = "ZRaporu.xls";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            string filePath = saveFileDialog.FileName;
                            workbook.SaveAs(filePath);
                            MessageBox.Show("Excel Başarıyla oluşturuldu ");
                        }
                    }
                }
            }

        }
        private void btnPdfOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Dosyası|*.pdf";
                saveFileDialog.Title = "PDF Dosyası Kaydet";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Document document = new Document();
                    //pdf dosyasını belirtilen dosya yolunda oluşturuluyor.
                    PdfWriter.GetInstance(document, new FileStream(saveFileDialog.FileName, FileMode.Create));
                    document.Open();
                    //pdf içindeki tablo oluşturup sütün sayısını paramtre olarak veriyoruz
                    PdfPTable table = new PdfPTable(lvZRaporu.Columns.Count);
                    table.WidthPercentage = 100;//tablo genişliği ayarlandı

                    //listview başlıklarını pdfye eklıyoruz
                    foreach (ColumnHeader column in lvZRaporu.Columns)
                    {
                        //başlık hücresini oluşturuyoruz içine başlıkları eklyıoruz
                        PdfPCell cell = new PdfPCell(new Phrase(column.Text));
                        cell.BackgroundColor = BaseColor.LIGHT_GRAY;//renk verşyoruz
                        table.AddCell(cell);//başlık hücresini eklıyoruz
                    }
                    //pdfye listviewlewri ekliyoruz
                    foreach (ListViewItem item in lvZRaporu.Items)
                    {
                        //her bir listviewıtemı alt öğrelerini hücrelere ekliyoruz
                        foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                        {
                            table.AddCell(subItem.Text);
                        }
                    }
                    //tabloyu pdf belgesine ekliyoruz
                    document.Add(table);
                    document.Close();

                    MessageBox.Show("PDF başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private void btnMailAt_Click(object sender, EventArgs e)
        {
            string excelDosyaYolu = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),"ZRaporu.xlsx");
            using(var workBook = new XLWorkbook())
            {
                var worksheet = workBook.Worksheets.Add("Gönderim ZRaporu");

                for (int col = 0; col < lvZRaporu.Items.Count; col++)
                {
                    worksheet.Cell(1, col + 1).Value = lvZRaporu.Columns[col].Text;
                }
                int row = 2;

                foreach (ListViewItem item in lvZRaporu.Items)
                {
                    for (int i = 0; i < item.SubItems.Count; i++)
                    {
                        worksheet.Cell(row, i + 1).Value = item.SubItems[i].Text;
                    }
                    row++;
                }
                workBook.SaveAs(excelDosyaYolu);
            }
            MailMessage mailMessage = new MailMessage();
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            mailMessage.From = new MailAddress("gönderen kişinin mail adresi");
            mailMessage.To.Add("alıcının mail adresi");
            mailMessage.Subject = "Gönderimin ZRaporu";
            mailMessage.Body = "Konunun içeriği";

            mailMessage.Attachments.Add(new Attachment(excelDosyaYolu));

            smtpClient.Port = 587;
            smtpClient.Credentials = new NetworkCredential("gönderenin maili","uygulama şifresi");

            smtpClient.EnableSsl = true;
            smtpClient.Send(mailMessage);
            MessageBox.Show("Eposta gönderildi");
        }
    }

}
