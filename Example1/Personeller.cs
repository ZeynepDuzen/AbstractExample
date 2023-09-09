using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    internal abstract class Personeller
    {
        /*
         abstract class icin abstract kelimesinin yazilmasi yeterlidir
         abstract class iceriside abstract methodlar olusturulur
         */

        public string PersonelAdi { get; set; }
        public string PersonelSoyAdi { get; set; }

        public string GorevTanimi { get; set; }
        public void Kaydet()
        { //find
          //save
            Console.WriteLine("Personel kaydedildi");
        }



        public void Guncelle()
        {
            Console.WriteLine("Guncellendi");
        }

        public abstract void Yonetici(); //?? Ozel bir secenek, bu method soyutlasmis oldu,


        /// <summary>
        /// Eski personel degil ise 0,
        /// </summary>
        /// <returns></returns>
        public virtual int EskiPersonelMi(int gunSayisi)
        {
            return gunSayisi;
        }

       public virtual int YasHesapla(int yas)
        {
            return yas;
        }

        public virtual int DeneyimYilSayisi(int deneyim)
        {
            return deneyim;
        }

        public virtual string DestekPersonelSart(int deneyim,int yas)
        {
            string msj = (yas < 30 && deneyim > 2) ? "Alinabilir" : "Sartlar saglanmiyor";
            return msj;
        }
            
        



    }
}
