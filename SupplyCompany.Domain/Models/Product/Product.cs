namespace SupplyCompany.Domain.Models.product
{
    public sealed class Product : AggregateRoot<OrderId> {
        public SupplierId SupplierId { get; set; }
        public string Name { get; }
        public string Description { get; }
        public DateTime DateCreated { get; }
        public DateTime DateLastModified { get; }

        private readonly List<SubProduct> _subProducts;
        private readonly List<ProductReview> _productReviews;
        public IReadOnlyList<SubProduct> SubProducts 
            => _subProducts.AsReadOnly();
        public IReadOnlyList<ProductReview> ProductReviews
            => _productReviews.AsReadOnly();

        private Product(
            OrderId Id,
            SupplierId SupplierId,
            string Name,
            string Description,
            DateTime DateCreated,
            DateTime DateLastModified) 
            : base(Id){
            this.SupplierId = SupplierId;
            this.Name = Name;
            this.Description = Description;
            this.DateCreated = DateCreated;
            this.DateLastModified = DateLastModified;
        }
        public static Product Create(
            SupplierId SupplierId,
            string Name,
            string Description) {
            //validation
            return new(
                OrderId.Create(),
                SupplierId,
                Name,
                Description,
                DateTime.UtcNow,
                DateTime.UtcNow);
        }
    }
}