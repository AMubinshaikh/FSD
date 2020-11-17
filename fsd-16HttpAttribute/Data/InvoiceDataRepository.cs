using System;
using System.Collections.Generic;
using System.Linq;
using fsd_16HttpAttribute.Models;

namespace fsd_16HttpAttribute.Data {
    public class InvoiceDataRepository : InvoiceDataRepositoryInterface {
        private readonly sql_invoicingContext context;
        public InvoiceDataRepository (sql_invoicingContext context) {
            this.context = context;

        }
        public void CreateInvoice (Invoices invoice) {
            if (invoice == null) {
                throw new ArgumentNullException (nameof (invoice));
            }
            context.Invoices.Add (invoice);
        }

        public void DeleteInvoice (Invoices invoice) {
            if (invoice == null) {
                throw new ArgumentNullException (nameof (invoice));
            }
            context.Invoices.Remove (invoice);
        }

        public IEnumerable<Invoices> GetAllInvoices () => context.Invoices.ToList ();

        public Invoices GetInvoiceById (int Id) {
            return context.Invoices.FirstOrDefault (c => c.InvoiceId == Id);
        }

        public bool SaveChanges () {
            return (context.SaveChanges () >= 0);
        }

        public void UpdateInvoice (Invoices invoice) {

        }

    }
}