namespace SupplyCompany.Infrastructure.DAL.Repository {
    public class SupplierReviewRepository {
        private readonly DataContext _db;
        public SupplierReviewRepository(DataContext db) {
            _db = db;
        }
        public async Task<IList<SupplierReview>> GetSupplierReviews()
            => await _db.SupplierReviews.ToListAsync();
        public async Task<SupplierReview?> GetSupplierReviewsById(Guid id)
            => await _db.SupplierReviews.FirstOrDefaultAsync(u => u.Id.Equals(id));
        public async Task AddSupplierReview(SupplierReview newRequest) {
            await _db.SupplierReviews.AddAsync(newRequest);
            await _db.SaveChangesAsync();
        }
        public async Task<int> DeleteSupplierReviewById(Guid id)
            => await _db.SupplierReviews.Where(p => p.Id.Equals(id)).ExecuteDeleteAsync();
        public async Task UpdateSupplierReview(SupplierReview modifiedReview) {
            _db.SupplierReviews.Update(modifiedReview!);
            await _db.SaveChangesAsync();
        }
    }
}