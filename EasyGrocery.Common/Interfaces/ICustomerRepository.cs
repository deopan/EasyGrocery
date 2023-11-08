using EasyGrocery.Common.Entities;

namespace EasyGrocery.Common.Interfaces
{
    public interface ICustomerRepository
    {
         Task<CustomerEntity> GetCustomerById(int CustomerId);
        Task<bool> ActiveCustomerMemberShip(int CustomerId);


    }
}
