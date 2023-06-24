namespace SupplyCompany.Application.Users.Common;
public record AuthenticationResult (
    User User,
    string Token);
