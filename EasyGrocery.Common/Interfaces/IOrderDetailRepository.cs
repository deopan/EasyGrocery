using EasyGrocery.Common.Entities;

namespace EasyGrocery.Common.Interfaces
{
    public interface IOrderDetailRepository
    {
        Task<bool> AddOrderDetail(List<OrderDetailEntity> orderDetailEntity);

        
    }
}
