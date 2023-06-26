namespace SupplyCompany.Application.Products.Commands.Create;
public record CreateProductCommand(
    string SupplierId,
    string Name,
    string Description,
    List<SubProductCommand> SubProducts) 
    : IRequest<Product>;

public record SubProductCommand(
    string SubTitle,
    double price,
    int SupplyAvailability,
    List<ProductAttributeCommand> Attributes,
    int Discount = 0);

public record ProductAttributeCommand(
    string Title,
    string Value);