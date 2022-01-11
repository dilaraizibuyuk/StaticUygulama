using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticUygulama
{
    class Hesap
    {
        static decimal vergi;
        public static void VergiYaz()
        {
            string m;
            Console.WriteLine("Brüt gelirinizi girer misiniz?");
            m = Console.ReadLine();
            Vergiler.brutGelir = decimal.Parse(m);
            vergi = Vergiler.GelirVergisiHesapla(Vergiler.brutGelir);
            Console.WriteLine("{0}'ın vergisi {1} TL'dir.",Vergiler.brutGelir,vergi);
        }
    }
}
