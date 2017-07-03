using webservice.Infrastructure.Interface;

namespace webservice.Infrastructure.Model
{
    public class User : IEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
    }
}