namespace WebApplication1.Entities
{
    public class PizzaShop
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Client> Clients { get; set; }
    }
}
