using System.Collections.Generic;

namespace fsd_16HttpAttribute.Controllers.Resources {
    public class PaymentMethodsResource {
        public PaymentMethodsResource () {
            Payments = new HashSet<PaymentResource> ();
        }

        public byte PaymentMethodId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<PaymentResource> Payments { get; set; }
    }
}