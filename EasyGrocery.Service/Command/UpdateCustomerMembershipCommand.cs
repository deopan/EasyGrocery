using EasyGrocery.Common.Entities;
using MediatR;

namespace EasyGrocery.Service.Command
{
    public class UpdateCustomerMembershipCommand : IRequest<bool>
    {
        public CustomerEntity payload { get; set; }
    }
}
