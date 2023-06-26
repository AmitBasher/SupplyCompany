using SupplyCompany.Domain.Models.product.Entity.subProduct.ValueObjects;

namespace SupplyCompany.Application.ProductReviews.Commands.Create;
public class CreateProductReviewCommandHandler : IRequestHandler<CreateProductReviewCommand, ProductReview> {
    private readonly IProductReviewRepository _productReviewRepository;
    public CreateProductReviewCommandHandler(IProductReviewRepository productReviewRepository){
        _productReviewRepository = productReviewRepository;
    }
    public async Task<ProductReview> Handle(CreateProductReviewCommand request, CancellationToken cancellationToken) {
        var Review = ProductReview.Create(
            ProductId.CreateFrom(request.ProductId),
            SubProductId.CreateFrom(request.SubProductId),
            CustomerId.CreateFrom(request.CustomerId),
            SupplierId.CreateFrom(request.SupplierId),
            SupplyRequestId.CreateFrom(request.SupplyRequestId),
            Rating.CreateNew(request.Rate.Value),
            request.Desciption);
        await _productReviewRepository.AddProductReview(Review);
        return Review;
    }
}