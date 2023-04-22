namespace SupplyCompany.Domain.Models.supplierReview;

public sealed class supplierReviewId : ID<supplierReviewId>
{
    public supplierReviewId(Guid value) : base(value)
    {
    }
    public static supplierReviewId Create() => new(Guid.NewGuid());
}