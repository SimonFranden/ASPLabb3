
namespace ASPLabb3_DataAcces.Models
{
    public class Interest
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
