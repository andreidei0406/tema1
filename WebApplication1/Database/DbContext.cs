using System.Diagnostics;
using System.Security.Claims;
using WebApplication1.Entities;
using WebApplication1.Enums;

namespace WebApplication1.Database
{
    public static class DbContext
    {
        public static List<PizzaShop> Pizzashops = new List<PizzaShop>
        {
            new PizzaShop
            {
                Id = 1,
                Name = "Italiamo",
                Clients = new List<Client>
                {
                    new Client
                    {
                        Id = 1,
                        FirstName = "Andrei",
                        LastName = "Oprea",
                        PizzaShopId = 1,
                        Orders = new List<Order>
                        {
                            new Order
                            {
                                Id = 1,
                                Quantity= 1,
                                Pizza= PizzaType.Margherita,
                                ClientId = 1
                            },
                            new Order
                            {
                                Id = 2,
                                Quantity= 2,
                                Pizza= PizzaType.Hawaiian,
                                ClientId = 1
                            },
                               new Order
                            {
                                Id = 3,
                                Quantity= 3,
                                Pizza= PizzaType.Peperoni,
                                ClientId = 1
                            },
                        }
                    },
                    new Client
                    {
                        Id = 2,
                        FirstName = "Ioana",
                        LastName = "Andreea",
                        PizzaShopId = 1,
                        Orders = new List<Order>
                        {
                            new Order
                            {
                                Id = 4,
                                Quantity= 2,
                                Pizza = PizzaType.QuattroFormaggi,
                                ClientId = 2
                            },
                            new Order
                            {
                                Id = 5,
                                Quantity= 2,
                                Pizza = PizzaType.Hawaiian,
                                ClientId = 2
                            },
                            new Order
                            {
                                Id = 6,
                                Quantity= 4,
                                Pizza = PizzaType.Rustica,
                                ClientId = 2
                            },
                            new Order
                            {
                                Id = 7,
                                Quantity= 2,
                                Pizza = PizzaType.Peperoni,
                                ClientId = 2
                            },
                        }
                    },
                    new Client
                    {
                        Id = 3,
                        FirstName = "Maria",
                        LastName = "Butuca",
                        PizzaShopId = 1,
                        Orders = new List<Order>
                        {
                            new Order
                            {
                                Id = 8,
                                Quantity= 3,
                                Pizza = PizzaType.Margherita,
                                ClientId = 3
                            },
                        }
                    },
                    new Client
                    {
                        Id = 4,
                        FirstName = "Paul",
                        LastName = "Ionescu",
                        PizzaShopId = 1,
                        Orders = new List<Order>()
                    },
                    new Client
                    {
                        Id = 5,
                        FirstName = "Sandra",
                        LastName = "Maria",
                        PizzaShopId = 1,
                        Orders = new List<Order>()
                    },
                }
            },
            new PizzaShop
            {
                Id = 2,
                Name = "LaCuptor",
                Clients = new List<Client>
                {
                    new Client
                    {
                        Id = 6,
                        FirstName = "Titus",
                        LastName = "Andreescu",
                        PizzaShopId = 2,
                        Orders = new List<Order>()
                    },
                    new Client
                    {
                        Id = 7,
                        FirstName = "Sara",
                        LastName = "Ognean",
                        PizzaShopId = 2,
                        Orders = new List<Order>()
                    },
                    new Client
                    {
                        Id = 8,
                        FirstName = "Sanda",
                        LastName = "Dobre",
                        PizzaShopId = 2,
                        Orders = new List<Order>()
                    },
                    new Client
                    {
                        Id = 9,
                        FirstName = "Ion",
                        LastName = "Dan",
                        PizzaShopId = 2,
                        Orders = new List<Order>()
                    },
                    new Client
                    {
                        Id = 10,
                        FirstName = "Iulica",
                        LastName = "Costin",
                        PizzaShopId = 2,
                        Orders = new List<Order>()
                    },
                }
            }
        };

        public static List<Client> Clients = Pizzashops.SelectMany(x => x.Clients).ToList();

        public static List<Order> Orders = Pizzashops.SelectMany(x => x.Clients.SelectMany(x => x.Orders)).ToList();

    }
}

