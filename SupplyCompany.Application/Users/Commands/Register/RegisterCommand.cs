namespace SupplyCompany.Application.Users.Commands.Register;
public record RegisterCommand (
    string FirstName,
    string LastName,
    string Email,
    string Password) : IRequest<AuthenticationResult>;