using EasyGrocery.Common.Entities;

namespace EasyGrocery.Common.Interfaces
{
    public interface IProductRepository
    {
       Task<List<GroceryItemEntity>> GetProductList();
    }
}
