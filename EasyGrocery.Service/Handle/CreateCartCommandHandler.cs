using AutoMapper;
using EasyGrocery.Common.Interfaces;
using EasyGrocery.Service.Command;
using MediatR;

namespace EasyGrocery.Service.Handle
{
    public class CreateCartCommandHandler : IRequestHandler<CreateCartCommand, bool>
    {
        private readonly ICartRepository _cartRepository;
        private readonly IMapper _mapper;
        public CreateCartCommandHandler(ICartRepository cartRepository, IMapper mapper)
        {
            _mapper = mapper;
            _cartRepository = cartRepository;
        }
        public async Task<bool> Handle(CreateCartCommand command, CancellationToken cancellationToken)
        {

            var CartId = await _cartRepository.AddCartItem(command.payload);
            return CartId;

        }
    }
}
