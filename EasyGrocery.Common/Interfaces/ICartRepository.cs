using EasyGrocery.Common.Entities;

namespace EasyGrocery.Common.Interfaces
{
    public interface ICartRepository
    {
       Task<bool> AddCartItem(CartEntity cartEntity);

        Task<List<CartItemEntity>> getCartItem(int CustomerID);
        Task<bool> Delete(int CustomerId);

    }
}
