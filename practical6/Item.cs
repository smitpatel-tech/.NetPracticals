using System;
using System.Collections.Generic;

namespace StoreInventorySystem.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public decimal Cost { get; set; }
        public string Section { get; set; }
    }
}