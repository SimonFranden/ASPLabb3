using ASPLabb3_DataAcces;
using ASPLabb3_DataAcces.Models;
using ASPLabb3_DataAcces.Services;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonService personService = new();

            //Hämta alla personer i systemet
            Console.WriteLine("Hämta alla personer i systemet");
            var personList = personService.GetAllpersons();
            foreach(PersonDTO p in personList)
            {
                Console.WriteLine(p.Name);
            }

            //Hämta alla intressen som är kopplade till en specifik person
            Console.WriteLine("Hämta alla intressen som är kopplade till en specifik person");

            var interestList = personService.GetPersonInterests(2);
            foreach (Interest i in interestList)
            {
                Console.WriteLine(i.Title);
            }

            //Hämta alla länkar som är kopplade till en specifik person
            Console.WriteLine("Hämta alla länkar som är kopplade till en specifik person");
            var linkList = personService.GetPersonLinks(1);
            foreach (Link l in linkList)
            {
                Console.WriteLine(l.LinkAdress);
            }

            
        }
    }
}