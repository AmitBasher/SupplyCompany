namespace SupplyCompany.Application.Users.Queries.Login;
public record LoginCommand(string Email,string Password) : IRequest<AuthenticationResult>;