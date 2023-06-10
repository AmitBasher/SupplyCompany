namespace SupplyCompany.Infrastructure.DAL.Repository {
    public class ProductRepository {
        private readonly DataContext _db;
        public ProductRepository(DataContext db) {
            _db = db;
        }
        public async Task<IList<Product>> GetProducts()
            => await _db.Products.ToListAsync();
        public async Task<Product?> GetProductsById(Guid id)
            => await _db.Products.FirstOrDefaultAsync(u => u.Id.Equals(id));
        public async Task AddProduct(Product newProduct) {
            await _db.Products.AddAsync(newProduct);
            await _db.SaveChangesAsync();
        }
        public async Task<int> DeleteProductById(Guid id)
            => await _db.Products.Where(p => p.Id.Equals(id)).ExecuteDeleteAsync();
        public async Task UpdateProduct(Product modifiedProduct) {
            _db.Products.Update(modifiedProduct!);
            await _db.SaveChangesAsync();
        }
    }
}