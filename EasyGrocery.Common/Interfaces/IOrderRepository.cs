using EasyGrocery.Common.Entities;

namespace EasyGrocery.Common.Interfaces
{
    public interface IOrderRepository
    {
        Task<int> CreateOrder(OrderEntity purchaseRequest);

        Task<List<OrderEntity>> GetOrder(int PurchaseOrderId);

    }
}
