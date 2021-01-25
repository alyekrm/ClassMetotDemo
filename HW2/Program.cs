using System;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            GameManager gameManager = new GameManager();
            
            GamerManager gamerManager = new GamerManager(new Validation()) ;
            
            OfferManager offerManager = new OfferManager();

            Gamer gamer1 = new Gamer()
            {
                Id = 1,
                Name = "gamer/oyuncu",
                Surname = "gamer",
                NationalityId = "123456798"
            };

            Game game = new Game() { Id = 1, Name = "game", Price = 14.99 };

            Offer offer = new Offer() { Id = 1, Name = "offer", Discount = 5.5 };

            gamerManager.Add(gamer1);
            
            gameManager.Sell(gamer1, game);
           
            offerManager.Add(offer);
           
            gameManager.Sell(gamer1, game, offer);



        }
    }
}
