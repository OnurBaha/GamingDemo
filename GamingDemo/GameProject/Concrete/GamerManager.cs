using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class GamerManager : IGamerService
    {
        IGamerCheckService _gamerCheckService;
        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }
        public void Create (Gamer gamer)
        {
            if(_gamerCheckService.Validate(gamer))
            {
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " Created.");
            }
            else
            {
                Console.WriteLine("User Not Found.");
            }
        }
        public void Delete (Gamer gamer) 
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName);
        }
        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName);
        }
    }
}
