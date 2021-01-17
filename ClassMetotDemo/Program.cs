using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main()
        {
            int counter = 1;
            Musteri Musteri1 = new Musteri();
            {
                Musteri1.Id = 1;
                Musteri1.Adi = "Ali";
                Musteri1.Soyadi = "Veli";
            }
            Musteri[] musteriler = new Musteri[] { Musteri1 };
            Menu();
            string Secim = Console.ReadLine();
            if (Secim == "1")
            {
                MusteriManager.MusteriListele(musteriler);
                Yeni();
            }
            else if (Secim=="2")
            {
                MusteriManager.MusteriEkle(ref counter);
                Yeni();
            }
            else if (Secim == "3")
            {
                MusteriManager.MusteriSil(musteriler);
                Yeni();
            }
            else
            {
                return;
            }
        }
        static void Menu()
        {
            Console.WriteLine("Yapmak istediğiniz işlemi seçinizi");
            Console.WriteLine("Müşterileri listelemek için 1'e,");
            Console.WriteLine("Yeni müşteri eklemek için 2'ye,");
            Console.WriteLine("Ekli müşteriyi silmek için 3'e ");
            Console.WriteLine("Çıkmak için 4'e basınız");
        }
        static void Yeni()
        {
            Console.WriteLine("Yeni bir işlem yapmak ister misiniz?");
            string Cevap = Console.ReadLine();
            switch (Cevap)
            {
                case "evet":
                    Program.Main();
                    break;
                case "hayır":
                    break;
                default:
                    Console.WriteLine("Lütfen cevabınızı evet yada hayır olarak giriniz");
                    Yeni();
                    break;
            }
        }
    }
}
