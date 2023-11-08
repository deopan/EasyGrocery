using ESasyGrocery.Service.Dto;

namespace EasyGrocery.Service.Interface
{
    public interface IShippingService
    {
      Task<ApiResponse<int>> InsertShippingAddress(Shipping shipping);

        Task<ApiResponse<List<Shipping>>> GetShippingData(int CustomerId);

    }
}
