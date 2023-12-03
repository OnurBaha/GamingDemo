using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class GamerCheckManager : IGamerCheckService
    {
        public bool Validate (Gamer gamer )
        {
            if(gamer.Identity == "123")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
