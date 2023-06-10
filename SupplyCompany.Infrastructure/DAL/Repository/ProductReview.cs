namespace SupplyCompany.Infrastructure.DAL.Repository {
    public class ProductReviewRepository {
        private readonly DataContext _db;
        public ProductReviewRepository(DataContext db) {
            _db = db;
        }
        public async Task<IList<ProductReview>> GetProductReviews()
            => await _db.ProductReviews.ToListAsync();
        public async Task<ProductReview?> GetProductReviewsById(Guid id)
            => await _db.ProductReviews.FirstOrDefaultAsync(u => u.Id.Equals(id));
        public async Task AddProductReview(ProductReview newReview) {
            await _db.ProductReviews.AddAsync(newReview);
            await _db.SaveChangesAsync();
        }
        public async Task<int> DeleteProductReviewById(Guid id)
            => await _db.ProductReviews.Where(p => p.Id.Equals(id)).ExecuteDeleteAsync();
        public async Task UpdateProductReview(ProductReview modifiedReview) {
            _db.ProductReviews.Update(modifiedReview!);
            await _db.SaveChangesAsync();
        }
    }
}