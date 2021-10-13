using GameProject.Abstract;
using GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class CampaingManager : ICampaingService
    {
        public void Add(Campaing campaing)
        {
            Console.WriteLine(campaing.CampaingName + " added");
        }

        public void Delete(Campaing campaing)
        {
            Console.WriteLine(campaing.CampaingName + " deleted");
        }

        public void Update(Campaing campaing)
        {
            Console.WriteLine(campaing.CampaingName + " updated");
        }
    }
}
