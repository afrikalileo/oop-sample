using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.haberportali
{
    public class düzenleyici
    {
        public static string TitleCapitalize(string title)
        {
            TextInfo myTI = new CultureInfo("tr-TR", false).TextInfo;
            return myTI.ToTitleCase(title);
        }
    }
}
