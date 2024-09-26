using System.Collections.Generic;
using System.Threading.Tasks;
using fsd_18_caching.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace fsd_18_caching.Controllers
{

   
    [Route("/api/customers")]
    public class CustomerController : Controller
    {
        private readonly sql_storeContext context;
        private readonly IMemoryCache memoryCache;
        public CustomerController(sql_storeContext context, IMemoryCache memoryCache)
        {
            this.memoryCache = memoryCache;
            this.context = context;
        }
        public IActionResult GetAllCustomers()
        {
           var customers = new List<Customers>();
           if(!memoryCache.TryGetValue("CustomerList", out customers))
           {
              
               // checking if it is not initialize so we need to re initialize
               if(customers == null)
               {
                   
                   customers = new List<Customers>();
                   
               }
               memoryCache.Set("CustomerList", customers);
           }
            return Json(customers);
            
        }

        [HttpGet]
        public IEnumerable<Customers> AllCustomers()
        {
            var customers = context.Customers;
            return customers;

        }
    }
}