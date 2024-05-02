using DomainDrivenDesign.Domain.Customers;
using DomainDrivenDesign.Domain.Primitives;
using Microsoft.EntityFrameworkCore;

namespace CDomainDrivenDesign.Infraestructure.Persistence.Repositories;

public class CustomerRepository(ApplicationDbContext dbContext) : ICustomerRepository
{
    public async Task<Customer> GetIdAsync(CustomerId id) =>
        await dbContext.Customers.SingleOrDefaultAsync(c => c.Id == id);

    public async Task AddAsync(Customer customer) => await dbContext.AddAsync(customer);
}