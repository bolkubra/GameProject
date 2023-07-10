using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IGameService
    {
        void Sale(Gamer gamer, Game game, Campaign campaign);
        void Add(Game game);
        void Update(Game game);
        void Delete(Game game);
    }
}
