using ReCapGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapGameProject.Abstract
{
    public interface IPersonService
    {
        void Add(Person person);
        void Delete(Person person);
        void Update(Person person);

    }
}
