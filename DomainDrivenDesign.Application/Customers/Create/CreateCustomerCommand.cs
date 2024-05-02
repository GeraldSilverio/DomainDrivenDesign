using MediatR;

namespace DomainDrivenDesign.Application.Customers.Create;

public record CreateCustomerCommand(
    string Name,
    string LastName,
    string Email,
    string PhoneNumber,
    string Country,
    string City,
    string State,
    string ZipCode,
    string Line1,
    string Line2
) : IRequest<Unit>;

