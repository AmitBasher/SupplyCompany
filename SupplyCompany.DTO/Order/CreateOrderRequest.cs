namespace SupplyCompany.DTO.Order;
public record CreateOrderRequest(
    string CustomerId,
    string SupplierId,
    LocationRequest ShippingTo,
    List<string> SupplyRequestsIds);