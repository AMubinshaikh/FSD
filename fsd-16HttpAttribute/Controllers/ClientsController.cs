using System.Collections.Generic;
using AutoMapper;
using fsd_16HttpAttribute.Controllers.Resources;
using fsd_16HttpAttribute.Data;
using fsd_16HttpAttribute.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace fsd_16HttpAttribute.Controllers {
    [Route ("/api/clients")]
    public class ClientsController : Controller {
        private readonly IClientsDataRepository repo;
        private readonly IMapper mapper;
        public ClientsController (IClientsDataRepository repo, IMapper mapper) {
            this.mapper = mapper;
            this.repo = repo;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Clients>> GetAllClients () {
            var clientList = repo.GetAllClients ();
            return Ok (mapper.Map<IEnumerable<ClientResource>> (clientList));
        }

        [HttpGet ("{id}", Name = "GetClientById")]
        public ActionResult<ClientResource> GetClientById (int id) {
            var clientData = repo.GetClientById (id);
            if (clientData != null) {
                return Ok (mapper.Map<ClientResource> (clientData));
            }
            return NotFound ();
        }

        [HttpPost]
        public ActionResult<ClientResource> CreateClient (CreateClientResource createClientResource) {
            var clientModel = mapper.Map<Clients> (createClientResource);
            repo.CreateClient (clientModel);
            repo.SaveChanges ();

            var clientDataReader = mapper.Map<ClientResource> (clientModel);
            return CreatedAtRoute (nameof (GetClientById), new { Id = clientDataReader.ClientId }, clientDataReader);
        }

        [HttpPut ("{id}")]
        public ActionResult UpdateClient (int id, UpdateClientResource updateClientResource) {

            var clientModelFromRepository = repo.GetClientById (id);
            if (clientModelFromRepository == null) {
                return NotFound ();
            }
            mapper.Map (updateClientResource, clientModelFromRepository);
            repo.UpdateClient (clientModelFromRepository);
            repo.SaveChanges ();
            return NoContent ();
        }

        [HttpPatch]
        public ActionResult PartialClientUpdate (int id, JsonPatchDocument<UpdateClientResource> patchDoc) {
            var clientModelFromRepository = repo.GetClientById (id);
            if (clientModelFromRepository == null) {
                return NotFound ();
            }
            var clientToPatch = mapper.Map<UpdateClientResource> (clientModelFromRepository);
            patchDoc.ApplyTo (clientToPatch, ModelState);
            if (!TryValidateModel (clientToPatch)) {
                ValidationProblem (ModelState);
            }
            mapper.Map (clientToPatch, clientModelFromRepository);
            repo.UpdateClient (clientModelFromRepository);
            repo.SaveChanges ();
            return NoContent ();
        }

        [HttpDelete ("{id}")]
        public ActionResult DeleteClient (int id) {
            var clientModelFromRepository = repo.GetClientById (id);
            if (clientModelFromRepository == null) {
                return NotFound ();
            }
            repo.DeleteClient (clientModelFromRepository);
            repo.SaveChanges ();
            return NoContent ();
        }

    }
}