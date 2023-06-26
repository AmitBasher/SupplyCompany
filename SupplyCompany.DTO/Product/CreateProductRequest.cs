namespace SupplyCompany.DTO.Product;
public record CreateProductRequest(
    string SupplierId,
    string Name,
    string Description,
    List<SubProductRequest> SubProducts);
public record SubProductRequest(
    string SubTitle,
    double price,
    int SupplyAvailability,
    List<ProductAttributeRequest> Attributes,
    int Discount = 0);
public record ProductAttributeRequest(
    string Title,
    string Value);