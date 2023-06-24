namespace SupplyCompany.Infrastructure.DAL.Repository;

public interface IProductRepository {
    Task AddProduct(Product newProduct);
    Task<int> DeleteProductById(Guid id);
    Task<IList<Product>> GetProducts();
    Task<Product?> GetProductsById(Guid id);
    Task<IList<Product>?> GetProductsBySupplierId(Guid id);
    Task UpdateProduct(Product modifiedProduct);
}