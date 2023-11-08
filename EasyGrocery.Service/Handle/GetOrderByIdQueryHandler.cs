using EasyGrocery.Common.Entities;
using EasyGrocery.Common.Interfaces;
using EasyGrocery.Service.Query;
using MediatR;

namespace EasyGrocery.Service.Handle
{
    public class GetOrderByIdQueryHandler : IRequestHandler<GetOrderByIdQuery, List<OrderEntity>>
    {
        private readonly IOrderRepository _orderRepository;
        public GetOrderByIdQueryHandler(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public async Task<List<OrderEntity>> Handle(GetOrderByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _orderRepository.GetOrder(request.OrderId);
            return result;

        }
    }
}
