namespace SupplyCompany.Infrastructure.DAL.Repository;

public interface IProductReviewRepository {
    Task AddProductReview(ProductReview newReview);
    Task<int> DeleteProductReviewById(Guid id);
    Task<IList<ProductReview>> GetProductReviews();
    Task<ProductReview?> GetProductReviewsById(Guid id);
    Task UpdateProductReview(ProductReview modifiedReview);
}