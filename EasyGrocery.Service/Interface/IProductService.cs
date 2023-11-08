using ESasyGrocery.Service.Dto;

namespace EasyGrocery.Service.Interface
{
    public interface IProductService
    {
        Task<ApiResponse<List<GroceryItem>>> GetProductList();
    }
}
