using AcunMedya2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunMedya2.YakıtTüketimi
{
    abstract class Araba : IYakıtTüketimi
    {
        public abstract double YakitHesapla();
    }
}
