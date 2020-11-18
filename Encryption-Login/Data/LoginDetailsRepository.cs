using System;
using System.Collections.Generic;
using System.Linq;
using Encryption_Login.Models;
using Org.BouncyCastle.Crypto.Generators;

namespace Encryption_Login.Data
{
    public class LoginDetailsRepository : ILoginDetailsRepository
    {
        private readonly logindbContext context;
        public LoginDetailsRepository(logindbContext context)
        {
            this.context = context;

        }
        public void CreateUser(Users user)
        {

            if(user==null)
            {
                throw new ArgumentNullException(nameof(user));
            }
           user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
            context.Users.Add(user);
        }

        public void DeleteUser(Users user)
        {
            if(user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            context.Users.Remove(user);
        }

        public IEnumerable<Users> GetAllUsers() => context.Users.ToList();
      

        public Users GetUserById(int Id)
        {
            return context.Users.FirstOrDefault(u => u.Id == Id);
        }

        public Users Login(Users user)
        {
           var userData = Global.Users.SingleOrDefault(u => u.Username == user.Username);
           bool IsValidPassword = BCrypt.Net.BCrypt.Verify(user.Password, userData.Password);
           if(IsValidPassword)
           {
               return userData;
           }
           return null;
        }

        public bool SaveChanges()
        {
            return (context.SaveChanges() >= 0);
        }

        public void UpdateUser(Users user)
        {
          
        }
    }
}