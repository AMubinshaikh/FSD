 using System.Collections.Generic;
 using System;
 using Microsoft.AspNetCore.Mvc;
 namespace CircuitBreaker.Controllers {
     [Route ("api/[controller]")]
     public class ValuesController : Controller {
         // GET api/values
         [HttpGet]
         public ActionResult  Get () {
             throw new Exception ("Error");
         }
     }
 }