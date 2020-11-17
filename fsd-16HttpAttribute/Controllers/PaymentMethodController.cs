using System.Collections.Generic;
using AutoMapper;
using fsd_16HttpAttribute.Controllers.Resources;
using fsd_16HttpAttribute.Data;
using fsd_16HttpAttribute.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace fsd_16HttpAttribute.Controllers {
    [Route ("/api/paymentmethods")]
    public class PaymentMethodController : Controller {

        private readonly IPaymentMethodsRepository repo;
        private readonly IMapper mapper;
        public PaymentMethodController (IPaymentMethodsRepository repo, IMapper mapper) {
            this.mapper = mapper;
            this.repo = repo;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PaymentMethods>> GetAllPaymentMethods () {
            var paymentMethodsList = repo.GetAllPaymentMethods ();
            return Ok (mapper.Map<IEnumerable<PaymentMethods>> (paymentMethodsList));
        }

        [HttpGet ("{id}", Name = "GetPaymentMethodById")]
        public ActionResult<PaymentMethodsResource> GetPaymentMethodById (int id) {
            var paymentMethodsData = repo.GetPaymentMethodById (id);
            if (paymentMethodsData != null) {
                return Ok (mapper.Map<PaymentMethodsResource> (paymentMethodsData));
            }
            return NotFound ();
        }

        [HttpPost]
        public ActionResult<PaymentMethods> CreatePaymentMethods (CreatePaymentMethods createPaymentMethods) {
            var paymentMethodsModel = mapper.Map<PaymentMethods> (createPaymentMethods);
            repo.CreatePaymentMethods (paymentMethodsModel);
            repo.SaveChanges ();

            var paymentMethodsDataReader = mapper.Map<PaymentMethodsResource> (paymentMethodsModel);
            return CreatedAtRoute (nameof (GetPaymentMethodById), new { Id = paymentMethodsDataReader.PaymentMethodId }, paymentMethodsDataReader);
        }

        [HttpPut ("{id}")]
        public ActionResult UpdatePaymentMethods (int id, UpdatePaymentMethodsResource updatePaymentMethodsResource) {

            var paymentMethodsModelFromRepository = repo.GetPaymentMethodById (id);
            if (paymentMethodsModelFromRepository == null) {
                return NotFound ();
            }
            mapper.Map (updatePaymentMethodsResource, paymentMethodsModelFromRepository);
            repo.UpdatePaymentMethods (paymentMethodsModelFromRepository);
            repo.SaveChanges ();
            return NoContent ();
        }

        [HttpPatch]
        public ActionResult PartialPaymentMethodsUpdate (int id, JsonPatchDocument<UpdatePaymentMethodsResource> patchDoc) {
            var paymentMethodsModelFromRepository = repo.GetPaymentMethodById (id);
            if (paymentMethodsModelFromRepository == null) {
                return NotFound ();
            }
            var paymentMethodstToPatch = mapper.Map<UpdatePaymentMethodsResource> (paymentMethodsModelFromRepository);
            patchDoc.ApplyTo (paymentMethodstToPatch, ModelState);
            if (!TryValidateModel (paymentMethodstToPatch)) {
                ValidationProblem (ModelState);
            }
            mapper.Map (paymentMethodstToPatch, paymentMethodsModelFromRepository);
            repo.UpdatePaymentMethods (paymentMethodsModelFromRepository);
            repo.SaveChanges ();
            return NoContent ();
        }

        [HttpDelete ("{id}")]
        public ActionResult DeletePaymentMethods (int id) {
            var paymentMethodsModelFromRepository = repo.GetPaymentMethodById (id);
            if (paymentMethodsModelFromRepository == null) {
                return NotFound ();
            }
            repo.DeletePaymentMethods (paymentMethodsModelFromRepository);
            repo.SaveChanges ();
            return NoContent ();
        }

    }
}