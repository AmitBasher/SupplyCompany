namespace SupplyCompany.Application.Interfaces.Repositories;

public interface ICustomerRepository {
    Task AddCustomer(Customer newCustomer);
    Task<int> DeleteCustomerById(Guid id);
    Task<IList<Customer>> GetCustomers();
    Task<Customer?> GetCustomersById(Guid id);
    Task UpdateCustomer(Customer modifiedCustomer);
}