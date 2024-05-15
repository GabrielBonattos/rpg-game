using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Controllers
{
     public class GameSessionController
    {
        public Player CurrentPlayer { get; set; }

       public GameSessionController()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Gabriel";
            CurrentPlayer.CharacterClass = "Monk";
            CurrentPlayer.HitPoints = 10;
            CurrentPlayer.Gold = 1000000;
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.Level = 1;
        }
    }
}
