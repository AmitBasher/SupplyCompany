namespace SupplyCompany.Domain.Models.product.Entity.subProduct
{
    public sealed class SubProduct : Entity<SubProductId>
    {
        public ProductId ProductId { get; private set; }
        public SupplierId SupplierId { get; private set; }
        public AverageRatings Rating { get; private set; }
        public string SubTitle { get; private set; }
        public double Price { get; private set; }
        public int SupplyAvailability { get; private set; }
        public int Discount { get; private set; }

        private List<ProductAttribute> _attributes = new();
        public IReadOnlyList<ProductAttribute> Attributes =>
            _attributes.AsReadOnly();
        private SubProduct(
            SubProductId id,
            ProductId ProductId,
            SupplierId SupplierId,
            string SubTitle,
            double Price,
            int SupplyAvailability,
            int Discount
            //,List<ProductAttribute> attributes
            ) : base(id)
        {
            this.ProductId = ProductId;
            this.SupplierId = SupplierId;
            this.SubTitle = SubTitle;
            this.Price = Price;
            this.SupplyAvailability = SupplyAvailability;
            this.Discount = Discount;
            //_attributes = attributes;
            Rating = AverageRatings.CreateNew();
        }
        public static SubProduct Create(
            ProductId ProductId,
            SupplierId SupplierId,
            string SubTitle,
            double Price,
            int SupplyAvailability,
            List<ProductAttribute> attributes,
            int Discount = 0)
        {
            //validation
            return new(
                SubProductId.Create(),
                ProductId,
                SupplierId,
                SubTitle,
                Price,
                SupplyAvailability,
                Discount
                )
            {
                Rating = AverageRatings.CreateNew(),
                _attributes = attributes
            };
        }
    }
}
