namespace SupplyCompany.Domain.Models.product
{
    public sealed class Product : AggregateRoot<ProductId> {
        public SupplierId SupplierId { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public AverageRatings Ratings { get; private set; }
        public DateTime CreatedDateTime { get; private set;  }
        public DateTime LastModifiedDateTime { get; private set;  }
        private List<SubProduct> _subProducts = new();
        private List<ProductReview> _productReviews = new();
        public IReadOnlyList<SubProduct> SubProducts
            => _subProducts.AsReadOnly();
        public IReadOnlyList<ProductReview> ProductReviews
            => _productReviews.AsReadOnly();
        private Product(
            ProductId Id,
            SupplierId SupplierId,
            string Name,
            string Description,
            DateTime CreatedDateTime,
            DateTime LastModifiedDateTime) 
            : base(Id){
            this.SupplierId = SupplierId;
            this.Name = Name;
            this.Description = Description;
            this.CreatedDateTime = CreatedDateTime;
            this.LastModifiedDateTime = LastModifiedDateTime;
        }
        public static Product Create(
            SupplierId SupplierId,
            string Name,
            string Description,
            List<SubProduct> subProducts) {
            //validation
            return new(
                ProductId.Create(),
                SupplierId,
                Name,
                Description,
                DateTime.UtcNow,
                DateTime.UtcNow) {
                Ratings = AverageRatings.CreateNew(),
                _subProducts = subProducts };
        }
    }
}