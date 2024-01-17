﻿namespace SignalR.EntityLayer.Entities
{
	public class Order
	{
        public int OrderID { get; set; }
        public string TableNumber { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalPrice { get; set; }
        public List<OrderDetial> OrderDetials { get; set; }
    }
}