using GameProject.Concrete;
using GameProject.Entity;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseGamerManager gamerManager = new GamerManager(new UserValidationManager());
            Gamer gamer = new Gamer { BirthOfDate = new DateTime(1996, 3, 12), FirstName = "Berkan", LastName = "Yıldırım", IdentityNumber = 28828689900 };
            //gamerManager.Add(gamer);
            //gamerManager.Delete(gamer);
            //gamerManager.Update(gamer);

            CampaingManager campaingManager = new CampaingManager();
            Campaing campaing = new Campaing { CampaingName = "%10 indirim" };
            campaingManager.Add(campaing);
            campaingManager.Delete(campaing);
            campaingManager.Update(campaing);
            Game game = new Game();
            game.GameName = "GTA 5";
            game.GamePrice = 75;
            GameManager gameManager = new GameManager();
            gameManager.Sales(gamer, game, campaing);
            Console.ReadLine();
        }
    }
}
