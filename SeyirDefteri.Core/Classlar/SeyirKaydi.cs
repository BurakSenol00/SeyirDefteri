﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeyirDefteri.Core.Classlar
{
     public class SeyirKaydi
    {
        public int SeyirKaydiId { get; set; }
        public Gemi Gemi { get; set; }
        public DateTime LimandanCikisTarihi { get; set; }
        public DateTime LimanaVarisTarihi { get; set; }

        public string UgrayacagiLiman { get; set; }
        public string VarisLimani { get; set; }
        public string CikisLimani { get; set; }

        public override string ToString()
        {
            return "Çıkış Limanı:" + CikisLimani + " Uğrayacağı Liman " + UgrayacagiLiman + " Varış Limanı " + VarisLimani;
        }
    }
}
