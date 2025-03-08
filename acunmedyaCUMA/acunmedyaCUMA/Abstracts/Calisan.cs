using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acunmedyaCUMA.Abstracts
{
    //1.abstract classlarin nesnesi olusturulamaz
    //2.abstract classin kendisinden tureyen classlari eger abstract class icinde normal metodlarin disinda
   // abstract keyword ile tanimlanmis bir metod varsa o metodu yazmak zorundadirlar.
    public abstract class Calisan
    {
        public abstract double maasinizNedir();

        public void mesaiyeBasla(string isim)
        {
            Console.WriteLine(isim + "mesaiye basladi.");

        }


    }
}
