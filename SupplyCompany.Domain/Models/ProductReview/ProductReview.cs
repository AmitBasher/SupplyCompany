namespace SupplyCompany.Domain.Models.productReview;
public class ProductReview :AggregateRoot<ProductReviewId> {
    public ProductId ProductId { get; private set; }
    public SubProductId SubProductId { get; private set; }
    public CustomerId CustomerId { get; private set; }
    public SupplierId SupplierId { get; private set; }
    public SupplyRequestId SupplyRequestId { get; private set; }
    public Rating Rating { get; private set; }
    public string Desciption { get; private set; }
    public DateTime CreatedDateTime { get; private set; }
    public DateTime LastModifiedDateTime { get; private set; }

    private ProductReview(
        ProductReviewId Id,
        ProductId ProductId,
        SubProductId SubProductId, 
        CustomerId CustomerId, 
        SupplierId SupplierId, 
        SupplyRequestId SupplyRequestId, 
        string Desciption)
        : base(Id){
        this.ProductId = ProductId;
        this.SubProductId=SubProductId;
        this.CustomerId=CustomerId;
        this.SupplierId=SupplierId;
        this.SupplyRequestId=SupplyRequestId;
        this.Desciption=Desciption;
    }
    public static ProductReview Create(
        ProductId ProductId,
        SubProductId SubProductId,
        CustomerId CustomerId,
        SupplierId SupplierId,
        SupplyRequestId SupplyRequestId,
        Rating Rating,
        string Desciption) {
        //validation
        return new(
            ProductReviewId.Create(),
            ProductId,
            SubProductId,
            CustomerId,
            SupplierId,
            SupplyRequestId,
            Desciption) { 
            Rating = Rating};
    }
}
