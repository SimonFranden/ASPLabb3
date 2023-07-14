
namespace ASPLabb3_DataAcces.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TelephoneNumber { get; set; }
        public List<Interest> Interests { get; set; }
    }
}
