using AcunMedya2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunMedya2
{
    public class Mercedes : IHareket
    {
        public void Git() => Console.WriteLine("Mercedes yolda gidiyor.");
        public void Yuz() => Console.WriteLine("Mercedes denizde yüzüyor.");
        public void Uc() => Console.WriteLine("Mercedes havada uçuyor.");
    }
}
