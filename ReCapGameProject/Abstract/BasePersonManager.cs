using ReCapGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapGameProject.Abstract
{
    public abstract class BasePersonManager : IPersonService
    {
        public virtual void Add(Person person)
        {
            Console.WriteLine(person.FirstName + "Person is added");
        }

        public virtual void Delete(Person person)
        {
            Console.WriteLine(person.FirstName + "Person is deleted");

        }

        public virtual void Update(Person person)
        {
            Console.WriteLine(person.FirstName + "Person is updated");

        }
    }
}
