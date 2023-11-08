using System.ComponentModel.DataAnnotations;

namespace EasyGrocery.Common.Entities
{
    public class CartItemEntity
    {
        public int Type { get; set; }
        public int? CustomerId { get; set; }
        public int? ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime? CreatedDate { get; set; }
        public decimal Price { get; set; }

        public bool IsLoyaltyMemberShip { get; set; }

    }
}
