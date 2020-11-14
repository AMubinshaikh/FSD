
using System.Collections.Generic;

namespace Swagger_2.Controllers.Resources {
    public class OrderStatusResource {
        public OrderStatusResource () {
            Orders = new HashSet<OrderResource> ();
        }

        public byte OrderStatusId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<OrderResource> Orders { get; set; }
    }
} 