using System.Collections.Generic;
using fsd16.Models;

namespace fsd16.Data {
  public interface ISqlStoreRepository {
    bool SaveChanges ();
    IEnumerable<Customers> GetAllCustomers ();
    Customers GetCustomersById (int Id);
    void CreateCustomer (Customers customer);
    void UpdateCustomers (Customers customer);
    void DeleteCustomer (Customers customer);
  }
}