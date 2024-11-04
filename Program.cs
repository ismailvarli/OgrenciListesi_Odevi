using System.Collections;

namespace OgrenciListesiOdevi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********************");
            LiseOgrenci.liseOgrenci.BilgiYazdır();
            Console.WriteLine("**********************");
            LisansOgrencisi.lisansogrenci.BilgileriYazdir();
            Console.WriteLine("**********************");
        }
    }
}

