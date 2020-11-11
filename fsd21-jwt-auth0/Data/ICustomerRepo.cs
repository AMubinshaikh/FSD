using System.Collections.Generic;
using fsd21_jwt_auth0.Models;

namespace fsd16_http_methods_webapi.Data
{
    public interface ICustomerRepo
    {
         bool SaveChanges();
         IEnumerable<Customers> GetAllCustomers();
         Customers GetCustomerById(int id);
         void CreateCustomer(Customers customer);
         
    }
}