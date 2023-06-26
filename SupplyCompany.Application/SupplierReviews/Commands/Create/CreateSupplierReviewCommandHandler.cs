namespace SupplyCompany.Application.SupplierReviews.Commands.Create;
internal class CreateSupplierReviewCommandHandler : IRequestHandler<CreateSupplierReviewCommand,SupplierReview> {
    private readonly ISupplierReviewRepository _supplierReviewRepository;
    public CreateSupplierReviewCommandHandler(ISupplierReviewRepository supplierReviewRepository){
        _supplierReviewRepository = supplierReviewRepository;
        
    }

    public async Task<SupplierReview> Handle(CreateSupplierReviewCommand request, CancellationToken cancellationToken) {
        var Entity = SupplierReview.Create(
            CustomerId.CreateFrom(request.CustomerId),
            SupplierId.CreateFrom(request.SupplierId),
            SupplyRequestId.CreateFrom(request.SupplyRequestId),
            request.Description,
            Rating.CreateNew(request.Rating.Value));
        await _supplierReviewRepository.AddSupplierReview(Entity);
        return Entity;
    }
}
