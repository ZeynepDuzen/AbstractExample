using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    internal class YazilimPersoneli : Personeller
    {
        //overloading --> methodlarin asiri yuklenmesi
        //override --> abstract class icin kullanilan ezme, yoksayma
        public override void Yonetici() //Yonetici() daha onceden abstract olarak belirtildigi icin,bu class'ta istedigim gibi ozellestirebilirim
        {   //implement ile gelen override method ezme islemini gerceklestirecektir
            //Bu yapi abstract class icerisinde abstract olarak tanimlanan method sayesinde gerceklesmektedir
            Kaydet();
            //abstract class' ta Kaydet() methodu abstract olarak tanimlanmadigi icin Kaydet() methodunu overrride edemem
            //find(), yonetici mi degil mi  sorgusu yapar,
            //bu yapi kullaniciya true-false seklinde bilgi verir
            Console.WriteLine("Bir yonetici degildir");
            
        }

        public override int EskiPersonelMi(int c)
        {
            //virtual methodu abstract class altinda tanimlanmisti,EskiPersonelMi methoduna verildi,
            //EskiPersonelMi methodu lazim ise kalitim verilen classlarda cagirilabilir,
            //lazim degilse kullanmaya gerek yoktur,burada secenek yazilimciya birakilir ve cok bicimlilik saglanmis olur
            return base.EskiPersonelMi(c);
        }

    }
}
