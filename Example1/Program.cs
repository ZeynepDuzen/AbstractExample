using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            1- MS-SQL Server => veritabani local setup 
            2- Management Studio => veritabanına erismek icin kullanilan editor
             */

            /*
             Abstract --> Soyut Sinif: class icin kullanilan kelime
            abtract. override, virtual => polymorphism (cok bicimlilik)
             */


            // Personeller personeller = new Personeller(); //abstract class'lar ve Interface class' lar new'lenemezler,yani
            // instance alamayiz --> ornekleme yapamayiz


            YazilimPersoneli yazilimPersoneli = new YazilimPersoneli();
            yazilimPersoneli.Kaydet();
            yazilimPersoneli.Yonetici();
            //virtual neir??
            //daha once firmada calisan bir yazilim personeli isten cikti ise 2. kez tekrar ise alinmayacaktir

            Console.WriteLine("--------------------------------------------------------");

            NetworkPersoneli networkPersoneli = new NetworkPersoneli();
            networkPersoneli.EskiPersonelMi(0);
            yazilimPersoneli.EskiPersonelMi(10);

            Console.WriteLine("Network : " + networkPersoneli.EskiPersonelMi(0));
            Console.WriteLine("Yazilim : " + yazilimPersoneli.EskiPersonelMi(10));

            /*
             Destek Personelleri diye yeni bir title ile personel alımı yapılacaktır.
            Bu personeller için aşağıdaki kurallar geçerli olacaktır
            1-30 yaşın üstünde olmayacak
            2-daha önce bu pozisyonda 2 yıl çalışmış olacak
            DestekPersonel
            Personel Edit  ??
             */

            Console.WriteLine("-------------------------------------------");
            DestekPersonelleri destekPersonelleri = new DestekPersonelleri();
            destekPersonelleri.DeneyimYilSayisi(1);
            destekPersonelleri.YasHesapla(29);


            Console.Read();
        }

        
    }
}
