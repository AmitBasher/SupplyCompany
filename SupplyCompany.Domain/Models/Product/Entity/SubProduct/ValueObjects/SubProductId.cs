namespace SupplyCompany.Domain.Models.product.Entity.subProduct.ValueObjects;

public sealed class SubProductId : ID<SubProductId>
{
    public SubProductId(Guid value) : base(value)
    { }
    public static SubProductId Create() => new(Guid.NewGuid());
    public static SubProductId CreateFrom(Guid id) => new(id);

    public static SubProductId CreateFrom(string id) => new(Guid.Parse(id));
}