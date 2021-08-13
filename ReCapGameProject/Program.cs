using ReCapGameProject.Abstract;
using ReCapGameProject.Concrete;
using System;

namespace ReCapGameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            BasePersonManager personManager = new GamerManager();
            personManager.Update(new Entities.Person { FirstName="Berk",LastName="Cinaz", DateOfBirth= new DateTime(2000,8,25),Id=1,NationalityId="123213123"});

            Console.ReadLine();
        }
    }
}
