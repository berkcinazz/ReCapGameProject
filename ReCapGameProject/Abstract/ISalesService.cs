using ReCapGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapGameProject.Abstract
{
    public interface ISalesService
    {
        void Sell(Person person, Campaign campaign);
    }
}
