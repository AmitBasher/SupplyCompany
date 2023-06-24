namespace SupplyCompany.Infrastructure.DAL.Repository;

public interface ISupplierReviewRepository {
    Task AddSupplierReview(SupplierReview newRequest);
    Task<int> DeleteSupplierReviewById(Guid id);
    Task<IList<SupplierReview>> GetSupplierReviews();
    Task<SupplierReview?> GetSupplierReviewsById(Guid id);
    Task UpdateSupplierReview(SupplierReview modifiedReview);
}