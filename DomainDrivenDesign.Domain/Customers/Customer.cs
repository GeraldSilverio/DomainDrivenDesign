using DomainDrivenDesign.Domain.Primitives;
using DomainDrivenDesign.Domain.ValuesObjects;

namespace DomainDrivenDesign.Domain.Customers;

public sealed class Customer : AggregateRoot
{
    public Customer()
    {
    }

    public Customer(CustomerId id, string name, string lastName, PhoneNumber phoneNumber, string email, Addres addres,
        bool active)
    {
        Id = id;
        PhoneNumber = phoneNumber;
        Addres = addres;
        Active = active;
        Name = name;
        LastName = lastName;
        Email = email;
    }

    public CustomerId Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public string LastName { get; private set; } = string.Empty;
    public string FullName => $"{Name} {LastName}";
    public string Email { get; private set; } = string.Empty;
    public PhoneNumber PhoneNumber { get; private set; }
    public Addres Addres { get; private set; }
    public bool Active { get; set; }
}