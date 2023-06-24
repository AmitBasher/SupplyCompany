namespace SupplyCompany.Application.Suppliers.Commands.Create;
public class CreateSupplierCommandHandler : IRequestHandler<CreateSupplierCommand, Supplier> {
    private readonly ISupplierRepository _supplierRepository;
    //Todo:Use Mapper To Create New Supplier
    //private readonly Mapper _mapper;
    public CreateSupplierCommandHandler(ISupplierRepository supplierRepository) {
        _supplierRepository = supplierRepository;
    }
    public async Task<Supplier> Handle(CreateSupplierCommand request, CancellationToken cancellationToken) {
        /*Todo:Create Validation
         */
        var userId = UserId.CreateFrom(request.UserId);
        var NewEntity = Supplier.CreateNew(userId);
        await _supplierRepository.AddSupplier(NewEntity);
        return NewEntity;
    }
}
