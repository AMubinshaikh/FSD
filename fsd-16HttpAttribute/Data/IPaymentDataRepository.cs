using System.Collections.Generic;
using fsd_16HttpAttribute.Models;

namespace fsd_16HttpAttribute.Data {
    public interface IPaymentDataRepository {
        bool SaveChanges ();
        IEnumerable<Payments> GetAllPayments ();
        Payments GetPaymentById (int Id);
        void CreatePayment (Payments payments);
        void UpdatePayment (Payments payments);
        void DeletePayment (Payments payments);

    }
}