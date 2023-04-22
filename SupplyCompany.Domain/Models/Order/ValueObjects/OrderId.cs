namespace SupplyCompany.Domain.Models.order
{
    public sealed class OrderId : ID<OrderId> {
        public OrderId(Guid value) : base(value) {
        }

        public static OrderId Create() => new (Guid.NewGuid());
    }
}