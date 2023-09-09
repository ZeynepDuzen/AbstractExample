using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    internal class HumanResoueces : PersonelBase
    {
        public override void Yonetici()
        {
            Console.WriteLine("Kisi yonetici degildir");
        }

        public override int YasHesapla(int yas)
        {
            string msj = yas >= 30 ? "Yas uygundur" : "Yas uygun degildir";
            Console.WriteLine("Yas sarti : " + msj);
            return yas;
        }

        public override int DeneyimYilSayisi(int deneyimYilSayisi)
        {
            string msj = deneyimYilSayisi >= 2 ? "Deneyim suresi uygun" : "Deneyim suresi uygun degil";
            Console.WriteLine("Deneyim durumu : " + msj);
            return deneyimYilSayisi;
        }

        public override string InsanKaynaklariKarar(int yas, int deneyimYilSayisi)
        {
            return base.InsanKaynaklariKarar(yas, deneyimYilSayisi);
        }
    }
}
