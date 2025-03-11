using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SeyirDefteri.Core.Classlar;

namespace SeyirDefteri.UI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(List<SeyirKaydi> seyirkayitlari) : this()
        {
            foreach (var seyir in seyirkayitlari)
            {
               
                cmbSeferler.Items.Add(seyir);
            }
        }
        public void FirmalarıEkle()
        {
            List<Firma> firmaListesi = new List<Firma>()
            {
                new Firma { FirmaId = 1, FirmaAdi = "Blue Wave Shipping" },
                new Firma { FirmaId = 2, FirmaAdi = "Golden Anchor Maritime"},
                new Firma { FirmaId = 3, FirmaAdi = "Istanbul Marine Logistics" },
                new Firma { FirmaId = 4, FirmaAdi = "Anadolu Denizcilik" },
                new Firma { FirmaId = 5, FirmaAdi = "Black Sea Shipping Co." },
                new Firma { FirmaId = 6, FirmaAdi = "Mavi Yelken Taşımacılık" },
                new Firma { FirmaId = 8, FirmaAdi = "Orion Maritime" },
                new Firma { FirmaId = 9, FirmaAdi = "Turkish Ocean Lines" },
                new Firma { FirmaId = 10, FirmaAdi = "Ege Trans Shipping" },
                new Firma { FirmaId = 11, FirmaAdi = "İzmir Deniz Taşımacılığı" },
                new Firma { FirmaId = 12, FirmaAdi = "Akdeniz Lojistik" },
                new Firma { FirmaId = 13, FirmaAdi = "Mersin Blue Line Shipping" },
                new Firma { FirmaId = 14, FirmaAdi = "Bodrum Yacht Transport" },
                new Firma { FirmaId = 15, FirmaAdi = "Fethiye Cargo Lines" },
                new Firma { FirmaId = 16, FirmaAdi = "Trabzon Karadeniz Shipping" },
                new Firma { FirmaId = 17, FirmaAdi = "Black Pearl Shipping" },
                new Firma { FirmaId = 18, FirmaAdi = "Piraeus Blue Star Shipping" },
                new Firma { FirmaId = 19, FirmaAdi = "Aegean Sea Logistics" },
                new Firma { FirmaId = 20, FirmaAdi = "Thessaloniki Cargo & Maritime" },
                new Firma { FirmaId = 21, FirmaAdi = "Crete Ocean Shipping" },
                new Firma { FirmaId = 22, FirmaAdi = "Naples Mediterranean Lines" },
                new Firma { FirmaId = 23, FirmaAdi = "Genoa Ocean Freight" },
                new Firma { FirmaId = 24, FirmaAdi = "Venice Cruise & Cargo" },
                new Firma { FirmaId = 25, FirmaAdi = "Livorno Maritime Solutions" },
                new Firma { FirmaId = 26, FirmaAdi = "Civitavecchia Sea Lines" } ,
                new Firma { FirmaId = 27, FirmaAdi = "Marseille Horizon Shipping" },
                new Firma { FirmaId = 28, FirmaAdi = "Le Havre Atlantic Logistics" },
                new Firma { FirmaId = 29, FirmaAdi = "Monaco Royal Shipping" },
                new Firma { FirmaId = 30, FirmaAdi = "Nice Mediterranean Cargo" }
            };
            foreach (var firma in firmaListesi)
            {
                cmbFirma.Items.Add(firma);
            }

        }
        private void Temizle()
        {
            cmbSeferler.SelectedItem = null;
            txtUrun.Text = string.Empty;
            txtKisi.Text = string.Empty;
            msdTelefon.Text = null;
            cmbFirma.SelectedItem = null;
            nupTonaj.Value = 0;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            FirmalarıEkle();
            ListviewSutunEkle();
            

        }
        int id = 1;
        int ilgiliKisiId = 0;
        int urunId = 1;
        private Gemi seciliGemi;
        private void ListviewSutunEkle()
        {
            lvGonderim.View = View.Details;
            lvGonderim.GridLines = true;

            lvGonderim.Columns.Add("ID", 50, HorizontalAlignment.Center);
            lvGonderim.Columns.Add("Tonaj ", 100, HorizontalAlignment.Center);
            lvGonderim.Columns.Add("Ürün ", 100, HorizontalAlignment.Center);
            lvGonderim.Columns.Add("Firma ", 150, HorizontalAlignment.Center);
            lvGonderim.Columns.Add("Kişi Adı", 150, HorizontalAlignment.Center);
            lvGonderim.Columns.Add("İletişim", 150, HorizontalAlignment.Center);
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            if (cmbSeferler.SelectedItem == null)
            {
                MessageBox.Show("Lütfen sefer seçin");
                return;
            }
            if (cmbFirma.SelectedItem == null)
            {
                MessageBox.Show("Lütfen firma seçin");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtUrun.Text))
            {
                MessageBox.Show("Ürün adı Boş olamaz");
                return;
            }

            SeyirKaydi seciliSeyir = cmbSeferler.SelectedItem as SeyirKaydi;

            if (seciliSeyir == null)
            {
                MessageBox.Show("Geçerli bir sefer seçilmedi yada gemi bilgisi eksik");
                return;
            }

            seciliGemi = seciliSeyir.Gemi;

            if (nupTonaj.Value < 0 || seciliGemi.Tonaji < nupTonaj.Value)
            {
                MessageBox.Show("Geminin tonajı büyük bir giremez");
                return;
            }
            Gonderim gonderim = new Gonderim();

            gonderim.SeyirKaydi = cmbSeferler.SelectedItem as SeyirKaydi;

            gonderim.Urun = new Urun();
            gonderim.Urun.UrunId = urunId++;
            gonderim.Urun.UrunAdi = txtUrun.Text;
            gonderim.Tonaj = nupTonaj.Value;

            gonderim.IlgilenenKisi = new IlgilenenKisi();
            gonderim.IlgilenenKisi.KisininAdi = txtKisi.Text;
            gonderim.IlgilenenKisi.KisininTelefonu = msdTelefon.Text;
            gonderim.IlgilenenKisi.IlgılenenKisiId = ilgiliKisiId++;
            gonderim.IlgilenenKisi.BaglıOlduguFirma = cmbFirma.SelectedItem as Firma;

           
        }
    }
}
