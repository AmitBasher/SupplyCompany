using SupplyCompany.Domain.Models.product.Entity.subProduct.ValueObjects;

namespace SupplyCompany.Application.SupplyRequests.Commands.Create;
public class CreateSupplyRequestCommandHandler : IRequestHandler<CreateSupplyRequestCommand,SupplyRequest> {
    private readonly ISupplyRequestRepository _supplyRequestRepository;
    public CreateSupplyRequestCommandHandler(ISupplyRequestRepository supplyRequestRepository) {
        _supplyRequestRepository=supplyRequestRepository;
    }
    public async Task<SupplyRequest> Handle(CreateSupplyRequestCommand request, CancellationToken cancellationToken) {
        var Entity = SupplyRequest.Create(
            ProductId.CreateFrom(request.ProductId),
            SubProductId.CreateFrom(request.SubProductId),
            SupplierId.CreateFrom(request.SupplierId),
            CustomerId.CreateFrom(request.CustomerId),
            request.Quantity,
            request.Price,
            request.Discount);
        await _supplyRequestRepository.AddSupplyRequest(Entity);
        return Entity;
    }
}
