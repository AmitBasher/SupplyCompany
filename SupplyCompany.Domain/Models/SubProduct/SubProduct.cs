namespace SupplyCompany.Domain.Models.subProduct {
    public sealed class SubProduct : AggregateRoot<SubProductId> {
        public ProductReviewId MainProductId { get; }
        public string SubTitle { get; }
        public double Price { get; }
        public int SupplyAvailability { get; }
        public int Discount { get; }

        private readonly List<ProductAttribute> _attributes=new();
        public IReadOnlyList<ProductAttribute> Attributes =>
            _attributes.AsReadOnly();
        private SubProduct(
            SubProductId id,
            ProductReviewId MainProductId,
            string SubTitle,
            double Price,
            int SupplyAvailability,
            int Discount) : base(id) {
            this.MainProductId = MainProductId;
            this.SubTitle = SubTitle;
            this.Price = Price;
            this.SupplyAvailability = SupplyAvailability;
            this.Discount = Discount;
            _attributes = new();
        }
        public static SubProduct Create(
            ProductReviewId MainProductId,
            string SubTitle,
            double Price,
            int SupplyAvailability,
            int Discount=0) {
            //validation
            return new(
                SubProductId.Create(),
                MainProductId,
                SubTitle,
                Price,
                SupplyAvailability,
                Discount);
        }
    }
}
