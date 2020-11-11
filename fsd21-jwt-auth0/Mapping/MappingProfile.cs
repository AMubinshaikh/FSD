using AutoMapper;
using fsd21_jwt_auth0.Models;
using fsd21_jwt_auth0.Controllers.Resources;

namespace fsd16_http_methods_webapi.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customers, CustomerResource>();
        }
    }
}