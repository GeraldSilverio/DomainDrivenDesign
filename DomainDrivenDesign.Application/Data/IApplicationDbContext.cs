using DomainDrivenDesign.Domain.Customers;
using Microsoft.EntityFrameworkCore;

namespace DomainDrivenDesign.Application.Data;

public interface IApplicationDbContext
{
    DbSet<Customer> Customers { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}