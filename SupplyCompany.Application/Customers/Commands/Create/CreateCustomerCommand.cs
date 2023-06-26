namespace SupplyCompany.Application.Customers.Commands.Create;
public record CreateCustomerCommand(string UserId,
                                    LocationCommand ShippingAddress) 
                                    : IRequest<Customer>;