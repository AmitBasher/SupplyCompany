namespace SupplyCompany.Domain.Models.Customer
{
    public sealed class Customer : User {
        public Location ShippingAddress { get; }
        public Location BillingAddress { get; }

        private readonly List<SupplyRequestId> _supplyRequests = new();
        public IReadOnlyList<SupplyRequestId> SupplyRequests => 
            _supplyRequests.AsReadOnly();
            
        private Customer(
            UserId Id,
            string FirstName,
            string LastName,
            string Email,
            string Password,
            Location ShippingAddress,
            Location BillingAddress) :
            base(Id,FirstName,LastName,Email,Password){
            this.ShippingAddress = ShippingAddress;
            this.BillingAddress = BillingAddress;
        }
        public static Customer Create(
            string FirstName,
            string LastName,
            string Email,
            string Password,
            Location ShippingAddress,
            Location BillingAddress) {

            //ToDo:Validations

            var customer = new Customer(
                UserId.Create(),
                FirstName,
                LastName,
                Email,
                Password,
                ShippingAddress,
                BillingAddress
            );
            UserFactory.CreateNew(customer);
            return customer;
        }
    }
}