using ESasyGrocery.Service.Dto;

namespace EasyGrocery.Service.Interface
{
    public interface ICartService
    {
        Task<ApiResponse<bool>> AddCartItems(Cart cart);

        Task<ApiResponse<List<CartItem>>> GetCartItem(int CustomerId);
        Task<ApiResponse<List<string>>> ValidatCartInvalidData(Cart cart);
    }
}
