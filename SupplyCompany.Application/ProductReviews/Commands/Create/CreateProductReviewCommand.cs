namespace SupplyCompany.Application.ProductReviews.Commands.Create;
public record CreateProductReviewCommand(
    string ProductId,
    string SubProductId,
    string CustomerId,
    string SupplierId,
    string SupplyRequestId,
    RatingCommand Rate,
    string Desciption): IRequest<ProductReview>;
