using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HumanResoueces humanResoueces = new HumanResoueces();
            humanResoueces.Adi = "zeynep";
            humanResoueces.SoyAdi = "cankus";
            humanResoueces.GorevTanimi = "software developer";
            Console.WriteLine("Adi : " + humanResoueces.Adi);
            Console.WriteLine("SoyAdi : " + humanResoueces.SoyAdi);
            Console.WriteLine("Gorev tanimi : " + humanResoueces.GorevTanimi);
            humanResoueces.YasHesapla(30);
            humanResoueces.DeneyimYilSayisi(5);
            humanResoueces.InsanKaynaklariKarar(30,5);
            humanResoueces.Yonetici();
            humanResoueces.Kayit();
            humanResoueces.Guncelle();

            Console.Read();
        }
    }
}
