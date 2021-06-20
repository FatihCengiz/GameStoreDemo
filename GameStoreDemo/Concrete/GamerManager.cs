using GameStoreDemo.Abstract;
using GameStoreDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreDemo.Concrete
{
    public class GamerManager : IGamerService
    {
        
        public GamerManager()
        {

        }

        private IVerificationService _verificationService;


        public GamerManager(IVerificationService verificationService)
        {
            _verificationService = verificationService;
        }
        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer deleted to system : " + gamer.Name);
        }

        public void Save(Gamer gamer)
        {
            if (_verificationService.Verification(gamer)==true)
            { 
                Console.WriteLine("Gamer saved to system : " + gamer.Name); 
            }
            else
            {
                Console.WriteLine("You cannot save to system. ");
            }
         
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer updated to system : " + gamer.Name);
        }
    }
}
