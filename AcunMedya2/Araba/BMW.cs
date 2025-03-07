using AcunMedya2.Interface;
using AcunMedya2.YakıtTüketimi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunMedya2.Araba
{
    public class BMW : IHareket
    {
        public void Git() => Console.WriteLine("BMW çok hızlı gidiyor.");
        public void Yuz() => Console.WriteLine("BMW denizde yüzüyor.");
        public void Uc() => Console.WriteLine("BMW havada uçuyor.");

    }
}
