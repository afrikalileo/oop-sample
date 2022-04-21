using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGameInterfaceSample.Kiyafet
{
    public interface IDiscounterCalc
    {
        public decimal CalcDisc(decimal Price)
        {

        return Price * 0.005M;

        }
    }
}
