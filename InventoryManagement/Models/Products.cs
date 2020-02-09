using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Models
{
    public partial class Products
    {
        public long ProductId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Color { get; set; }
        public decimal UnitPrice { get; set; }
        public long AvailableQuantity { get; set; }
        [DataType(DataType.Date)]
        public DateTime CratedDate { get; set; }
    }
}
