namespace SupplyCompany.Application.Orders.Commands.Create;
public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, Order> {
    private readonly IOrderRepository _orderRepository;
    private readonly ISupplyRequestRepository _supplyRequestRepository;
    public CreateOrderCommandHandler(IOrderRepository orderRepository, ISupplyRequestRepository supplyRequestRepository){
        _orderRepository = orderRepository;
        _supplyRequestRepository = supplyRequestRepository;
    }
    public async Task<Order> Handle(CreateOrderCommand request, CancellationToken cancellationToken) {
        var SupplyList = await _supplyRequestRepository.GetSupplyRequests(
            request.SupplyRequestsIds.ConvertAll(
                SupplyRequestId.CreateFrom));

        var Entity = Order.Create(
            CustomerId.CreateFrom(request.CustomerId),
            SupplierId.CreateFrom(request.SupplierId),
            Location.CreateNew(
                request.ShippingTo.State,
                request.ShippingTo.City,
                request.ShippingTo.Address),
            SupplyList);

        await _orderRepository.AddOrder(Entity);
        return Entity;
    }
}
