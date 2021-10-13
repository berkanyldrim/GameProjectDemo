using GameProject.Abstract;
using GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GamerManager:BaseGamerManager
    {
        IUserCheckService _userCheckSercice;

        public GamerManager (IUserCheckService userCheckService)
        {
            _userCheckSercice = userCheckService;
        }

        public override void Add(Gamer gamer)
        {
            if (_userCheckSercice.Validate(gamer))
            {
                base.Add(gamer);
            }
            else
            {
                throw new Exception(" not a valid person ");
            }

        }

        public override void Delete(Gamer gamer)
        {
            if (_userCheckSercice.Validate(gamer))
            {
                base.Delete(gamer);
            }
            else
            {
                throw new Exception(" not a valid person ");
            }

        }

        public override void Update(Gamer gamer)
        {
            if (_userCheckSercice.Validate(gamer))
            {
                base.Update(gamer);
            }
            else
            {
                throw new Exception(" not a valid person ");
            }

        }
    }
}
