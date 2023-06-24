namespace SupplyCompany.Infrastructure.DAL.Repository {
    public class OrderRepository : IOrderRepository {
        private readonly DataContext _db;
        public OrderRepository(DataContext db) {
            _db = db;
        }
        public async Task<IList<Order>> GetOrders()
            => await _db.Orders.ToListAsync();
        public async Task<Order?> GetOrdersById(Guid id)
            => await _db.Orders.FirstOrDefaultAsync(u => u.Id.Equals(id));
        public async Task AddOrder(Order newOrder) {
            await _db.Orders.AddAsync(newOrder);
            await _db.SaveChangesAsync();
        }
        public async Task<int> DeleteOrderById(Guid id)
            => await _db.Orders.Where(p => p.Id.Equals(id)).ExecuteDeleteAsync();
        public async Task UpdateOrder(Order modifiedOrder) {
            _db.Orders.Update(modifiedOrder!);
            await _db.SaveChangesAsync();
        }
    }
}