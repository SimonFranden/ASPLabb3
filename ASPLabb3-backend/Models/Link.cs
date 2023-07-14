using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPLabb3_backend.Models
{
    public class Link
    {
        public int Id { get; set; }
        public int LinkAdress { get; set; }
        public int InterestId { get; set; }
        public Interest Interest { get; set; }
    }
}
