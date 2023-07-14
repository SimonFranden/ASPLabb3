using ASPLabb2.Data;
using ASPLabb3_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPLabb3_backend.Services
{
    public class PersonService
    {
        private readonly DataContext _context;

        public PersonService(DataContext context)
        {
            _context = context;
        }

        public List<Person> GetAllPersons()
        {
            var personList = _context.Persons.ToList();
            foreach(Person p in personList)
            {
                Console.WriteLine(p.Name);
            }
            return (personList);
        }
    }
}
