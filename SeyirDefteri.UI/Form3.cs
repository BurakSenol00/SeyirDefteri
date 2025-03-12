using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using SeyirDefteri.Core.Classlar;

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
        decimal kalanTonaj;
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

            decimal toplamKullanilanTonaj = 0;
            decimal gemiTonajı = 0;

            foreach (Gonderim gonderim in Gonderimler)
            {
                DateTime limandanCikisTarihi = gonderim.SeyirKaydi.LimandanCikisTarihi.Date;
                DateTime limanaVarisTarihi = gonderim.SeyirKaydi.LimanaVarisTarihi.Date;
                if (limandanCikisTarihi >= baslangicTarihi && limanaVarisTarihi <= bitisTarihi)
                {
                    if (gemiTonajı <= 0)
                    {
                        gemiTonajı = gonderim.SeyirKaydi.Gemi.Tonaji;
                    }
                    toplamKullanilanTonaj += gonderim.Tonaj;
                    kalanTonaj = gemiTonajı - toplamKullanilanTonaj;

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
            //DateTime baslangicTarihi = dtpBaslangic.Value.Date;
            //DateTime bitisTarihi = dtpBitis.Value.Date;
            //ListeyiGuncelle(baslangicTarihi, bitisTarihi);

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
    }

}
