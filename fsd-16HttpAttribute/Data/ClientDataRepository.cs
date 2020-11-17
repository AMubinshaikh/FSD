using System;
using System.Collections.Generic;
using System.Linq;
using fsd_16HttpAttribute.Models;

namespace fsd_16HttpAttribute.Data {
    public class ClientDataRepository : IClientsDataRepository {
        private readonly sql_invoicingContext context;
        public ClientDataRepository (sql_invoicingContext context) {
            this.context = context;

        }
        public void CreateClient (Clients clients) {
            if (clients == null) {
                throw new ArgumentNullException (nameof (clients));
            }
            context.Clients.Add (clients);
        }

        public void DeleteClient (Clients clients) {
            if (clients == null) {
                throw new ArgumentNullException (nameof (clients));
            }
            context.Clients.Remove (clients);
        }

        public IEnumerable<Clients> GetAllClients () => context.Clients.ToList ();

        public Clients GetClientById (int Id) {
            return context.Clients.FirstOrDefault (c => c.ClientId == Id);
        }

        public bool SaveChanges () {
            return (context.SaveChanges () >= 0);
        }

        public void UpdateClient (Clients clients) {

        }

    }
}