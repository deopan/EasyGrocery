using EasyGrocery.Common.Entities;
using MediatR;

namespace EasyGrocery.Service.Query
{
    public class GetCustomerByIdQuery : IRequest<CustomerEntity>
    {
        public int CustomerId { get; set; }
    }
}
