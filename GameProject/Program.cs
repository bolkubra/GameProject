using GameProject.Concrete;
using GameProject.Entities;
using System;
using System.Threading;

namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager();
            Gamer gamer1 = new Gamer(1, "kubra", "bol",new DateTime(1997,08,20), 12548);
            gamerManager.Add(gamer1);

            CampaingManager campaingManager = new CampaingManager();
            Campaign campaign1 = new Campaign(1,"1.oyunum" , 50);
            campaingManager.Add(campaign1);

            GameManager gameManager = new GameManager();
            Game game1 = new Game(1,"Angr Birds",10);
            gameManager.Add(game1);
            gameManager.Sale(gamer1, game1, campaign1);


        }
    }
}
