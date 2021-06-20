using GameStoreDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreDemo.Abstract
{
    public interface IGameManager
    {
        public void Add(Game game,Gamer gamer);
        public void Update(Game game, Gamer gamer);
        public void Delete(Game game, Gamer gamer);
    }
}
