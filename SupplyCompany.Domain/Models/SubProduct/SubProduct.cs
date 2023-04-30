namespace SupplyCompany.Domain.Models.subProduct {
    public sealed class SubProduct : Entity<SubProductId> {
        public ProductId ProductId { get; private set; }
        public SupplierId SupplierId { get; private set; }
        public AverageRatings Rating { get; private set; }
        public string SubTitle { get; private set; }
        public double Price { get; private set; }
        public int SupplyAvailability { get; private set; }
        public int Discount { get; private set; }

        private readonly List<ProductAttribute> _attributes = new();
        public IReadOnlyList<ProductAttribute> Attributes =>
            _attributes.AsReadOnly();
        private SubProduct(
            SubProductId id,
            string SubTitle,
            double Price,
            int SupplyAvailability,
            int Discount) : base(id) {
            this.SubTitle = SubTitle;
            this.Price = Price;
            this.SupplyAvailability = SupplyAvailability;
            this.Discount = Discount;
        }
        public static SubProduct Create(
            string SubTitle,
            double Price,
            int SupplyAvailability,
            int Discount=0) {
            //validation
            return new(
                SubProductId.Create(),
                SubTitle,
                Price,
                SupplyAvailability,
                Discount ){ 
                Rating=AverageRatings.CreateNew() };
        }
    }
}
