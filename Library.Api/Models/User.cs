namespace Library.Api.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public HashSet<RentBook> RentBooks { get; set; }

    }
}
