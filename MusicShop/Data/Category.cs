﻿namespace MusicShop.Data
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DataUpdate { get; set; } = DateTime.Now;
        public ICollection<Product> Products{ get; set; }
    }
}
