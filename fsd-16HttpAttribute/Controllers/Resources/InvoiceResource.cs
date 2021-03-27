using System;
using System.Collections.Generic;
using fsd_16HttpAttribute.Controllers.Resources;
using fsd_16HttpAttribute.Models;

namespace fsd_16HttpAttribute.Controllers.Resources {
    public class InvoiceResource {
        public InvoiceResource () {

            Payments = new HashSet<PaymentResource> ();
        }
        public int InvoiceId { get; set; }
        public string Number { get; set; }
        public int ClientId { get; set; }
        public decimal InvoiceTotal { get; set; }
        public decimal PaymentTotal { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? PaymentDate { get; set; }
        public virtual Clients Client { get; set; }
        public virtual ICollection<PaymentResource> Payments { get; set; }
    }
}