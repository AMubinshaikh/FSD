using System.Collections.Generic;

namespace fsd_16HttpAttribute.Controllers.Resources {
    public class ClientResource {
        public ClientResource () {
            Invoices = new HashSet<InvoiceResource> ();
            Payments = new HashSet<PaymentResource> ();
        }

        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<InvoiceResource> Invoices { get; set; }
        public virtual ICollection<PaymentResource> Payments { get; set; }
    }
}