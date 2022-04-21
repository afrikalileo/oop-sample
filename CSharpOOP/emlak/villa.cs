using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.emlak
{
    internal class Villa : Ev
    {

        public Villa(string Lokasyon, int odasayisi) : base(Lokasyon, odasayisi)
        {

        }

    
        public bool HavuzVarmi { get; set; }
        public int AlanBahce { get; set; }
        public int AlanGaraj { get; set; }

    }
}
}