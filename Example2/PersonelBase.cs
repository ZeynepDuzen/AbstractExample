using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    internal abstract class PersonelBase
    {
        public string Adi { get; set; }
        public string SoyAdi { get; set; }
        public string GorevTanimi { get; set; }


        public void Kayit()
        {
            Console.WriteLine("Personel kaydedildi");
        }

        public void Guncelle()
        {
            Console.WriteLine("Guncelleme yapildi");
        }


        public abstract void Yonetici();

        public virtual int YasHesapla(int yas)
        {
            return yas;
        }

        public virtual int DeneyimYilSayisi(int deneyimYilSayisi)
        {
            return deneyimYilSayisi;
        }

        public virtual string InsanKaynaklariKarar(int yas,int deneyimYilSayisi)
        {
            string msj = yas >= 30 && deneyimYilSayisi >= 2 ? "Karar olumlu" : "Karar olumsuz";
            Console.WriteLine("Insan kaynaklari icin karar : " + msj);
            return msj;
        }

    }
}
