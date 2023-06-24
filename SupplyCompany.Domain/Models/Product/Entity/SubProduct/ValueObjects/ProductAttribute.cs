namespace SupplyCompany.Domain.Models.product.Entity.subProduct.ValueObjects;

public sealed class ProductAttribute : ValueObject
{
    public string Title { get; }
    public string Value { get; }
    private ProductAttribute(
        string Title,
        string Value)
    {
        this.Title = Title;
        this.Value = Value;
    }
    public static ProductAttribute Create(
        string Title,
        string Value)
    {
        //ToDo:ProductAttribute Validation

        return new(
            Title,
            Value);
    }
    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Title;
        yield return Value;
    }
}