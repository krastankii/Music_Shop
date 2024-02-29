using Microsoft.AspNetCore.Identity;

namespace MusicShop.Data
{
    public class Client:IdentityUser
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        ICollection<Order> Orders { get; set; }

    }
}
