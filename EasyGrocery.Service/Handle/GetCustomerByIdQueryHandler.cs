using EasyGrocery.Common.Entities;
using EasyGrocery.Common.Interfaces;
using EasyGrocery.Service.Query;
using MediatR;

namespace EasyGrocery.Service.Handler
{
    public class GetCustomerByIdQueryHandler : IRequestHandler<GetCustomerByIdQuery, CustomerEntity>
    {
        private readonly ICustomerRepository _customerRepository;
        public GetCustomerByIdQueryHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public async Task<CustomerEntity> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
        {

            var customer = await _customerRepository.GetCustomerById(request.CustomerId);
            return customer;

        }
    }
}
