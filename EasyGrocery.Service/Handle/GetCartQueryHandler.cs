using EasyGrocery.Common.Entities;
using EasyGrocery.Common.Interfaces;
using EasyGrocery.Service.Query;
using MediatR;

namespace EasyGrocery.Service.Handle
{
    public class GetCartQueryHandler : IRequestHandler<GetCartItemQuery, List<CartItemEntity>>
    {
        private readonly ICartRepository _cartRepository;
        public GetCartQueryHandler(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        public async Task<List<CartItemEntity>> Handle(GetCartItemQuery request, CancellationToken cancellationToken)
        {
            var result = await _cartRepository.getCartItem(request.CustomerId);
            return result;

        }
    }
}
