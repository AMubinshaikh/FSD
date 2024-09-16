namespace fsd21_jwt_auth0.Controllers.Resources
{
    public class CustomerResource
    {
         public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Pin { get; set; }
        public string Phone { get; set; }
    }
}