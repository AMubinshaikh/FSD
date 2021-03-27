using System;
using System.Collections.Generic;
using System.Linq;
using fsd_16HttpAttribute.Models;

namespace fsd_16HttpAttribute.Data
{
    public class PaymentMethodsDataRepository : IPaymentMethodsRepository
    {
        private readonly sql_invoicingContext context;
        public PaymentMethodsDataRepository(sql_invoicingContext context)
        {
            this.context = context;
        }

        public void CreatePaymentMethods (PaymentMethods paymentMethods) {
            if (paymentMethods == null) {
                throw new ArgumentNullException (nameof (paymentMethods));
            }
            context.PaymentMethods.Add(paymentMethods);
        }

        public void DeletePaymentMethods (PaymentMethods paymentMethods) {
            if (paymentMethods == null) {
              throw new ArgumentNullException (nameof (PaymentMethods));
            }
            context.PaymentMethods.Remove(paymentMethods);
        }

        public IEnumerable<PaymentMethods> GetAllPaymentMethods () => context.PaymentMethods.ToList();

    

        public PaymentMethods GetPaymentMethodById (int Id) {
            return context.PaymentMethods.FirstOrDefault(c => c.PaymentMethodId == Id);
        }

        public bool SaveChanges () {
           return(context.SaveChanges() >=0);
        }

        public void UpdatePaymentMethods (PaymentMethods paymentMethods) {
           
        }

    }
}