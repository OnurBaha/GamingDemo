﻿using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " Added." );
        }
        public void Delete (Campaign campaign) 
        {
            Console.WriteLine(campaign.Name + " Deleted.");
        }
        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " Updated.");
        }
    }
}
