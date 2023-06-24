namespace SupplyCompany.Application.Customers.Commands.Modify;
public record ModifyCustomerCommand(Customer ModifiedCustomer) 
                                    : IRequest;