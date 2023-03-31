using NewGameProject2023.Concrete;
using NewGameProject2023.Entity;
using System;

namespace NewGameProject2023
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamers gamer1 = new Gamers
            {
             Id=1,
             NationalityId="12345678901",
             FirstName="Kamil",
             LastName="Başer"
            };

            Orders order1 = new Orders
            {
                OrderId = 1,
                OrderName = "AOE II Empires Game now Available!",
                Price = 15.25
                    
            };

            Games game1 = new Games
            {
                GameId = 1,
                GameName = "AOE II Empires",
                Price = 40
            };

            Campaigns campaigns1 = new Campaigns
            {
                CampaignId = 1,
                CampaignName = "Campaign 1",
                CampaignRatio = 10
            };

            //GamerManager gamerManager = new GamerManager();
            //gamerManager.Add(gamer1);

            OrderManager orderManager = new OrderManager();
            orderManager.Add(order1, gamer1);

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaigns1, order1, game1);
        }
    }
}
