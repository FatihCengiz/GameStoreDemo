using GameStoreDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreDemo.Concrete
{
    public interface IVerificationService
    {
        public bool Verification(Gamer gamer);
    }
}
