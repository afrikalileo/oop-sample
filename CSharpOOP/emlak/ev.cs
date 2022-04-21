using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.emlak
{
    public class Ev : Emlak
    {
        public Ev(string Lokasyon, int odasayisi) : base(Lokasyon)
        {
            this. Lokasyon = Lokasyon;    
        }
        
           public int oda_sayisi { get; set; } 
        public int kat_sayisi { get; set; }

        public bool banyovarmi
    
            {      
 
        get=>luksmu;
            
            }  
        public bool luksmu { get; set; }    
    
    }
}
