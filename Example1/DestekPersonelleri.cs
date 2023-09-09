using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    internal class DestekPersonelleri : Personeller
    {
        public override void Yonetici()
        {
            throw new NotImplementedException();
        }

        public override int DeneyimYilSayisi(int deneyim)
        {
            string msj = deneyim > 2 ? "Deneyim Uygundur" : "Deneyim yetersiz";
            Console.WriteLine(msj);
            return deneyim;
        }

        public override int YasHesapla(int yas)
        {
            string msj = yas < 30 ? "Yas uygundur" : "Yas uygun degildir";
            Console.WriteLine(msj);
            return yas;
        }

        public override string DestekPersonelSart(int deneyim, int yas)
        {
            return base.DestekPersonelSart(deneyim, yas);
        }
    }
}
