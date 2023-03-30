using WebApplication1.Entities;
using WebApplication1.Enums;

namespace WebApplication1.DTOs
{
    public class OrderDTO
    {
        public int Quantity { get; set; }
        public PizzaType Pizza { get; set; }
        public string Address { get; set; }
       
    }
}
