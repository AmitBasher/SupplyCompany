namespace SupplyCompany.DTO.Authentication;
public record RegisterRequest (
    string FirstName,
    string LastName,
    string Email,
    string Password);
