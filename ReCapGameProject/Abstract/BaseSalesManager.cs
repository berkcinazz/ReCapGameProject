using ReCapGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapGameProject.Abstract
{
    public abstract class BaseSalesManager : ISalesService
    {
        public virtual void Sell(Person person, Campaign campaign)
        {
            Console.WriteLine("Your campaign is"+campaign.CampaignName + "Dear" + person.FirstName) ;
        }

        
    }
}
