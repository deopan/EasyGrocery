using EasyGrocery.Common.Entities;
using MediatR;

namespace EasyGrocery.Service.Query
{
    public class GetShippingAddressByIdQuery : IRequest<List<ShippingEntity>>
    {
        public int CustomerId { get; set; }

    }
}
