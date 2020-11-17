using System;
using System.Collections.Generic;

namespace fsd_16HttpAttribute.Models {
    public partial class PaymentMethods {
        public PaymentMethods () {
            Payments = new HashSet<Payments> ();
        }

        public byte PaymentMethodId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Payments> Payments { get; set; }
    }
}