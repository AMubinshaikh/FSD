using System;
using System.Collections.Generic;

namespace Swagger_2.Models
{
    public partial class Products
    {
        public Products()
        {
            OrderItems = new HashSet<OrderItems>();
        }

        public int ProductId { get; set; }
        public string Name { get; set; }
        public int QuantityInStock { get; set; }
        public decimal UnitPrice { get; set; }

        public virtual ICollection<OrderItems> OrderItems { get; set; }
    }
}
