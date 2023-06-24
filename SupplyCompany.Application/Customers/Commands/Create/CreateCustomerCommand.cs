namespace SupplyCompany.Application.Customers.Commands.Create;
public record CreateCustomerCommand(string UserId,
                                    LocationCommand ShippingAddress) 
                                    : IRequest<Customer>;
public record LocationCommand(string State,
                              string City,
                              string Address);