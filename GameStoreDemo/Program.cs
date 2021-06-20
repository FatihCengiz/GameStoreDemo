using GameStoreDemo.Abstract;
using GameStoreDemo.Concrete;
using GameStoreDemo.Entities;
using System;

namespace GameStoreDemo
{
    class Program
    {

        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer() 
            { 
                Id = 1, 
                Tc = "123456789", 
                Name = "Fatih", 
                LastName = "Cengiz",
                DateOfBirth = new(1996,1,1) 
            };
           
            IGamerService gamerManager = new GamerManager(new VerificationService());
            gamerManager.Save(gamer1);
            IVerificationService verificationService = new VerificationService();
            verificationService.Verification(gamer1);

            Game game1 = new Game()
            {
                Id = 1,
                GameName = "Genshin Impact",
                GameCategory = "Action RPG",
                Price=25.5
            };

            GameManager gameManager = new GameManager();
            gameManager.Add(game1, gamer1);


            Campaign campaign1 = new Campaign()
            {
                Id = 1,
                CampaignName = "2 al 1 öde",
                CampaignDiscount = 10
            };

            
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);

            GameSaleManager gameSaleManager = new GameSaleManager();
            gameSaleManager.Sale(game1, gamer1, campaign1);

        }
    }
}
