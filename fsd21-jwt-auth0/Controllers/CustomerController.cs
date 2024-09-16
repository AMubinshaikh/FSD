using System.Collections.Generic;
using fsd21_jwt_auth0.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace fsd21_jwt_auth0.Controllers {

    [Route ("/api/customers")]
    
    public class CustomerController : Controller {
        private readonly salesContext context;
        public CustomerController (salesContext context) {
            this.context = context;

        }

        [HttpGet]
        [Authorize]
        public IEnumerable<Customers> GetCustomers()
        {
           return context.Customers;
        }
    }
}