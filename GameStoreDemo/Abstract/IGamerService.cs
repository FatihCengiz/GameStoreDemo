using GameStoreDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreDemo.Abstract
{
    public interface IGamerService
    {
        public void Save(Gamer gamer);
        public void Update(Gamer gamer);

        public void Delete(Gamer gamer);
    }
}
