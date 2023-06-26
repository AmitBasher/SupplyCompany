namespace SupplyCompany.Application.SupplierReviews.Commands.Create;
public record CreateSupplierReviewCommand(
    string CustomerId,
    string SupplierId,
    string SupplyRequestId,
    string Description,
    RatingCommand Rating)
    :IRequest<SupplierReview>;

