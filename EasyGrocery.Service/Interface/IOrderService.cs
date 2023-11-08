using ESasyGrocery.Service.Dto;
using Microsoft.AspNetCore.Mvc;

namespace EasyGrocery.Service.Interface
{
    public interface IOrderService
    {
        Task<ApiResponse<int>> CreatePurchaseOrder(Order order);

        Task<bool> GenerateSlipIfRequired(Order order);

        Task<ApiResponse<List<string>>> ValidateOrderData(Order order);



    }
}
