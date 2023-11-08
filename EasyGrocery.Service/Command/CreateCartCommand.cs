using EasyGrocery.Common.Entities;
using MediatR;

namespace EasyGrocery.Service.Command
{
    public class CreateCartCommand : IRequest<bool>
    {
       public  CartEntity payload { get; set; }
    }
}
