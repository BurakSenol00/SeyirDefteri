using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeyirDefteri.Core.Classlar
{
    public class IlgilenenKisi
    {
        public int IlgılenenKisiId { get; set; }
        public string KisininAdi { get; set; }
        public string KisininTelefonu { get; set; }
        public Firma BaglıOlduguFirma { get; set; }
        
    }
}
