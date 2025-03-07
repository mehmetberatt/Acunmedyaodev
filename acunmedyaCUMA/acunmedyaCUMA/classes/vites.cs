using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acunmedyaCUMA.classes
{
    public class vites : Araba 
    {
        public string tür;
        public void markaTürYaz(string marka, string tür )
        {
            Console.WriteLine(marka + " " + tür);

        }
    }
}
