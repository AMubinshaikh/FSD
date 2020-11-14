using System.Collections.Generic;
using Swagger_2.Models;

namespace Swagger_2.Data {
  public interface ISqlStoreRepository {
    bool SaveChanges ();
    IEnumerable<Customers> GetAllCustomers ();
    Customers GetCustomersById (int Id);
    void CreateCustomer (Customers customer);
    void UpdateCustomers (Customers customer);
    void DeleteCustomer (Customers customer);
  }
} 