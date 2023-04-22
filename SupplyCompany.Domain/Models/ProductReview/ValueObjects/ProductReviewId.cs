namespace SupplyCompany.Domain.Models.productReview; 
public sealed class ProductReviewId : ID<ProductReviewId>{
    public ProductReviewId(Guid value) : base(value) {
    }

    public static ProductReviewId Create() => new (Guid.NewGuid());
}