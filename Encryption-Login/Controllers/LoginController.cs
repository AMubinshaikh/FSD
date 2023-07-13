using System.Collections.Generic;
using AutoMapper;
using Encryption_Login.Controllers.Resource;
using Encryption_Login.Data;
using Encryption_Login.Models;
using Microsoft.AspNetCore.Mvc;

namespace Encryption_Login.Controllers {
    [Route ("/api/users")]
    public class LoginController : Controller {
        private readonly ILoginDetailsRepository repository;
        private readonly IMapper mapper;
        public LoginController (ILoginDetailsRepository repository, IMapper mapper) {
            this.mapper = mapper;
            this.repository = repository;
        }

      [HttpGet]
        public ActionResult<IEnumerable<Users>> GetAllUsers () {
            var userList = repository.GetAllUsers ();
            return Ok (mapper.Map<IEnumerable<UserResource>> (userList));
        }
      [HttpGet("{id}", Name="GetUserById")]
      public ActionResult<UserResource> GetUserById(int id)
      {
          //TODO: Implement Realistic Implementation
          var userData = repository.GetUserById(id);
          if(userData != null)
          {
              return Ok(mapper.Map<UserResource> (userData));
          }
          return NotFound();
      }

      [HttpPost]
      public ActionResult<UserResource> CreateUser(CreateUserResource createUserResource)
      {
          //TODO: Implement Realistic Implementation
          var userModel = mapper.Map<Users> (createUserResource);
            repository.CreateUser (userModel);
            repository.SaveChanges ();

            var userDataReader = mapper.Map<UserResource> (userModel);
            return CreatedAtRoute (nameof (GetUserById), new { Id = userDataReader.Id }, userDataReader);
      }

        [HttpPost("Login")]
       public ActionResult<UserResource> Login(ValidateUserResource validateUserResource)
        {
            var userLogin = mapper.Map<Users> (validateUserResource);
             repository.Login (userLogin);
             var userDataReader = mapper.Map<UserResource> (userLogin);
             return CreatedAtRoute (nameof (GetUserById), new { Id = userDataReader.Id }, userDataReader);
        } 
    }
}