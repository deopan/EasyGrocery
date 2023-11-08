using EasyGrocery.Common.Entities;
using MediatR;

namespace EasyGrocery.Service.Query
{
    public class GetCartItemQuery : IRequest<List<CartItemEntity>>
    {

        public int CustomerId { get; set; }

    }
}
