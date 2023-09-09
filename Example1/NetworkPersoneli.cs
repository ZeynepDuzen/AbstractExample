using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    internal class NetworkPersoneli : Personeller
    {
        public override void Yonetici()
        {
            //abstract method kalitim verilecek butun class' larda gelecektir
            throw new NotImplementedException();
        }
        //firmadan ayrilan biri ikinci kez ise alinmayacak ancak
        //metwork personeli icin boyle bir durum yok, dolayisi ile
        //EskiPersonelmi methodunu cagirmaya gerek yok(polymorphisim)


    }
}
