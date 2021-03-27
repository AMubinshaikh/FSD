using System.Collections.Generic;
using AutoMapper;
using fsd_16HttpAttribute.Controllers.Resources;
using fsd_16HttpAttribute.Data;
using fsd_16HttpAttribute.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace fsd_16HttpAttribute.Controllers {
    [Route ("/api/payments")]
    public class PaymentController : Controller {
        private readonly IPaymentDataRepository repo;
        private readonly IMapper mapper;
        public PaymentController (IPaymentDataRepository repo, IMapper mapper) {
            this.mapper = mapper;
            this.repo = repo;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Payments>> GetAllPayments () {
            var paymentList = repo.GetAllPayments ();
            return Ok (mapper.Map<IEnumerable<PaymentResource>> (paymentList));
        }

        [HttpGet ("{id}", Name = "GetPaymentById")]
        public ActionResult<PaymentResource> GetPaymentById (int id) {
            var paymentData = repo.GetPaymentById (id);
            if (paymentData != null) {
                return Ok (mapper.Map<PaymentResource> (paymentData));
            }
            return NotFound ();
        }

        [HttpPost]
        public ActionResult<PaymentResource> CreatePayment (CreatePaymentResource createPaymentResource) {
            var paymentModel = mapper.Map<Payments> (createPaymentResource);
            repo.CreatePayment (paymentModel);
            repo.SaveChanges ();

            var paymentDataReader = mapper.Map<PaymentResource> (paymentModel);
            return CreatedAtRoute (nameof (GetPaymentById), new { Id = paymentDataReader.PaymentId }, paymentDataReader);
        }

        [HttpPut ("{id}")]
        public ActionResult UpdatePayment (int id, UpdatePaymentResource updatePaymentResource) {

            var paymentModelFromRepository = repo.GetPaymentById (id);
            if (paymentModelFromRepository == null) {
                return NotFound ();
            }
            mapper.Map (updatePaymentResource, paymentModelFromRepository);
            repo.UpdatePayment (paymentModelFromRepository);
            repo.SaveChanges ();
            return NoContent ();
        }

        [HttpPatch]
        public ActionResult PartialPaymentUpdate (int id, JsonPatchDocument<UpdatePaymentResource> patchDoc) {
            var paymentModelFromRepository = repo.GetPaymentById (id);
            if (paymentModelFromRepository == null) {
                return NotFound ();
            }
            var paymentToPatch = mapper.Map<UpdatePaymentResource> (paymentModelFromRepository);
            patchDoc.ApplyTo (paymentToPatch, ModelState);
            if (!TryValidateModel (paymentToPatch)) {
                ValidationProblem (ModelState);
            }
            mapper.Map (paymentToPatch, paymentModelFromRepository);
            repo.UpdatePayment (paymentModelFromRepository);
            repo.SaveChanges ();
            return NoContent ();
        }

        [HttpDelete ("{id}")]
        public ActionResult DeletePayment (int id) {
            var paymentModelFromRepository = repo.GetPaymentById (id);
            if (paymentModelFromRepository == null) {
                return NotFound ();
            }
            repo.DeletePayment (paymentModelFromRepository);
            repo.SaveChanges ();
            return NoContent ();
        }
    }
}