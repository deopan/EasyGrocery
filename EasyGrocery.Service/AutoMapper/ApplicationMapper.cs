using AutoMapper;
using EasyGrocery.Service.Command;
using ESasyGrocery.Service.Dto;
using EasyGrocery.Repository.DataModel;
using EasyGrocery.Common.Entities;

namespace ESasyGrocery.Service.AutoMapper
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<PurchaseRequestDto, CreateOrderCommand>().ReverseMap();
            CreateMap<CreateCartCommand, CartPurchaseItems>().ReverseMap();
            CreateMap<Cart, CartEntity>().ReverseMap();
            CreateMap<Order, OrderEntity>().ReverseMap();
            CreateMap<GroceryItem, GroceryItemEntity>().ReverseMap();
            CreateMap<Customer, CustomerEntity>().ReverseMap();
            CreateMap<CartItem, CartItemEntity>().ReverseMap();
            //CreateMap<CartEntity, CartDataItemModel>();
            CreateMap<ProductDataModel, GroceryItemEntity>().ReverseMap();
            CreateMap<ShippingDetailDataModel, ShippingEntity>().ReverseMap();
            CreateMap<Dto.Shipping, ShippingEntity>().ReverseMap();
            CreateMap<OrderEntity, OrderDataModel>().ReverseMap();
            //CreateMap<CartEntity, CartDataModel>().ReverseMap();

            CreateMap<CartItemEntity, CartDataItemModel>()
                            .ReverseMap();

            CreateMap<OrderDetailEntity, OrderDetailDataModel>()
                            .ReverseMap();

            CreateMap<CustomerDataModel, CustomerEntity>()
                            .ReverseMap();

            CreateMap<ShippingSlipDataModel, OrderEntity>()
                            .ReverseMap();

        }
    }
}
    

