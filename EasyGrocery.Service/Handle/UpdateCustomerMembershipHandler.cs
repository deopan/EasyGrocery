using EasyGrocery.Common.Interfaces;
using EasyGrocery.Service.Command;
using MediatR;

namespace EasyGrocery.Service.Handle
{
    public class UpdateCustomerMembershipHandler : IRequestHandler<UpdateCustomerMembershipCommand, bool>
    {
        private readonly ICustomerRepository _customerRepository;
        public UpdateCustomerMembershipHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public async Task<bool> Handle(UpdateCustomerMembershipCommand request, CancellationToken cancellationToken)
        {
            return await _customerRepository.ActiveCustomerMemberShip(request.payload.CustomerId);
        }
    }
}
