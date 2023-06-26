namespace SupplyCompany.DTO.SupplierReview;
public record CreateSupplierReviewRequest(
    string CustomerId,
    string SupplierId,
    string SupplyRequestId,
    string Description,
    RatingRequest Rating);