using GameStoreDemo.Abstract;
using GameStoreDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreDemo.Concrete
{
    class GameSaleManager : IGameSaleService
    {
        public void Sale(Game game, Gamer gamer, Campaign campaign)
        {
            double newPrice = game.Price - (game.Price * (campaign.CampaignDiscount / 100));
            Console.WriteLine
                (game.GameName + " Oyunu " + campaign.CampaignDiscount + "% İndirimle Kütüphanenize Eklendi. " + gamer.Name + " Bey");
            Console.WriteLine("Normal Fiyat = " + game.Price);
            Console.WriteLine("İndirimli Fiyat = " + newPrice);
        }
    }
}
