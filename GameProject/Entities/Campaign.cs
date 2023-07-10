using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class Campaign : IEntitys 
    {
        public Campaign(int id, string campaignname, float campaignp)
        {
            CampaignId = id;
            CampaignName = campaignname;
            CampaignPercentage = campaignp;
        }
        public  int CampaignId { get; set; }
        public string CampaignName { get; set; }
        public float CampaignPercentage { get; set; }
    }
}
