namespace SupplyCompany.Infrastructure.DAL.Repository;

public interface IOrderRepository {
    Task AddOrder(Order newOrder);
    Task<int> DeleteOrderById(Guid id);
    Task<IList<Order>> GetOrders();
    Task<Order?> GetOrdersById(Guid id);
    Task UpdateOrder(Order modifiedOrder);
}