namespace SupplyCompany.Application.Common.Interfaces.Authentication;
public interface IJwtTokenGenerator {
    string GenerateToken(User user);
    //User GenerateUser(string Token);
}