namespace SupplyCompany.Domain.Models.product {
    public class ProductAttribute : ValueObject {
        public string Name { get; }
        public string Value { get; }
        private ProductAttribute(string Name, string Value) {
            this.Name = Name;
            this.Value = Value;
        }
        public static ProductAttribute Create(string Name,string Value) {
            return new(Name,Value);
        }
        public override IEnumerable<object> GetEqualityComponents() {
            yield return Name;
            yield return Value;
        }
    }
}
