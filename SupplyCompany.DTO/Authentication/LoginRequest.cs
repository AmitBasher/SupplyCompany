namespace SupplyCompany.DTO.Authentication;
public record LoginRequest (
    string Email,
    string Password);
