namespace SupplyCompany.DTO.ProductReview;
public record CreateProductReviewRequest(
    string ProductId,
    string SubProductId,
    string CustomerId,
    string SupplierId,
    string SupplyRequestId,
    RatingRequest Rate,
    string Desciption);