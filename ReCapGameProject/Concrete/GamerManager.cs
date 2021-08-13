using ReCapGameProject.Abstract;
using ReCapGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapGameProject.Concrete
{
    public class GamerManager:BasePersonManager
    {
        public override void Delete(Person person)
        {
            base.Delete(person);
        }
    }
}
