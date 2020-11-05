using System;
using System.Collections.Generic;

namespace fsd16.Models {
    public partial class Shippers {
        public Shippers () {
            Orders = new HashSet<Orders> ();
        }

        public short ShipperId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}