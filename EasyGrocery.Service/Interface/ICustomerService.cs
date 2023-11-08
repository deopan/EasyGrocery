using ESasyGrocery.Service.Dto;

namespace EasyGrocery.Service.Interface
{
    public interface ICustomerService
    {
        Task<ApiResponse<Customer>> GetCustomerById(Customer getOrderByIdQuery);
    }
}
