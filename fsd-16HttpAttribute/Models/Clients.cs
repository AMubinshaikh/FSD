using System;
using System.Collections.Generic;

namespace fsd_16HttpAttribute.Models {
    public partial class Clients {
        public Clients () {
            Invoices = new HashSet<Invoices> ();
            Payments = new HashSet<Payments> ();
        }

        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Invoices> Invoices { get; set; }
        public virtual ICollection<Payments> Payments { get; set; }
    }
}