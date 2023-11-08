namespace ESasyGrocery.Service.Dto
{
    public class Shipping
    {
        public int CustomerId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }

        public string Country { get; set; }

        public string ZipCode { get; set; }
        public bool IsActive { get; set; }
    }
}
