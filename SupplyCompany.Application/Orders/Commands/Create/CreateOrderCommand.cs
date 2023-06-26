namespace SupplyCompany.Application.Orders.Commands.Create;
public record CreateOrderCommand(
    string CustomerId,
    string SupplierId,
    LocationCommand ShippingTo,
    List<string> SupplyRequestsIds)
    : IRequest<Order>;

