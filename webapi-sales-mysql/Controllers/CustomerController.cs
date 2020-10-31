using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webapi_sales_mysql.Models;

namespace webapi_sales_mysql.Controllers {
    [Route ("/api/customers")]
    public class CustomerController : Controller {
        private readonly salesContext context;
        public CustomerController (salesContext context) {
            this.context = context;
        }
        [HttpGet]
        public IEnumerable<Customers> GetCustomers () {
            return context.Customers;
        }
    }
}