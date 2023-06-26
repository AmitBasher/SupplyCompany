namespace SupplyCompany.Application.Customers.Commands.Create;
public class CreateSupplierCommandHandler : IRequestHandler<CreateCustomerCommand, Customer> {
    private readonly ICustomerRepository _customerRepository;
    //Todo:Use Mapper To Create New Customer
    //private readonly Mapper _mapper;
    public CreateSupplierCommandHandler(ICustomerRepository customerRepository) {
        _customerRepository = customerRepository;
    }
    public async Task<Customer> Handle(CreateCustomerCommand request, CancellationToken cancellationToken) {
        /* Todo:Create Validation
         */
        var userId = UserId.CreateFrom(request.UserId);
        var ShippingAddress = Location.CreateNew(request.ShippingAddress.State,
                                              request.ShippingAddress.City,
                                              request.ShippingAddress.Address);

        var NewEntity = Customer.Create(userId, ShippingAddress);
        await _customerRepository.AddCustomer(NewEntity);
        return NewEntity;
    }
}
