using EasyGrocery.Common.Entities;

namespace EasyGrocery.Common.Interfaces
{
    public interface IShippingRepository
    {
       Task<int> InsertShippingData(ShippingEntity shipping);
        Task<List<ShippingEntity>> GetShippingData(int CustomerId);

    }
}
