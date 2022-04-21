using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.emlak
{
    public abstract class Emlak
    {
        public Emlak (string Lokasyon)
    {
        this.Lokasyon = Lokasyon;
    }

    
        public string Lokasyon { get; set; }
        public int Alan { get; set; }

        public decimal SatisFiyat { get; set; }
        public decimal KiraFiyat { get; set; }

        public decimal SatisVergi {
            
            get => SatisFiyat * 0.012 ; }
        public int KiraVergi {
            get => KiraVergi * 0.005; }
    }
}
