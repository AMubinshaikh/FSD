using System;
using System.Collections.Generic;

namespace Swagger_2.Models
{
    public partial class Orders
    {
        public Orders()
        {
            OrderItems = new HashSet<OrderItems>();
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
        public virtual ICollection<OrderItems> OrderItems { get; set; }
    }
}
