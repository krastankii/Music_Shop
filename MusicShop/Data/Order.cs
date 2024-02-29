﻿namespace MusicShop.Data
{
    public class Order
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Products { get; set; }
        public string ClientId { get; set; }
        public Client Clients { get; set; }
        public int Quantity { get; set; }
        public DateTime DataUpdate { get; set; } = DateTime.Now;
    }
}
