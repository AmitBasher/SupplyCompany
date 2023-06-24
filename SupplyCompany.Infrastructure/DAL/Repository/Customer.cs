namespace SupplyCompany.Infrastructure.DAL.Repository {
    public class CustomerRepository : ICustomerRepository {
        private readonly DataContext _db;
        public CustomerRepository(DataContext db) {
            _db = db;
        }
        public async Task<IList<Customer>> GetCustomers()
            => await _db.Customers.ToListAsync();
        public async Task<Customer?> GetCustomersById(Guid id)
            => await _db.Customers.FirstOrDefaultAsync(u => u.Id.Equals(id));
        public async Task<int> DeleteCustomerById(Guid id)
            => await _db.Customers.Where(p => p.Id.Equals(id)).ExecuteDeleteAsync();
        public async Task AddCustomer(Customer newCustomer) {
            await _db.Customers.AddAsync(newCustomer);
            await _db.SaveChangesAsync();
        }
        public async Task UpdateCustomer(Customer modifiedCustomer) {
            _db.Customers.Update(modifiedCustomer!);
            await _db.SaveChangesAsync();
        }
    }
}