using AcunMedya2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunMedya2.Calisan
{
    abstract class CalisanAbstract : ICalisan
    {
        public string Ad { get; set; }
        public abstract decimal MaasHesapla();
    }
}
