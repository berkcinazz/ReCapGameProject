﻿using ReCapGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapGameProject.Abstract
{
    public interface ICampaign
    {
        void Campaign(Game game, Person person);
    }
}
