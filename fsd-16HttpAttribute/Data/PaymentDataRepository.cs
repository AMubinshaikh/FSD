using System;
using System.Collections.Generic;
using System.Linq;
using fsd_16HttpAttribute.Models;

namespace fsd_16HttpAttribute.Data
{
    public class PaymentDataRepository : IPaymentDataRepository
    {
        private readonly sql_invoicingContext context;
        public PaymentDataRepository(sql_invoicingContext context)
        {
            this.context = context;

        }

        public void CreatePayment(Payments payments)
        {
             if (payments == null) {
                throw new ArgumentNullException (nameof (payments));
            }
            context.Payments.Add(payments);
        }

        public void DeletePayment(Payments payments)
        {
            if (payments == null) {
              throw new ArgumentNullException (nameof (payments));
            }
            context.Payments.Remove(payments);
        }

        public IEnumerable<Payments> GetAllPayments() => context.Payments.ToList();
       
        public Payments GetPaymentById(int Id)
        {
             return context.Payments.FirstOrDefault(c => c.PaymentId == Id);
        }

        public bool SaveChanges()
        {
             return(context.SaveChanges() >=0);
        }

        public void UpdatePayment(Payments payments)
        {
            
        }
    }
}