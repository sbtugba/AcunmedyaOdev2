using AcunMedya2.Araba;
using AcunMedya2.Calisan;
using AcunMedya2.Interface;
using AcunMedya2.YakıtTüketimi;

namespace AcunMedya2
{
    class Program
    {
        static void Main()
        {
            IHareket bmw = new BMW();
            bmw.Git();
            bmw.Yuz();
            bmw.Uc();

            IHareket mercedes = new Mercedes();
            mercedes.Yuz();
            mercedes.Uc();

            IHareket porsche = new Porsche();
            porsche.Uc();

            Console.WriteLine("------------------------");
            CalisanAbstract genelMudur = new GenelMudur();
            CalisanAbstract mudur = new Mudur();
            CalisanAbstract programci = new Programci();
            CalisanAbstract  stajyer = new Stajyer();

            Console.WriteLine($"Genel Müdür   -> {genelMudur.MaasHesapla():#,0}");
            Console.WriteLine($"Müdür         -> {mudur.MaasHesapla():#,0}");
            Console.WriteLine($"Programcı     -> {programci.MaasHesapla():#,0}");
            Console.WriteLine($"Stajyer       -> {stajyer.MaasHesapla():#,0}");

            Console.WriteLine("---------------------");
            BMWaraba BMW = new BMWaraba();
            MercedesAraba Mercedes = new MercedesAraba();
            PorscheAraba Porsche = new PorscheAraba();

            Console.WriteLine($"BMW yakıt tüketimi: {BMW.YakitHesapla()}");
            Console.WriteLine($"Mercedes yakıt tüketimi: {Mercedes.YakitHesapla()}");
            Console.WriteLine($"Porsche yakıt tüketimi: {Porsche.YakitHesapla()}");

            Console.ReadLine();
        }
    }
}
