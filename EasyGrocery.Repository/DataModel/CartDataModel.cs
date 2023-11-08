using EasyGrocery.Common.Entities;

namespace EasyGrocery.Repository.DataModel
{
    public class CartDataModel
    {
        public int CustomerId { get; set; }
        public List<CartItemEntity> Items { get; set; }
    }
}
