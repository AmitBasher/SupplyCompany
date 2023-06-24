namespace SupplyCompany.DTO.Authentication;
public record ModifyRequest(
    string Token,
    string FirstName,
    string LastName,
    string Email,
    string Password);
