using System;

namespace fsd_16HttpAttribute.Controllers.Resources {
    public class PaymentResource {
        public int PaymentId { get; set; }
        public int ClientId { get; set; }
        public int InvoiceId { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public byte PaymentMethod { get; set; }

        public virtual ClientResource Client { get; set; }
        public virtual InvoiceResource Invoice { get; set; }
        public virtual PaymentMethodsResource PaymentMethodNavigation { get; set; }
    }
}