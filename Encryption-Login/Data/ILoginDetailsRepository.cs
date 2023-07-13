using System.Collections.Generic;
using Encryption_Login.Models;

namespace Encryption_Login.Data {
    public interface ILoginDetailsRepository {
        bool SaveChanges ();
        IEnumerable<Users> GetAllUsers ();
        Users GetUserById (int Id);
        void CreateUser (Users user);
        void UpdateUser (Users user);
        void DeleteUser (Users user);
        Users Login(Users user);

    }
}