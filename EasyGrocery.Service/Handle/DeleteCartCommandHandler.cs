using EasyGrocery.Common.Interfaces;
using EasyGrocery.Service.Command;
using MediatR;

namespace EasyGrocery.Service.Handle
{
    public class DeleteCartCommandHandler : IRequestHandler<DeleteCartCommand, bool>
    {
        public readonly ICartRepository _cartRepository;
        public DeleteCartCommandHandler(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }
        public async Task<bool> Handle(DeleteCartCommand request, CancellationToken cancellationToken)
        {
            return await _cartRepository.Delete(request.payload.CustomerId.Value);
        }
    }
}
