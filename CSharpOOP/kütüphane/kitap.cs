using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.kütüphane
{
    public class kitap
    {
        public string Ad { get; set; }

        public DateTime Basimyili { get; set; }

        public List<yazar> Yazarlar { get; set; }

        public tür Turu { get; set; }

        public kitap_evi Aitoldugu { get; set; }

        public int ISBNNo { get; set; }

        public string Kisaacıklama { get; set; }



            
    }
}
