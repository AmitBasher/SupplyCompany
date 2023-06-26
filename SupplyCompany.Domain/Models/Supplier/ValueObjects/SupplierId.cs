namespace SupplyCompany.Domain.Models.supplier;

public sealed class SupplierId : ID<SupplierId>
{
    public SupplierId(Guid value) : base(value)
    {}
    public static SupplierId Create() => new(Guid.NewGuid());
    public static SupplierId CreateFrom(Guid id) => new(id);
    public static SupplierId CreateFrom(string id) => new(Guid.Parse(id));
}