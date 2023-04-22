namespace SupplyCompany.Domain.Models.subProduct;

public sealed class SubProductId : ID<SubProductId>
{
    public SubProductId(Guid value) : base(value)
    {
    }
    public static SubProductId Create() => new(Guid.NewGuid());
}