namespace SupplyCompany.Application.SupplyRequests.Commands.Create;
public record CreateSupplyRequestCommand(
    string ProductId,
    string SubProductId,
    string SupplierId,
    string CustomerId,
    int Quantity,
    int Price,
    int Discount) 
    : IRequest<SupplyRequest>;
