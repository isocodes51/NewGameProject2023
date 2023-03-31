using NewGameProject2023.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewGameProject2023.Abstract
{
    public interface ICampaignService
    {
        void Add(Campaigns campaign, Orders order, Games games);
        void Delete(Campaigns campaign, Orders order, Games games);
        void Update(Campaigns campaign, Orders order, Games games);

    }
}
