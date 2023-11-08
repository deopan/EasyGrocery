using EasyGrocery.Common.Entities;
using EasyGrocery.Common.Interfaces;
using EasyGrocery.Service.Query;
using MediatR;

namespace EasyGrocery.Service.Handle
{
    public class GetProductQueryHandler : IRequestHandler<GetProductByQuery, List<GroceryItemEntity>>
    {
        private readonly IProductRepository _productRepository;
        public GetProductQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<GroceryItemEntity>> Handle(GetProductByQuery request, CancellationToken cancellationToken)
        {
            var products = await _productRepository.GetProductList();
            return products;
        }

    }
}
