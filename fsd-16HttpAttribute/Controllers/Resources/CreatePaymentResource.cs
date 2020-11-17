using System;

namespace fsd_16HttpAttribute.Controllers.Resources {
    public class CreatePaymentResource {
        public int PaymentId { get; set; }
        public int ClientId { get; set; }
        public int InvoiceId { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public byte PaymentMethod { get; set; }
    }
}