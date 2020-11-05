using System;
using System.Collections.Generic;

namespace fsd16.Resources {
    public class CustomerResource {
        public CustomerResource () {
            Orders = new HashSet<OrderResource> ();
        }

        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Points { get; set; }

        public virtual ICollection<OrderResource> Orders { get; set; }
    }
}