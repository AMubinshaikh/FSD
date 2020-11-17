using System;
using System.Collections.Generic;

namespace fsd_16HttpAttribute.Models {
    public partial class Payments {
        public int PaymentId { get; set; }
        public int ClientId { get; set; }
        public int InvoiceId { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public byte PaymentMethod { get; set; }

        public virtual Clients Client { get; set; }
        public virtual Invoices Invoice { get; set; }
        public virtual PaymentMethods PaymentMethodNavigation { get; set; }
    }
}