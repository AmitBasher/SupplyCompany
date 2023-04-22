namespace SupplyCompany.Domain.Models.customer
{
    public sealed class CustomerId : ID<CustomerId> {
        public CustomerId(Guid value) : base(value) {
        }

        public static CustomerId Create() => new (Guid.NewGuid());
    }
}