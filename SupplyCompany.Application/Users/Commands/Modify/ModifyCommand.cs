namespace SupplyCompany.Application.Users.Commands.Modify;
public record ModifyCommand (
    string Token,
    string FirstName,
    string LastName,
    string Email,
    string Password) 
    : IRequest<AuthenticationResult>;
