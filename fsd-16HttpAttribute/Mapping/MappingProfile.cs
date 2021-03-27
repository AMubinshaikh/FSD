using AutoMapper;
using fsd_16HttpAttribute.Controllers.Resources;
using fsd_16HttpAttribute.Models;

namespace fsd_16HttpAttribute.Mapping {
    public class MappingProfile : Profile {
        public MappingProfile () {
            //clients mapping
            CreateMap<Clients, ClientResource> ();
            CreateMap<CreateClientResource, Clients> ();
            CreateMap<UpdateClientResource, Clients> ();
            CreateMap<Clients, UpdateClientResource> ();

            //invoices mapping
            CreateMap<Invoices, InvoiceResource> ();
            CreateMap<CreateInvoiceResource, Invoices> ();
            CreateMap<UpdateInvoiceResource, Invoices> ();
            CreateMap<Invoices, UpdateInvoiceResource> ();

            //payments mapping
            CreateMap<Payments, PaymentResource> ();
            CreateMap<CreatePaymentResource, Payments> ();
            CreateMap<UpdatePaymentResource, Payments> ();
            CreateMap<Payments, UpdatePaymentResource> ();

            //paymentMethods mapping
            CreateMap<PaymentMethods, PaymentMethodsResource> ();
            CreateMap<CreatePaymentMethods, PaymentMethods> ();
            CreateMap<UpdatePaymentMethodsResource, PaymentMethods> ();
            CreateMap<PaymentMethods, UpdatePaymentMethodsResource> ();

        }
    }
}