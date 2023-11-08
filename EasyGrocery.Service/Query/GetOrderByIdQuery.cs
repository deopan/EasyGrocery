using EasyGrocery.Common.Entities;
using MediatR;

namespace EasyGrocery.Service.Query
{
    public class GetOrderByIdQuery : IRequest<List<OrderEntity>>
    {
        public int OrderId { get; set; }
    }
}
