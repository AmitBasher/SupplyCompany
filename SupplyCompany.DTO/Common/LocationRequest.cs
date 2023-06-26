global using SupplyCompany.DTO.Common;
namespace SupplyCompany.DTO.Common;
public record LocationRequest(string State,
                              string City,
                              string Address);