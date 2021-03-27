
using System.Collections.Generic;

namespace Swagger_2.Controllers.Resources {
    public class ShipperResource {
        public ShipperResource () {
            Orders = new HashSet<OrderResource> ();
        }

        public short ShipperId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<OrderResource> Orders { get; set; }
    }
} 