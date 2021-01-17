using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        static public void MusteriEkle(ref int counter)
        {
            Console.WriteLine("Sicil No Giriniz:");
            string Sicil = Console.ReadLine();
            Console.WriteLine("Müşteri adını giriniz:");
            string Ad = Console.ReadLine();
            Console.WriteLine("Müşteri soyadını giriniz");
            string SoyAd = Console.ReadLine();
            counter = counter + 1;
            Musteri YeniMusteri = new Musteri() { Id = counter, Adi = Ad, Soyadi = SoyAd };
            Console.WriteLine(YeniMusteri.Adi+" "+YeniMusteri.Soyadi + " Başarıyla eklendi");
        }
        static public void MusteriSil(Musteri[] Musteriler)
        {
            Console.WriteLine("Silinecek müşterinin Id'sini giriniz");
            int Id = Convert.ToInt16(Console.ReadLine());
            foreach (var musteri in Musteriler)
            {
                if (musteri.Id == Id)
                {
                    Console.WriteLine(musteri.Adi);
                    Console.WriteLine(musteri.Soyadi);
                    Console.WriteLine(musteri.Id);
                    musteri.Adi = "Silindi";
                    musteri.Soyadi = "Silindi";
                    Console.WriteLine("Id numarası:" + Id + " olan müşteri silindi");
                }
            }
        }
        static public void MusteriListele(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Adı Soyadı Müşteri Sistem Numarası");
                Console.WriteLine("----------------------------------");
                Console.WriteLine(musteri.Adi+" "+musteri.Soyadi+" "+musteri.Id);
                Console.WriteLine("***********");
            }
        }
    }
}
