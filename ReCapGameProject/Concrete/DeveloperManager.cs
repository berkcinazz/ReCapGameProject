using ReCapGameProject.Abstract;
using ReCapGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapGameProject.Concrete
{
    public class DeveloperManager:BasePersonManager
    {
        public override void Add(Person person)
        {
            base.Add(person);
        }
        public override void Delete(Person person)
        {
            base.Delete(person);
        }
        public override void Update(Person person)
        {
            base.Update(person);
        }
    }
}
