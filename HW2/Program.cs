using System;
using System.Collections.Generic;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            GameManager gameManager = new GameManager();
            
            GamerManager gamerManager = new GamerManager(new Validation()) ;
            
            OfferManager offerManager = new OfferManager();

            List<BasicInfo> dataBase = new List<BasicInfo>() { };

            Menu menu = new Menu();

            Game game = new Game() { Id = 1, Name = "game", Price = 14.99 };

            Gamer gamer1 = new Gamer()
            {
                Id = 1,
                Name = "gamer/oyuncu",
                Surname = "gamer",
                NationalityId = "123456798",
   
            };
            
            Offer offer = new Offer() { Id = 1, Name = "offer", Discount = 5.5 };

            gamerManager.Add(gamer1,dataBase);

            gameManager.Sell(gamer1, game);

            offerManager.Add(offer,dataBase);

            gamerManager.List(dataBase);

            gameManager.Sell(gamer1, game, offer);

            offerManager.List(dataBase);
            Console.WriteLine("-----------");

 
            menu.New(gamerManager, offerManager,dataBase);



        }
       
      

    }
}

