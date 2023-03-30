using System;
using WebApplication1.Database;
using WebApplication1.Entities;
using WebApplication1.Enums;

namespace WebApplication1.Repositories
{

    public class ClientRepository
    {
        public List<Client> GetAll()
        {
            var results = DbContext.Clients;

            return results;
        }

        public Client GetById(int clientId)
        {
            var result = DbContext.Clients
                .Where(e => e.Id == clientId)
                .FirstOrDefault();

            return result;
        }

        public Client GetByIdWithOrders(int clientId, PizzaType type)
        {
            var result = DbContext.Clients
               .Select(e => new Client
               {
                   FirstName = e.FirstName,
                   LastName = e.LastName,
                   Id = e.Id,
                   PizzaShopId = e.PizzaShopId,
                   Orders = e.Orders
                        .Where(g => g.Pizza == type)
                        .OrderByDescending(g => g.Quantity)
                        .ToList()
               })
               .FirstOrDefault(e => e.Id == clientId);

            return result;
        }

        public Client DeleteClient(int clientId)
        {
            var result = DbContext.Clients
           .FirstOrDefault(e => e.Id == clientId);
            if (result != null)
            {
                DbContext.Clients.Remove(result);
                return result;
            }

            return null;
        }
    }

}
