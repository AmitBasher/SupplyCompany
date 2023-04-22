namespace SupplyCompany.Domain.Models.subProduct;

public sealed class ProductAttribute : ValueObject {
    public string SubName { get; }
    public string SubValue { get; }
    private ProductAttribute(
        string SubName,
        string SubValue) { 
        this.SubName = SubName;
        this.SubValue = SubValue;
    }
    public static ProductAttribute Create(
        string SubName,
        string SubValue) {

        //validation

        return new(
            SubName, 
            SubValue);
    }

    public override IEnumerable<object> GetEqualityComponents() {
        yield return SubName; 
        yield return SubValue;
    }
}