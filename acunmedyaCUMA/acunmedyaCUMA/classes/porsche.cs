﻿using acunmedyaCUMA.ınterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acunmedyaCUMA.classes
{
    public class Porsche : IUcar
    {
        public void Ucar()
        {
            Console.WriteLine("ucar...");
        }

        public void Ucar(string isim)
        {
            Console.WriteLine("ucar...");
        }
    }

}
