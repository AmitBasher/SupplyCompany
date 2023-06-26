namespace SupplyCompany.Application.Common.Command;
public record LocationCommand(
    string State,
    string City,
    string Address);