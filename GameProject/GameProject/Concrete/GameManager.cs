using GameProject.Abstract;
using GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GameManager : IGameService
    {
        public void Sales(Gamer gamer, Game game,Campaing campaing)
        {
            Console.WriteLine(game.GameName +" was sold to "  + gamer.FirstName + " with " + campaing.CampaingName);
        }
    }
}
