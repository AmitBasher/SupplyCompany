namespace SupplyCompany.DTO.SupplyRequest;
public record CreateSupplyRequestRequest(
    string ProductId,
    string SubProductId,
    string SupplierId,
    string CustomerId,
    int Quantity,
    int Price,
    int Discount);