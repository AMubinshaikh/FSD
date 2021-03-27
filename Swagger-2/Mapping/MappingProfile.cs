
using AutoMapper;
using Swagger_2.Models;
using Swagger_2.Controllers.Resources;

namespace Swagger_2.Mapping {
    public class MappingProfile : Profile {
        public MappingProfile () {
            CreateMap<Customers, CustomerResource> ();
            CreateMap<CreateCustomerResource, Customers> ();
            CreateMap<UpdateCustomerResource, Customers> ();
            CreateMap<Customers, UpdateCustomerResource> ();
            CreateMap<OrderItemNotes, OrderItemNoteResource> ();
            CreateMap<OrderItems, OrderItemResource> ();
            CreateMap<Orders, OrderResource> ();
            CreateMap<OrderStatuses, OrderStatusResource> ();
            CreateMap<Products, ProductResource> ();
            CreateMap<Shippers, ShipperResource> ();
        }
    }
} 