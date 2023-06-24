

namespace SupplyCompany.Infrastructure.DAL.Repository;

public interface ISubProductReposetory {
    Task AddSubProduct(SubProduct newSubProduct);
    Task<int> DeleteSubProductById(Guid id);
    Task<IList<SubProduct>> GetSubProducts();
    Task<SubProduct?> GetSubProductsById(Guid id);
    Task UpdateSubProduct(SubProduct modifiedSubProduct);
}