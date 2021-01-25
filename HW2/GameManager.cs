using System;
using System.Collections.Generic;
using System.Text;

namespace HW2
{
    class GameManager
    {
        
        public void Sell(Gamer gamer, Game game,Offer offer=null)
        {
            
            if(offer != null)
            {
                Console.WriteLine(gamer.Name + " kullanıcısına " + game.Name + " oyunu " + offer.Discount +
                " indirim miktarı düşülerek " + game.Price + " yerine " + (game.Price - offer.Discount) + " satıldı.");
            }
            else
            {
                Console.WriteLine(gamer.Name + " kullanıcısına " + game.Name + " oyunu "+game.Price +" ücretiyle satıldı.");
            }
        }
    }
}
