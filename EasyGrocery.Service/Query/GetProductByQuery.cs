using EasyGrocery.Common.Entities;
using MediatR;

namespace EasyGrocery.Service.Query
{
    public class GetProductByQuery : IRequest<List<GroceryItemEntity>>
    {
    }
}
