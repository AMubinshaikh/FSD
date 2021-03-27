
using System.Collections.Generic;
using AutoMapper;
using Swagger_2.Data;
using Swagger_2.Models;
using Swagger_2.Controllers.Resources;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Swagger_2.Controllers {
    [Route ("/api/customers")]
    public class CustomerController : Controller {
        private readonly ISqlStoreRepository repo;
        private readonly IMapper mapper;
        public CustomerController (ISqlStoreRepository repo, IMapper mapper) {
            this.mapper = mapper;
            this.repo = repo;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CustomerResource>> GetAllCustomers () {
            var customerList = repo.GetAllCustomers ();
            return Ok (mapper.Map<IEnumerable<CustomerResource>> (customerList));
        }

        [HttpGet ("{id}", Name = "GetCustomerById")]
        public ActionResult<CustomerResource> GetCustomerById (int id) {
            var customerData = repo.GetCustomersById (id);
            if (customerData != null) {
                return Ok (mapper.Map<CustomerResource> (customerData));
            }
            return NotFound ();
        }

        [HttpPost]
        public ActionResult<CustomerResource> CreateCustomer (CreateCustomerResource createCustomerResource) {
            var customerModel = mapper.Map<Customers> (createCustomerResource);
            repo.CreateCustomer (customerModel);
            repo.SaveChanges ();

            var customerDataReader = mapper.Map<CustomerResource> (customerModel);
            return CreatedAtRoute (nameof (GetCustomerById), new { Id = customerDataReader.CustomerId }, customerDataReader);
        }

        [HttpPut ("{id}")]
        public ActionResult UpdateCustomer (int id, UpdateCustomerResource updateCustomer) {
            var customerModelFromRepo = repo.GetCustomersById (id);
            if (customerModelFromRepo == null) {
                return NotFound ();
            }
            mapper.Map (updateCustomer, customerModelFromRepo);
            repo.UpdateCustomers (customerModelFromRepo);
            repo.SaveChanges ();
            return NoContent ();

        }

        [HttpPatch ("{id}")]
        public ActionResult PartialCustomersUpdate (int id, JsonPatchDocument<UpdateCustomerResource> patchDoc) {

            var customerModelFromRepo = repo.GetCustomersById (id);
            if (customerModelFromRepo == null) {
                return NotFound ();
            }
            var customerToPatch = mapper.Map<UpdateCustomerResource> (customerModelFromRepo);
            patchDoc.ApplyTo (customerToPatch, ModelState);
            if (!TryValidateModel (customerToPatch)) {
                ValidationProblem (ModelState);
            }
            mapper.Map (customerToPatch, customerModelFromRepo);
            repo.UpdateCustomers (customerModelFromRepo);
            repo.SaveChanges ();
            return NoContent ();
        }

        // Delete Customer
        [HttpDelete ("{id}")]
        public ActionResult DeleteCustomer (int id) {
            var customerModelFromRepo = repo.GetCustomersById (id);
            if (customerModelFromRepo == null) {
                return NotFound ();
            }
            repo.DeleteCustomer (customerModelFromRepo);
            repo.SaveChanges ();
            return NoContent ();
        }

    }
} 