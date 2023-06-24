namespace SupplyCompany.Application.Suppliers.Commands.Create;
public record CreateSupplierCommand(string UserId)
                                    : IRequest<Supplier>;