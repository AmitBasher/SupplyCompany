namespace SupplyCompany.Application.Interfaces.Repositories;
public interface IUserRepository {
    Task AddUser(User newUser);
    Task<int> DeleteUserById(Guid id);
    Task<User?> GetUserByEmail(string email);
    Task<User?> GetUserById(Guid id);
    Task<IList<User>> GetUsers();
    Task UpdateUser(User modifiedUser);
}