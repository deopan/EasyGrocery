using AutoMapper;
using EasyGrocery.Common.Entities;
using EasyGrocery.Service.Command;
using EasyGrocery.Service.Interface;
using EasyGrocery.Service.Query;
using ESasyGrocery.Service.Dto;
using MediatR;
using System.Net;

namespace EShop.Application.Services
{
    public class ShippingService : IShippingService
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        public ShippingService(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        public async Task<ApiResponse<List<Shipping>>> GetShippingData(int CustomerId)
        {
            List<Shipping> shippinglist = new List<Shipping>();

            var result = await _mediator.Send(new GetShippingAddressByIdQuery { CustomerId = CustomerId });
            shippinglist = _mapper.Map<List<Shipping>>(result);
            if (shippinglist!=null && shippinglist.Count > 0)
            {
                return new ApiResponse<List<Shipping>>()
                {
                    Data = shippinglist,
                    StatusCode = (int)(HttpStatusCode.OK),
                    HasError = false,
                    Error = string.Empty
                };
            }
            else
            {
                return new ApiResponse<List<Shipping>>()
                {
                    Data = shippinglist,
                    StatusCode = (int)(HttpStatusCode.NoContent),
                    HasError = true,
                    Error = "No data found"
                };
            }
        }

        public async Task<ApiResponse<int>> InsertShippingAddress(Shipping shipping)
        {
            //convert shipping dto to entity 
            ShippingEntity shippingEntity = new ShippingEntity();
            shippingEntity = _mapper.Map<ShippingEntity>(shipping);
            CreateShippingCommand createShippingCommand = new CreateShippingCommand() { payload = shippingEntity };
            var order = await _mediator.Send(createShippingCommand);
            return new ApiResponse<int>
            {
                Data = order
            };
        }

    }
}
