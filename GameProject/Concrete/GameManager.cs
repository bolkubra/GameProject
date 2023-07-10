using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GameManager : IGameService
    {
        public void Sale(Gamer gamer, Game game, Campaign campaign)
        {

            Console.WriteLine(gamer.GamerName + " " + gamer.GamerLastName + " kişisine" + " " + game.GameName + " adlı oyun, " + campaign.CampaignName + " kampanyasıyla yüzde " + campaign.CampaignPercentage + " indirim fiyatı ile " +
                (game.GamePrice - (game.GamePrice * (campaign.CampaignPercentage / 100))) + "TL'ye satılmıştır");
        }
        public void Add (Game game)
        {
            Console.WriteLine(game.GameName + "Adlı Oyun Eklendi");
        }
        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + "Adlı Oyun Silindi");
        }
        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + "Adlı Oyun Güncellendi");
        }
    }
}
