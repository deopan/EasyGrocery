using EasyGrocery.Common.Entities;
using MediatR;

namespace EasyGrocery.Service.Command
{
    public class CreateOrderCommand : IRequest<int>
    {
        public OrderEntity payload { get; set; }
    }
}
