namespace EasyGrocery.Common.Entities
{
    public class GroceryItemEntity
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public bool IsActive { get; set; }
    }
}
