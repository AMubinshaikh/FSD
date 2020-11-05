using System;
using System.Collections.Generic;

namespace fsd16.Models {
    public partial class OrderStatuses {
        public OrderStatuses () {
            Orders = new HashSet<Orders> ();
        }

        public byte OrderStatusId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}