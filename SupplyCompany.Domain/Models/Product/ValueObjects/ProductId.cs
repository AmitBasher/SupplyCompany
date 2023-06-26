namespace SupplyCompany.Domain.Models.product;

public sealed class ProductId : ID<ProductId> {
    public ProductId(Guid value) : base(value) {
    }
    public static ProductId Create() => new(Guid.NewGuid());
    public static ProductId CreateFrom(Guid id) => new(id);
    public static ProductId CreateFrom(string id) => new(Guid.Parse(id));
}