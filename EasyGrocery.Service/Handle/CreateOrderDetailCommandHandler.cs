using EasyGrocery.Common.Interfaces;
using EasyGrocery.Service.Command;
using MediatR;

namespace EasyGrocery.Service.Handle
{
    public class CreateOrderDetailCommandHandler : IRequestHandler<CreateOrderDetailCommand, bool>
    {
        private readonly IOrderDetailRepository _orderDetailRepository;
        public CreateOrderDetailCommandHandler(IOrderDetailRepository orderDetailRepository)
        {
            _orderDetailRepository = orderDetailRepository;
        }
        public async Task<bool> Handle(CreateOrderDetailCommand request, CancellationToken cancellationToken)
        {
            return await _orderDetailRepository.AddOrderDetail(request.payload);
        }
    }
}
