namespace SupplyCompany.Domain.Models.supplyRequest 
    {
    public sealed class SupplyRequestId : ID<SupplyRequestId>
    {
        public SupplyRequestId(Guid value) : base(value)
        {
        }
        public static SupplyRequestId Create() => new(Guid.NewGuid());
    }
}