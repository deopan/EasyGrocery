namespace ESasyGrocery.Service.Dto
{
    public class Cart 
    {
        public int CustomerId { get; set; }
        public List<CartItem> Items { get; set; }
    }
}
