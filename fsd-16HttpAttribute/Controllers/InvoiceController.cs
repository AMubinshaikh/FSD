using System.Collections.Generic;
using AutoMapper;
using fsd_16HttpAttribute.Controllers.Resources;
using fsd_16HttpAttribute.Data;
using fsd_16HttpAttribute.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace fsd_16HttpAttribute.Controllers {
    [Route ("/api/invoice")]
    public class InvoiceController : Controller {
        private readonly InvoiceDataRepositoryInterface repo;

        private readonly IMapper mapper;
        public InvoiceController (InvoiceDataRepositoryInterface repo, IMapper mapper) {
            this.repo = repo;
            this.mapper = mapper;

        }

        [HttpGet]
        public ActionResult<IEnumerable<Invoices>> GetAllInvoices () {
            var invoiceList = repo.GetAllInvoices ();
            return Ok (mapper.Map<IEnumerable<InvoiceResource>> (invoiceList));
        }

        [HttpGet ("{id}", Name = "GetInvoiceById")]
        public ActionResult<InvoiceResource> GetInvoiceById (int id) {
            var invoiceData = repo.GetInvoiceById (id);
            if (invoiceData != null) {
                return Ok (mapper.Map<InvoiceResource> (invoiceData));
            }
            return NotFound ();
        }

        [HttpPost]
        public ActionResult<InvoiceResource> CreateInvoice (CreateInvoiceResource createInvoiceResource) {
            var invoiceModel = mapper.Map<Invoices> (createInvoiceResource);
            repo.CreateInvoice (invoiceModel);
            repo.SaveChanges ();

            var invoiceDataReader = mapper.Map<InvoiceResource> (invoiceModel);
            return CreatedAtRoute (nameof (GetInvoiceById), new { Id = invoiceDataReader.InvoiceId }, invoiceDataReader);
        }

        [HttpPut ("{id}")]
        public ActionResult UpdateInvoice (int id, UpdateInvoiceResource updateInvoiceResource) {

            var invoiceModelFromRepository = repo.GetInvoiceById (id);
            if (invoiceModelFromRepository == null) {
                return NotFound ();
            }
            mapper.Map (updateInvoiceResource, invoiceModelFromRepository);
            repo.UpdateInvoice (invoiceModelFromRepository);
            repo.SaveChanges ();
            return NoContent ();
        }

        [HttpPatch]
        public ActionResult PartialClientUpdate (int id, JsonPatchDocument<UpdateInvoiceResource> patchDoc) {
            var invoiceModelFromRepository = repo.GetInvoiceById (id);
            if (invoiceModelFromRepository == null) {
                return NotFound ();
            }
            var invoiceToPatch = mapper.Map<UpdateInvoiceResource> (invoiceModelFromRepository);
            patchDoc.ApplyTo (invoiceToPatch, ModelState);
            if (!TryValidateModel (invoiceToPatch)) {
                ValidationProblem (ModelState);
            }
            mapper.Map (invoiceToPatch, invoiceModelFromRepository);
            repo.UpdateInvoice (invoiceModelFromRepository);
            repo.SaveChanges ();
            return NoContent ();
        }

        [HttpDelete ("{id}")]
        public ActionResult DeleteInvoice (int id) {
            var invoiceModelFromRepository = repo.GetInvoiceById (id);
            if (invoiceModelFromRepository == null) {
                return NotFound ();
            }
            repo.DeleteInvoice (invoiceModelFromRepository);
            repo.SaveChanges ();
            return NoContent ();
        }
    }
}