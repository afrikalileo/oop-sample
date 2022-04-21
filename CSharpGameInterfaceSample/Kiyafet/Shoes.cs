using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGameInterfaceSample.Kiyafet
{
    public class Shoes : BaseModel,IDiscounterCalc
      

    {
        public decimal CalcDisc { get => base.Price * 0,005 ; set; }    
        public int size { get; set; }
    }
}
