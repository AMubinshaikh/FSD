using AutoMapper;
using webapi_sales_mysql.Controllers.Resources;
using webapi_sales_mysql.Models;

namespace webapi_sales_mysql.Mapping {
    public class MappingProfile : Profile {
        public MappingProfile () {
            CreateMap<Customers, CustomerResources> ();
        }
    }
}