using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public  class Game : IEntitys
    {
        public Game(int id, string gamename, int gameprice)
        { 
            GameId = id;    
            GameName = gamename;
            GamePrice = gameprice;
        }
        public int GameId { get; set; }
        public string GameName { get; set; }
        public int GamePrice { get; set; } 
    }
}
