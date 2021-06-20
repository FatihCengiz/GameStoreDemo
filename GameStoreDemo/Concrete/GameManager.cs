using GameStoreDemo.Abstract;
using GameStoreDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreDemo.Concrete
{
    public class GameManager : IGameManager
    {
        public void Add(Game game,Gamer gamer)
        {
            Console.WriteLine(game.GameName + " Oyunu Kütüphanenize Eklendi. Teşekkürler "+gamer.Name + " Bey" );
        }

        public void Delete(Game game, Gamer gamer)
        {
            Console.WriteLine(game.GameName + " Oyunu Kütüphanenizden Silindi. " + gamer.Name + " Bey");
        }

        public void Update(Game game, Gamer gamer)
        {
            Console.WriteLine(game.GameName + " Oyunu Güncellendi. " + gamer.Name + " Bey");
        }
    }
}
