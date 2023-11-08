using AutoMapper;
using EasyGrocery.Common.Interfaces;
using EasyGrocery.Service.Command;
using MediatR;

namespace EasyGrocery.Service.Handle
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, int>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public CreateOrderCommandHandler(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateOrderCommand command, CancellationToken cancellationtoken)
        {
            // var purchaseRequestDto = _mapper.Map<PurchaseRequestDto>(command);
            int Orderid = await _orderRepository.CreateOrder(command.payload);
            return Orderid;

        }

    }
}
