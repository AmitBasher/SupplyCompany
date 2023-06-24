namespace SupplyCompany.Infrastructure.DAL.Repository;

public interface ISupplyRequestRepository {
    Task AddSupplyRequest(SupplyRequest newRequest);
    Task<int> DeleteSupplyRequestById(Guid id);
    Task<IList<SupplyRequest>> GetSupplyRequests();
    Task<SupplyRequest?> GetSupplyRequestsById(Guid id);
    Task UpdateSupplyRequest(SupplyRequest modifiedRequest);
}