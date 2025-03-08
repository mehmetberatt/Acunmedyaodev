using acunmedyaCUMA.ınterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acunmedyaCUMA.classes
{
    //public class Bmw : Araba
    public class Bmw : IUcar, IYuzer, IHizliGider

    {

        public void HizliGider()
        {
            Console.WriteLine("hizli gider...");
        }

        public void HizliGider(string isim)
        {
            Console.WriteLine("hizli gider..."); 
        }

        public void Ucar()
        {
            Console.WriteLine("ucar...");
        }

        public void Ucar(string isim)
        {
            Console.WriteLine("ucar...");
        }

        public void Yuzer()
        {
            Console.WriteLine("yuzer...");
        }
    }
}
