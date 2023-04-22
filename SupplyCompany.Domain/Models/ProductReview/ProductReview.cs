namespace SupplyCompany.Domain.Models.productReview; 
public class ProductReview :AggregateRoot<ProductReviewId> {
    public SubProductId SubProductId { get; }
    public CustomerId CustomerId { get; }
    public SupplierId SupplierId { get; }
    public SupplyRequestId SupplyRequestId { get; }
    public Rating Rate { get; }
    public string Desciption { get; }

    private ProductReview(
        ProductReviewId Id,
        SubProductId SubProductId, 
        CustomerId CustomerId, 
        SupplierId SupplierId, 
        SupplyRequestId SupplyRequestId, 
        Rating Rate, 
        string Desciption)
        : base(Id){
        this.SubProductId=SubProductId;
        this.CustomerId=CustomerId;
        this.SupplierId=SupplierId;
        this.SupplyRequestId=SupplyRequestId;
        this.Rate=Rate;
        this.Desciption=Desciption;
    }
    public static ProductReview Create(
        SubProductId SubProductId,
        CustomerId CustomerId,
        SupplierId SupplierId,
        SupplyRequestId SupplyRequestId,
        Rating Rate,
        string Desciption) {
        //validation
        return new(
            ProductReviewId.Create(),
            SubProductId,
            CustomerId,
            SupplierId,
            SupplyRequestId,
            Rate,
            Desciption);
    }
}
