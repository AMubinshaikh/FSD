using System.Collections.Generic;
using fsd_16HttpAttribute.Models;
namespace fsd_16HttpAttribute.Data {
    public interface IClientsDataRepository {
        bool SaveChanges ();
        IEnumerable<Clients> GetAllClients ();
        Clients GetClientById (int Id);
        void CreateClient (Clients clients);
        void UpdateClient (Clients clients);
        void DeleteClient (Clients clients);

    }
}