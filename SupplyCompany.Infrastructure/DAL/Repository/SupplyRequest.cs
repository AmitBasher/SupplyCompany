namespace SupplyCompany.Infrastructure.DAL.Repository;
public class SupplyRequestRepository : ISupplyRequestRepository {
    private readonly DataContext _db;
    public SupplyRequestRepository(DataContext db) {
        _db = db;
    }
    public async Task<IList<SupplyRequest>> GetSupplyRequests()
        => await _db.SupplyRequests.ToListAsync();
    public async Task<List<SupplyRequest>> GetSupplyRequests(IList<SupplyRequestId> Ids) 
        =>await _db.SupplyRequests.Where(S=>Ids.Contains(S.Id)).ToListAsync();
    
    public async Task<SupplyRequest?> GetSupplyRequestsById(Guid id)
        => await _db.SupplyRequests.FirstOrDefaultAsync(u => u.Id.Equals(id));
    public async Task<int> DeleteSupplyRequestById(Guid id)
        => await _db.SupplyRequests.Where(p => p.Id.Equals(id)).ExecuteDeleteAsync();
    public async Task AddSupplyRequest(SupplyRequest newRequest) {
        await _db.SupplyRequests.AddAsync(newRequest);
        await _db.SaveChangesAsync();
    }
    public async Task UpdateSupplyRequest(SupplyRequest modifiedRequest) {
        _db.SupplyRequests.Update(modifiedRequest!);
        await _db.SaveChangesAsync();
    }
}

