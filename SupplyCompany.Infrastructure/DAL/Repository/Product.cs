namespace SupplyCompany.Infrastructure.DAL.Repository;
public class ProductRepository : IProductRepository {
    private readonly DataContext _db;
    public ProductRepository(DataContext db) {
        _db = db;
    }
    public async Task<IList<Product>> GetProducts()
        => await _db.Products.ToListAsync();
    public async Task<Product?> GetProductsById(Guid id)
        => await _db.Products.FirstOrDefaultAsync(p => p.Id.Equals(id));
    public async Task<IList<Product>?> GetProductsBySupplierId(Guid id)
        => await _db.Products.Where(p => p.SupplierId.Equals(id))
                             .ToListAsync();
    //public async Task<IList<Product>?> GetProductByString(string name) {
    //    var list1 = _db.Products.Where(p=> p.Name.StartsWith(name));
    //    var list2 = _db.Products.Where(p => p.Name.Contains(name)).Concat(list1);
    //    return await _db.Products.Where(p => p.Description.Contains(name)).Concat(list2).ToListAsync();
    // change to Union instead of Concat
    //}
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