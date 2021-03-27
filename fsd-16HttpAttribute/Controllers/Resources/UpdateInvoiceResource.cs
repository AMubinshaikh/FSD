using System;

namespace fsd_16HttpAttribute.Controllers.Resources {
    public class UpdateInvoiceResource {
        public int InvoiceId { get; set; }
        public string Number { get; set; }
        public int ClientId { get; set; }
        public decimal InvoiceTotal { get; set; }
        public decimal PaymentTotal { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? PaymentDate { get; set; }
    }
}