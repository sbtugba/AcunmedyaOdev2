using AcunMedya2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunMedya2.Araba
{
    public class Porsche : IHareket
    {
        public void Git() => Console.WriteLine("Porsche yolda gidiyor.");
        public void Yuz() => Console.WriteLine("Porsche denizde yüzemez.");
        public void Uc() => Console.WriteLine("Porsche havada uçuyor.");
    }
}
