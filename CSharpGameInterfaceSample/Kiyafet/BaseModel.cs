using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGameInterfaceSample.Kiyafet
{
    public abstract class BaseModel
    {
        public string Id { get; set; }
        public DateTime AddDate { get; set; }=DateTime.Now;

        public string Colour { get; set; }

        public decimal Price { get; set; }

        public decimal KDVFiyat { get { return Price * 0.18M; } }  

    }
    public enum seasons {summer, winter, spring }; 
}
