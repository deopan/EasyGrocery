using EasyGrocery.Common.Entities;
using MediatR;

namespace EasyGrocery.Service.Command
{
    public class CreateOrderDetailCommand : IRequest<bool>
    {
        public  List<OrderDetailEntity> payload { get; set; }
    }
}
