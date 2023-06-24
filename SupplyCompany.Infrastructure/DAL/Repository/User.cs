namespace SupplyCompany.Infrastructure.DAL.Repository {
    public class UserRepository : IUserRepository{
        private readonly DataContext _db;
        public UserRepository(DataContext db) {
            _db = db;
        }
        public async Task<IList<User>> GetUsers()
            => await _db.Users.ToListAsync();
        public async Task<User?> GetUserById(Guid id)
            => await _db.Users.FirstOrDefaultAsync(u => u.Id.Equals(id));
        public async Task<User?> GetUserByEmail(string email)
            => await _db.Users.FirstOrDefaultAsync(u => u.Email.Equals(email));
        public async Task AddUser(User newUser) { 
            await _db.Users.AddAsync(newUser);
            await _db.SaveChangesAsync();
        }
        public async Task<int> DeleteUserById(Guid id)
            => await _db.Users.Where(p => p.Id.Equals(id)).ExecuteDeleteAsync();
        public async Task UpdateUser(User modifiedUser) {
            _db.Users.Update(modifiedUser!);
            await _db.SaveChangesAsync();
        }
    }
}