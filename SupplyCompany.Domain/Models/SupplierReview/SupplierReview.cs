namespace SupplyCompany.Domain.Models.supplierReview;
public class SupplierReview : AggregateRoot<SupplierReviewId> {
    public CustomerId CustomerId { get; private set; }
    public SupplierId SupplierId { get; private set; }
    public SupplyRequestId SupplyRequestId { get; private set; }
    public string Description { get; private set; }
    public Rating Rating { get; private set; }
    public DateTime CreatedDateTime { get; private set; }
    public DateTime LastModifiedDateTime { get; private set; }

    private SupplierReview(
        SupplierReviewId Id,
        CustomerId CustomerId,
        SupplierId SupplierId,
        SupplyRequestId SupplyRequestId,
        string Description,
        DateTime CreatedDateTime,
        DateTime LastModifiedDateTime) :base(Id) { 
        this.CustomerId = CustomerId;
        this.SupplierId = SupplierId;
        this.SupplyRequestId = SupplyRequestId;
        this.Description = Description;
        this.CreatedDateTime = CreatedDateTime;
        this.LastModifiedDateTime = LastModifiedDateTime;
    }
    public static SupplierReview Create(
        CustomerId CustomerId,
        SupplierId SupplierId,
        SupplyRequestId SupplyRequestId,
        string Description
        ,Rating Rating
        ) {
        //Validation
        return new(
            SupplierReviewId.Create(),
            CustomerId,
            SupplierId,
            SupplyRequestId,
            Description,
            DateTime.UtcNow,
            DateTime.UtcNow) {
            Rating = Rating};
    }
}

