using ASPLabb2.Data;
using ASPLabb3_backend.Services;
using Microsoft.EntityFrameworkCore;

namespace ASPLabb3_backend
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new DataContext();
            var personService = new PersonService(dbContext);

            personService.GetAllPersons();
        }
    }
}