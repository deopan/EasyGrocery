using EasyGrocery.Common.Entities;
using EasyGrocery.Common.Interfaces;
using EasyGrocery.Service.Query;
using MediatR;

namespace EasyGrocery.Service.Handle
{
    public class GetShippingAddressByIdQueryHandler : IRequestHandler<GetShippingAddressByIdQuery, List<ShippingEntity>>
    {
        private readonly IShippingRepository _shippingRepository;
        public GetShippingAddressByIdQueryHandler(IShippingRepository shippingRepository)
        {
            _shippingRepository = shippingRepository;
        }

        public async Task<List<ShippingEntity>> Handle(GetShippingAddressByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _shippingRepository.GetShippingData(request.CustomerId);
            return result;
        }
    }
}
