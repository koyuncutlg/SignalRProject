using SignalR.EntitiyLayer.Entities;

namespace SignalR.EntityLayer.Entities
{
	public class OrderDetial
	{
        public int OrderDetialID { get; set; }
        public int ProductID { get; set; }
        public Product Product  { get; set; }
        public int Count { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public int OrderID { get; set; }
        public Order Order { get; set; }
    }
}