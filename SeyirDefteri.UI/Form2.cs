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
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(List<SeyirKaydi>seyirkayitlari): this()
        {
            foreach (var seyir in seyirkayitlari)
            {
                if(seyir.Gemi==null)
                {
                    MessageBox.Show("Sefer KAyıtlarındaki Gemi Bilgisi Eksik");
                    return;
                }
                cmbSeferler.Items.Add(seyir);
            }
        }

    }
}
