using ReCapGameProject.Abstract;
using ReCapGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapGameProject.Concrete
{
    public class CampaignManager:BaseSalesManager
    {
        public override void Sell(Person person, Campaign campaign)
        {
            base.Sell(person, campaign);
        }
    }
}
