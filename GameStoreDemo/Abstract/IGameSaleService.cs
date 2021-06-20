using GameStoreDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreDemo.Abstract
{
    public interface IGameSaleService
    {
        void Sale(Game game,Gamer gamer,Campaign campaign);
    }
}
