namespace SupplyCompany.Domain.Models.supplierReview;

public sealed class SupplierReviewId : ID<SupplierReviewId>
{
    public SupplierReviewId(Guid value) : base(value)
    {}
    public static SupplierReviewId Create() => new(Guid.NewGuid());
    public static SupplierReviewId CreateFrom(Guid id) => new(id);
}