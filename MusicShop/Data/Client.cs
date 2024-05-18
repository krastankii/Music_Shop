using Microsoft.AspNetCore.Identity;

namespace MusicShop.Data
{
    public class Client:IdentityUser
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DataUpdate { get; set; } = DateTime.Now;
        ICollection<Order> Orders { get; set; }

    }
}
