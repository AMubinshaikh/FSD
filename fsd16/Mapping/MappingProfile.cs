using AutoMapper;
using fsd16.Models;
using fsd16.Resources;

namespace fsd16.Mapping {
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