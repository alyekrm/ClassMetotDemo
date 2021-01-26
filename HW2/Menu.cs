using System;
using System.Collections.Generic;
using System.Text;

namespace HW2
{
    class Menu
    {
        public void New(GamerManager gamerManager,OfferManager offerManager, List<IBasicInfo> dataBase)
        {
            Console.WriteLine("Yeni oyuncu eklemek için 1");
            Console.WriteLine("Database listelemek için 2");
            Console.WriteLine("Yeni Teklif eklemek için 3");
            Console.WriteLine("Çıkmak için 4'e basınız");
            string get =Console.ReadLine();
            switch (get)
            {
                case ("1"):
                    NewGamer(gamerManager,offerManager, dataBase);
                    break;
                case ("2"):
                    gamerManager.List(dataBase);
                    Console.WriteLine("Yeni işlem yapmak ister misiniz?");
                    string answer = Console.ReadLine();
                    switch (answer)
                    {
                        case ("evet"):
                            New(gamerManager,offerManager,  dataBase);
                            break;
                        case ("hayır"):
                            break;
                    }
                    break;
                case ("3"):
                    NewOffer(gamerManager,offerManager, dataBase);
                    break;

                case ("4"):
                    break;
                default:
                    Console.WriteLine("Geçersiz giriş yaptınız.Tekrar denemek ister misiniz?");
                    string answer3 = Console.ReadLine();
                    switch (answer3)
                    {
                        case ("evet"):
                            New(gamerManager, offerManager, dataBase);
                            break;
                        case ("hayır"):
                            break;
                        default:
                            Console.WriteLine("cevabınızı evet yada hayır olara giriniz");
                            break;
                    }
                    break;


            }
 
        }
        public void NewGamer(GamerManager gamerManager,OfferManager offerManager, List<IBasicInfo> dataBase)
        {
            
                   Console.WriteLine("Yeni oyuncu girişi");
                   Gamer newGamer = new Gamer() { };
                   Console.WriteLine("oyuncu adı giriniz");
                   newGamer.Name = Console.ReadLine();
                   Console.WriteLine("oyuncu soyadı giriniz");
                   newGamer.Surname = Console.ReadLine();
                   Console.WriteLine("T.C kimlik no giriniz  ");
                   newGamer.NationalityId = Console.ReadLine();
                   gamerManager.Add(newGamer,dataBase);
                   gamerManager.List(dataBase);
                   Console.WriteLine("yeni işlem yapmak ister misiniz?");
                   string answer1 = Console.ReadLine();
                   switch (answer1)
                   {
                       case ("evet"):
                        New(gamerManager, offerManager, dataBase);

                        break;
                       case ("hayır"):
                           break;
                       default:
                           Console.WriteLine("cevabınızı evet hada hayır olarak giriniz");
                           NewGamer(gamerManager,offerManager,dataBase);
                           break;
                   }
        }
       
        public void NewOffer(GamerManager gamerManager, OfferManager offerManager, List<IBasicInfo> dataBase)
        {
            Console.WriteLine("Yeni teklif girişi");
            Offer newOffer = new Offer() { };
            Console.WriteLine("Teklif adı giriniz");
            newOffer.Name = Console.ReadLine();
            Console.WriteLine("Teklif miktarı giriniz");
            newOffer.Discount = Convert.ToDouble(Console.ReadLine());
            offerManager.Add(newOffer, dataBase);
            offerManager.List(dataBase);
            Console.WriteLine("yeni işlem yapmak ister misiniz?");
            string answer1 = Console.ReadLine();
            switch (answer1)
            {
                case ("evet"):
                    New(gamerManager, offerManager, dataBase);
                    break;
                case ("hayır"):
                    break;
                default:
                    Console.WriteLine("cevabınızı evet hada hayır olarak giriniz");
                    NewOffer(gamerManager,offerManager,  dataBase);
                    break;
            }
        }
    }
}
