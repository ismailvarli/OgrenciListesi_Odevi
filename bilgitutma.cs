using OgrenciListesiOdevi;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciListesiOdevi
{
    using System;
    using System.Collections;

    public enum OgretimDuzeyi
    {
        İlkOgretim,
        OrtaOgretim,
        Lise,
        Lisans
    }

    public class Ogrenci
    {
        public string AdSoyad { get; set; }
        public int OkulNumarasi { get; set; }
        public string OkulAdi { get; set; } = "Açıktan Eğitim";
        public OgretimDuzeyi OgretimDuzeyi { get; set; }
        public ArrayList Bilgiler { get; set; }


        public Ogrenci(string adSoyad, int okulNumarasi, OgretimDuzeyi ogretimDuzeyi, string okulAdi)
        {
            AdSoyad = adSoyad;
            OkulNumarasi = okulNumarasi;
            OgretimDuzeyi = ogretimDuzeyi;
            OkulAdi = okulAdi;


            Bilgiler = new ArrayList { AdSoyad, OkulNumarasi, OkulAdi, OgretimDuzeyi };
           
        }


        public virtual void NotHesapla()
        {
            Console.WriteLine("Not Bilgisi Eksik!");
        }
    }

    public class LiseOgrenci : Ogrenci
    {
       internal static LiseOgrenci liseOgrenci = new LiseOgrenci("Elif Demir", 102, OgretimDuzeyi.Lise, "Açıktan Eğitim", 85, 90);

        public int Not1 { get; set; }
        public int Not2 { get; set; }

        public LiseOgrenci(string adSoyad, int okulNumarasi, OgretimDuzeyi ogretimDuzeyi, string okulAdi, int not1, int not2)
            : base(adSoyad, okulNumarasi, ogretimDuzeyi, okulAdi)
        {
            Not1 = not1;
            Not2 = not2;
        }


        public  void BilgiYazdır()
        {
           
            int topla = (int)((liseOgrenci.Not1 + liseOgrenci.Not2) / 2);

            Console.WriteLine("Ad Soyad: " + AdSoyad);
            Console.WriteLine("Okul Numarası: " + OkulNumarasi);
            Console.WriteLine("Öğretim Düzeyi: " + OgretimDuzeyi);
            Console.WriteLine("Okul Adı: " + OkulAdi);
            Console.WriteLine($"Ortalama:{topla}");

            if (topla>85 && topla<101)
            {
                Console.WriteLine("Ders Notu: Pek İyi");
            }
           else if (topla > 70 && topla < 85)
            {
                Console.WriteLine("Ders Notu: İyi");
            }
          else  if (topla > 60 && topla < 70)
            {
                Console.WriteLine("Ders Notu: Orta");
            }
           else if (topla > 59 && topla < 50)
            {
                Console.WriteLine("Ders Notu: Geçer");
            }
            else
            {
                Console.WriteLine("Ders Notu: Tekrar!");
            }


        }
    }   
}
public class LisansOgrencisi : Ogrenci
{
    internal static LisansOgrencisi lisansogrenci = new LisansOgrencisi("Oğuz Kaan Alturan", 241, OgretimDuzeyi.Lisans, "Mimar Sinan Üniversitesi", "Fen-Edebiyat Fakültesi", 88, 56);

    public string Fakulte { get; set; }
    public int VizeNotu { get; set; }
    public int FinalNotu { get; set; }

    public LisansOgrencisi(string adSoyad, int okulNumarasi, OgretimDuzeyi ogretimDuzeyi, string okulAdi, string fakulte, int vizenotu, int finalnotu)
           : base(adSoyad, okulNumarasi, ogretimDuzeyi, okulAdi)
    {
        Fakulte = fakulte;
        VizeNotu = vizenotu;
        FinalNotu = finalnotu;
    }
  
    public void BilgileriYazdir()
    {

        int topla = (int)((lisansogrenci.VizeNotu * 0.60 + lisansogrenci.FinalNotu * 0.60) / 2);
        Console.WriteLine("Ad Soyad: " + AdSoyad);

        Console.WriteLine("Okul Numarası: " + OkulNumarasi);
        Console.WriteLine("Öğretim Düzeyi: " + OgretimDuzeyi);
        Console.WriteLine("Okul Adı: " + OkulAdi);
        Console.WriteLine("Fakülte: " + Fakulte);
        Console.WriteLine("Vize Notu: " + VizeNotu);
        Console.WriteLine("Final Notu: " + FinalNotu);
        Console.WriteLine($"Ortalama:{topla}");


        if (topla > 85 && topla < 101)
        {
            Console.WriteLine("Ders Notu: A");
        }
        else if (topla > 70 && topla < 85)
        {
            Console.WriteLine("Ders Notu: B");
        }
        else if (topla > 60 && topla < 70)
        {
            Console.WriteLine("Ders Notu: C");
        }
        else if (topla > 59 && topla < 50)
        {
            Console.WriteLine("Ders Notu: D");
        }
        else
        {
            Console.WriteLine("Ders Notu: F");
        }
    }
}