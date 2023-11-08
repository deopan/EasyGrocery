using EasyGrocery.Common.Entities;
using MediatR;

namespace EasyGrocery.Service.Command
{
    public class DeleteCartCommand : IRequest<bool>
    {
        public CartItemEntity payload { get; set; }

    }
}
