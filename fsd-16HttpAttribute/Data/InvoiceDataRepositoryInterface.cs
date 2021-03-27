using System.Collections.Generic;
using fsd_16HttpAttribute.Models;
namespace fsd_16HttpAttribute.Data {
    public interface InvoiceDataRepositoryInterface {
        bool SaveChanges ();
        IEnumerable<Invoices> GetAllInvoices ();
        Invoices GetInvoiceById (int Id);
        void CreateInvoice (Invoices invoice);
        void UpdateInvoice (Invoices invoice);
        void DeleteInvoice (Invoices invoice);

    }
}