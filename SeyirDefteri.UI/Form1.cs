using SeyirDefteri.Core.Classlar;

namespace SeyirDefteri.UI
{
    public partial class Form1 : Form
    {
        public static List<SeyirKaydi> SeyirKayitlari = new List<SeyirKaydi>();
        public Form1()
        {
            InitializeComponent();
        }
        public void GemiEkle()
        {
            List<Gemi> gemiListesi = new List<Gemi>()
            {
                new Gemi { GemiId = 1, GemiAdi = "Titanic", Tonaji = 46000m },
                new Gemi { GemiId = 2, GemiAdi = "Queen Mary 2", Tonaji = 148528m },
                new Gemi { GemiId = 3, GemiAdi = "Oasis of the Seas", Tonaji = 226838m },
                new Gemi { GemiId = 4, GemiAdi = "Harmony of the Seas", Tonaji = 226963m },
                new Gemi { GemiId = 5, GemiAdi = "Symphony of the Seas", Tonaji = 228081m },
                new Gemi { GemiId = 6, GemiAdi = "MSC Meraviglia", Tonaji = 171598m },
                new Gemi { GemiId = 7, GemiAdi = "Norwegian Escape", Tonaji = 165300m },
                new Gemi { GemiId = 8, GemiAdi = "Costa Smeralda", Tonaji = 185010m },
                new Gemi { GemiId = 9, GemiAdi = "AIDAnova", Tonaji = 183900m },
                new Gemi { GemiId = 10, GemiAdi = "Mardi Gras", Tonaji = 180000m },
                new Gemi { GemiId = 11, GemiAdi = "Regal Princess", Tonaji = 142714m },
                new Gemi { GemiId = 12, GemiAdi = "Majestic Princess", Tonaji = 143700m },
                new Gemi { GemiId = 13, GemiAdi = "Celebrity Edge", Tonaji = 130818m },
                new Gemi { GemiId = 14, GemiAdi = "MSC Seaview", Tonaji = 154000m },
                new Gemi { GemiId = 15, GemiAdi = "Carnival Vista", Tonaji = 133500m }
            };
            foreach (var gemi in gemiListesi)
            {
                cmbGemiAdi.Items.Add(gemi);
            }
        }
        public void LimanOlustur()
        {
            List<string> limanListesi = new List<string>()
            {
                 "�stanbul Sar�yer Yat Liman�, T�rkiye",
                "�stanbul Be�ikta� Liman�, T�rkiye",
                "�stanbul Haydarpa�a Liman�, T�rkiye",
                "�stanbul Kad�k�y Liman�, T�rkiye",
                "�stanbul Karak�y Liman�, T�rkiye",
                "�stanbul Ambarl� Liman�, T�rkiye",
                "�stanbul Bak�rk�y Liman�, T�rkiye",
                "�zmir Alsancak Liman�, T�rkiye",
                "�zmir �e�me Liman�, T�rkiye",
                "�zmir Kar��yaka Liman�, T�rkiye",
                "�zmir Alia�a Liman�, T�rkiye",
                "Mersin Liman�, T�rkiye",
                "Antalya Liman�, T�rkiye",
                "Bodrum Liman�, T�rkiye",
                "G�cek Liman�, T�rkiye",
                "Fethiye Liman�, T�rkiye",
                "Ku�adas� Liman�, T�rkiye",
                "Trabzon Liman�, T�rkiye",
                "Samsun Liman�, T�rkiye",
                "Hopa Liman�, T�rkiye",
                "Port of Piraeus, Yunanistan",
                "Port of Thessaloniki, Yunanistan",
                "Port of Heraklion, Yunanistan",
                "Port of Patras, Yunanistan",
                "Port of Volos, Yunanistan",
                "Port of Genoa, �talya",
                "Port of Naples, �talya",
                "Port of Livorno, �talya",
                "Port of Civitavecchia, �talya",
                "Port of Venice, �talya",
                "Port of Marseille, Fransa",
                "Port of Le Havre, Fransa"
            };
            foreach (var liman in limanListesi)
            {
                cmbCikisLimani.Items.Add(liman);
                cmbVarisLimani.Items.Add(liman);
                cmbUgradigiLiman.Items.Add(liman);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GemiEkle();
            LimanOlustur();
            ListViewSutunEkle();
        }
        public void ListViewSutunEkle()
        {
            LvSeferler.View = View.Details;
            LvSeferler.GridLines = true;

            LvSeferler.Columns.Add("ID", 30, HorizontalAlignment.Center);
            LvSeferler.Columns.Add("Var�� Tarihi", 80, HorizontalAlignment.Center);
            LvSeferler.Columns.Add("��k�� Tarihi", 80, HorizontalAlignment.Center);
            LvSeferler.Columns.Add("��k�� Liman�", 100, HorizontalAlignment.Center);
            LvSeferler.Columns.Add("U�rayaca�� Liman", 100, HorizontalAlignment.Center);
            LvSeferler.Columns.Add("Var� Liman�", 100, HorizontalAlignment.Center);
            LvSeferler.Columns.Add("Gemi", 100, HorizontalAlignment.Center);
            LvSeferler.Columns.Add("ID", 100, HorizontalAlignment.Center);
        }
        int id = 1;

        private void btnSeferOlustur_Click(object sender, EventArgs e)
        {
            if (dtpCikisTarihi.Value > dtpVarisTarihi.Value)
            {
                MessageBox.Show("Var�� Tarihi ��k�� Tarihinden Erken Olamaz");
                return;
            }
            if (cmbGemiAdi.SelectedItem == null || cmbCikisLimani.SelectedItem == null || cmbUgradigiLiman.SelectedItem == null || cmbVarisLimani.SelectedItem == null)
            {
                MessageBox.Show("L�tfen Bo�luklar� Doldurunuz");
                return;
            }
            if (cmbCikisLimani.SelectedItem == cmbUgradigiLiman.SelectedItem || cmbUgradigiLiman.SelectedItem == cmbVarisLimani.SelectedItem || cmbVarisLimani.SelectedItem == cmbCikisLimani.SelectedItem)
            {
                MessageBox.Show("Sefer s�ras�nda girilen duraklar ayn� olamaz");
                return;
            }
            SeyirKaydi seyirKaydi = new SeyirKaydi()
            {
                LimandanCikisTarihi = dtpCikisTarihi.Value,
                LimanaVarisTarihi = dtpVarisTarihi.Value,
                CikisLimani = cmbCikisLimani.SelectedItem.ToString(),
                UgrayacagiLiman = cmbUgradigiLiman.SelectedItem.ToString(),
                VarisLimani = cmbVarisLimani.SelectedItem.ToString(),
                Gemi = cmbGemiAdi.SelectedItem as Gemi
            };
            ListViewItem listViewItem = new ListViewItem();
            listViewItem.Text = (id++).ToString();
            listViewItem.SubItems.Add(seyirKaydi.LimanaVarisTarihi.ToString());
            listViewItem.SubItems.Add(seyirKaydi.LimandanCikisTarihi.ToString());
            listViewItem.SubItems.Add(seyirKaydi.CikisLimani.ToString());
            listViewItem.SubItems.Add(seyirKaydi.UgrayacagiLiman.ToString());
            listViewItem.SubItems.Add(seyirKaydi.VarisLimani.ToString());
            listViewItem.SubItems.Add(seyirKaydi.Gemi.ToString());

            LvSeferler.Items.Add(listViewItem);
            SeyirKayitlari.Add(seyirKaydi);
            Temizle();


        }
        private void Temizle()
        {
            dtpCikisTarihi.Value = DateTime.Today;
            dtpVarisTarihi.Value = DateTime.Today;
            cmbCikisLimani.SelectedItem = null;
            cmbUgradigiLiman.SelectedItem = null;
            cmbVarisLimani.SelectedItem = null;
            cmbGemiAdi.SelectedItem = null;

        }

        private void btnGec_Click(object sender, EventArgs e)
        {
           if(SeyirKayitlari.Count>0)
            {
                Form2 form2 = new Form2(SeyirKayitlari);
                form2.ShowDialog();
            }
           else
            {
                MessageBox.Show("L�tfen Seyir Kay�tlar�n� Listeye Ekleyiniz");
                return;
            }
        }
    }
}
