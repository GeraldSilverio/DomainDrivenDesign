namespace DomainDrivenDesign.Domain.Customers;

public interface ICustomerRepository
{
    Task<Customer> GetIdAsync(CustomerId id);
    Task AddAsync(Customer customer);
}