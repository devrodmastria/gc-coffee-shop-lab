namespace CoffeeShopRegistration.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public bool topTenCustomer { get; set; }

        public void setCustomer(bool topCustomer)
        {
            this.topTenCustomer = topCustomer;
        }
    }
}
