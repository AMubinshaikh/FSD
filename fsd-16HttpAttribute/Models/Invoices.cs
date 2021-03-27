using System;
using System.Collections.Generic;

namespace fsd_16HttpAttribute.Models {
    public partial class Invoices {
        public Invoices () {
            Payments = new HashSet<Payments> ();
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
        public virtual ICollection<Payments> Payments { get; set; }
    }
}