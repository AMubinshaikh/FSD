using System;
using System.Collections.Generic;
using System.Linq;
using fsd16.Models;

namespace fsd16.Data {
    public class SqlCustomerRepository : ISqlStoreRepository {
        private readonly sql_storeContext context;
        public SqlCustomerRepository (sql_storeContext context) {
            this.context = context;

        }
        public void CreateCustomer (Customers customer) {
            if (customer == null) {
                throw new ArgumentNullException (nameof (customer));
            }
            context.Customers.Add (customer);

        }

        public void DeleteCustomer (Customers customer) {
            if (customer == null) {
                throw new ArgumentNullException (nameof (customer));
            }
            context.Customers.Remove (customer);
        }

        public IEnumerable<Customers> GetAllCustomers () => context.Customers.ToList ();
        //Join(c => c.CustomerId , o => o.CustomerId, (c, o) => new 
        // { FirstName=c.FirstName, 
        //LastName=c.LastName,
        // OrderDate = o.OrderDate }
        /// );
        //Where(c => c.Points > 3000 && c.CustomerId == 5);

        public Customers GetCustomersById (int Id) {
            return context.Customers.FirstOrDefault (c => c.CustomerId == Id);
        }

        public bool SaveChanges () {
            return (context.SaveChanges () >= 0);
        }

        public void UpdateCustomers (Customers customer) {

        }
    }
}