using AutoMapper;
using EasyGrocery.Service.Interface;
using EasyGrocery.Service.Query;
using ESasyGrocery.Service.Dto;
using MediatR;
using System.Net;

namespace EShop.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IMediator _mediator;

        private readonly IMapper _mapper;

        public ProductService(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }


        public async Task<ApiResponse<List<GroceryItem>>> GetProductList()
        {
            List<GroceryItem> products = new List<GroceryItem>();
            var result = await _mediator.Send(new GetProductByQuery());
            products = _mapper.Map<List<GroceryItem>>(result);
            return new ApiResponse<List<GroceryItem>>()
            {
                Data = products,
                HasError = false,
                Error = string.Empty,
                StatusCode = (int)HttpStatusCode.OK
            };
        }
    }
}
