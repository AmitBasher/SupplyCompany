namespace SupplyCompany.Infrastructure.DAL.Repository;
public class SubProductReposetory : ISubProductReposetory {
    private readonly DataContext _db;
    public SubProductReposetory(DataContext db) {
        _db = db;
    }
    public async Task<IList<SubProduct>> GetSubProducts()
        => await _db.SubProducts.ToListAsync();
    public async Task<SubProduct?> GetSubProductsById(Guid id)
        => await _db.SubProducts.FirstOrDefaultAsync(u => u.Id.Equals(id));
    public async Task AddSubProduct(SubProduct newSubProduct) {
        await _db.SubProducts.AddAsync(newSubProduct);
        await _db.SaveChangesAsync();
    }
    public async Task<int> DeleteSubProductById(Guid id)
        => await _db.SubProducts.Where(p => p.Id.Equals(id)).ExecuteDeleteAsync();
    public async Task UpdateSubProduct(SubProduct modifiedSubProduct) {
        _db.SubProducts.Update(modifiedSubProduct!);
        await _db.SaveChangesAsync();
    }
}

