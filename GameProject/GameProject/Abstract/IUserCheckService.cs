using GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IUserCheckService
    {
        public bool Validate(Gamer gamer);
    }
}
