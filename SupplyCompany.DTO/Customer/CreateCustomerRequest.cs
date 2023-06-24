namespace SupplyCompany.DTO.Customer;
public record CreateCustomerRequest(string UserId,LocationRequest ShippingAddress);
public record LocationRequest(string State,
                              string City,
                              string Address);