using NewGameProject2023.Abstract;
using NewGameProject2023.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewGameProject2023.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaigns campaign, Orders order, Games games)
        {
            Console.WriteLine(campaign.CampaignName + "added! Now "+games.GameName+ "Price: %"+ campaign.CampaignRatio+ " more cheaper!"   );
        }

        public void Delete(Campaigns campaign, Orders order, Games games)
        {
            Console.WriteLine(campaign.CampaignName + "added! Now " + games.GameName + "Price: " + campaign.CampaignRatio + " Deleted!");
        }

        public void Update(Campaigns campaign, Orders order, Games games)
        {
            Console.WriteLine(campaign.CampaignName + "added! Now " + games.GameName + "Price: " + campaign.CampaignRatio + " Updated");
        }

       
    }
}
