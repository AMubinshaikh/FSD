using System.Collections.Generic;

namespace Swagger_2.Controllers.Resources {
    public class ProductResource {
        public ProductResource () {
            OrderItems = new HashSet<OrderItemResource> ();
        }

        public int ProductId { get; set; }
        public string Name { get; set; }
        public int QuantityInStock { get; set; }
        public decimal UnitPrice { get; set; }

        public virtual ICollection<OrderItemResource> OrderItems { get; set; }
    }
} 