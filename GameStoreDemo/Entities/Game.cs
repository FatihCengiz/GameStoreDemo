using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreDemo.Entities
{
    public class Game
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public string GameCategory { get; set; }
        public double Price { get; set; }
    }
}
