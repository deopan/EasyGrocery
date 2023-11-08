using EasyGrocery.Common.Entities;
using MediatR;

namespace EasyGrocery.Service.Command
{
    public class CreateShippingCommand : IRequest<int>
    {
      public  ShippingEntity payload { get; set; }
    }
}
