namespace SupplyCompany.Infrastructure.DAL.Repository;
public class SupplierRepository : ISupplierRepository {
    private readonly DataContext _db;
    public SupplierRepository(DataContext db) {
        _db = db;
    }
    public async Task<IList<Supplier>> GetSuppliers()
        => await _db.Suppliers.Include(p=>p.Products).ThenInclude(p => p.SubProducts).ToListAsync();
    public async Task<Supplier?> GetSuppliersById(Guid id)
        => await _db.Suppliers.FirstOrDefaultAsync(u => u.Id.Equals(id));
    public async Task AddSupplier(Supplier newSupplier) {
        await _db.Suppliers.AddAsync(newSupplier);
        await _db.SaveChangesAsync();
    }
    public async Task<int> DeleteSupplierById(Guid id)
        => await _db.Suppliers.Where(p => p.Id.Equals(id)).ExecuteDeleteAsync();
    public async Task UpdateSupplier(Supplier modifiedSupplier) {
        _db.Suppliers.Update(modifiedSupplier!);
        await _db.SaveChangesAsync();
    }
}