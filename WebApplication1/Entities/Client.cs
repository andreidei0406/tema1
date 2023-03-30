using System.Diagnostics;
using System.Security.Claims;

namespace WebApplication1.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public int PizzaShopId { get; set; }
        public PizzaShop PizzaShop { get; set; }
        public List<Order> Orders { get; set; }

    }
}
