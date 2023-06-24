namespace SupplyCompany.Application.Interfaces.Repositories;
public interface ISupplierRepository {
    Task AddSupplier(Supplier newSupplier);
    Task<int> DeleteSupplierById(Guid id);
    Task<IList<Supplier>> GetSuppliers();
    Task<Supplier?> GetSuppliersById(Guid id);
    Task UpdateSupplier(Supplier modifiedSupplier);
}