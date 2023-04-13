﻿namespace BelajarNextJsBackEnd.Models
{
    public class ProductDataGridItem
    {
        public string Id { get; set; } = "";

        public string Name { get; set; } = "";

        public string Description { get; set; } = "";

        public decimal Price { get; set; }

        public int Quantity { set; get; }

        public string BrandName { get; set; } = "";

        public DateTimeOffset CreatedAt { set; get; }
    }
}
