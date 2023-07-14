using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPLabb3_backend.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TelephoneNumber { get; set; }
        public List<Interest> Interests { get; set; }
    }
}
