using System;
using System.Collections.Generic;
using fsd16.Models;

namespace fsd16.Resources {
    public class OrderResource {
        public OrderResource () {
            OrderItems = new HashSet<OrderItemResource> ();
        }

        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public byte Status { get; set; }
        public string Comments { get; set; }
        public DateTime? ShippedDate { get; set; }
        public short? ShipperId { get; set; }
        public virtual Customers Customer { get; set; }
        public virtual Shippers Shipper { get; set; }
        public virtual OrderStatuses StatusNavigation { get; set; }
        public virtual ICollection<OrderItemResource> OrderItems { get; set; }
    }
}