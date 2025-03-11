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
   
    public partial class Form3: Form
    {
       private List<Gonderim> Gonderimler;
        public Form3() 
        {
            InitializeComponent();
        }
        public Form3(List<Gonderim>gonderimler) : this()
        {
            Gonderimler = gonderimler;
        }
    }
}
