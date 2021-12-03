using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_exp
{
    class Program
    {
        static void Main(string[] args)
        {
            Gitar g1 = new Gitar();
            Muzisyen m1 = new Muzisyen();


            g1.markasi = "fender";
            g1.muzikAleti = "gitar";
            m1.adiSoyadi = "salih koç";

            Console.WriteLine("markası: "+g1.markasi+"Adı: "+g1.muzikAleti);
            Console.WriteLine(m1.adiSoyadi+" "+g1.markasi+" marka "+g1.muzikAleti+" Çalıyor.");
            Console.ReadKey();
        }
    }
}
