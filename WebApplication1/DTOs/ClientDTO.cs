namespace WebApplication1.DTOs
{
    public class ClientDTO
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int PizzaShopId { get; set; }
        public string PizzaShopName { get; set; }
        public List<OrderDTO> Orders { get; set; }
    }
}
