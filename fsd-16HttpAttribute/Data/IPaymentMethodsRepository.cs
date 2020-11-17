using System.Collections.Generic;
using fsd_16HttpAttribute.Models;

namespace fsd_16HttpAttribute.Data {
    public interface IPaymentMethodsRepository {
        bool SaveChanges ();
        IEnumerable<PaymentMethods> GetAllPaymentMethods ();
        PaymentMethods GetPaymentMethodById (int Id);
        void CreatePaymentMethods (PaymentMethods paymentMethods);
        void UpdatePaymentMethods (PaymentMethods paymentMethods);
        void DeletePaymentMethods (PaymentMethods paymentMethods);
    }
}