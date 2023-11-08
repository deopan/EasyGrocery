using EasyGrocery.Service.Handler;
using ESasyGrocery.Service.AutoMapper;
using EShop.Application.Services;
using ESasyGrocery.Service.Validation;
using EShop.Infrastructure.Repositories;
using FluentValidation;
using MediatR;
using OnlineLibraryShop.Application.CustomServices;
using EasyGrocery.Service.Interface;
using EasyGrocery.Service.Handle;
using EasyGrocery.Common.Interfaces;
using EasyGrocery.Repositories;
using EasyGrocery.Repository.ConnectionFactory;

namespace EasyGrocery.Api.Extensions
{
    public static class ApplicationServicesExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
       
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IGenerateSlip, GenerateSlip>();
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(CreateOrderCommandHandler).Assembly));
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(GetOrderByIdQueryHandler).Assembly));
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(CreateCartCommandHandler).Assembly));
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(GetCartQueryHandler).Assembly));
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(GetCustomerByIdQueryHandler).Assembly));
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(CreateOrderDetailCommandHandler).Assembly));
            services.AddValidatorsFromAssemblyContaining<CreateCartRequestCommandValidator>();
            services.AddValidatorsFromAssemblyContaining<CreateShippingCommandValidator>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddAutoMapper(typeof(ApplicationMapper));
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IDbConnectionFactory, SqlDBConnectionFactory>();
            services.AddScoped<ICartService, CartService>();
            services.AddScoped<ICartRepository, CartRepository>();
            services.AddScoped<IShippingRepository, ShippingRepository>();
            services.AddScoped<IShippingService, ShippingService>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IOrderDetailRepository, OrderDetailRepository>();




            return services;
        }
    }
}
