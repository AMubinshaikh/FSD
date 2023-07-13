using AutoMapper;
using Encryption_Login.Controllers.Resource;
using Encryption_Login.Models;

namespace Encryption_Login.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Users, UserResource>();
            CreateMap<CreateUserResource, Users>();
            CreateMap<ValidateUserResource, Users>();
        }
    }
}