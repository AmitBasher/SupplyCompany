namespace SupplyCompany.Domain.Models.Common {
    public class ID<T> : ValueObject where T: ID<T> {
        public Guid Value { get; }
        protected ID(Guid value) => Value = value;
        public override IEnumerable<object> GetEqualityComponents() {
            yield return Value;
        }
    }
}
