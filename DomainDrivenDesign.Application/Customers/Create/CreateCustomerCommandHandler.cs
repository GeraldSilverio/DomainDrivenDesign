using DomainDrivenDesign.Domain.Customers;
using DomainDrivenDesign.Domain.Primitives;
using DomainDrivenDesign.Domain.ValuesObjects;
using MediatR;

namespace DomainDrivenDesign.Application.Customers.Create;

internal sealed class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, Unit>
{
    private readonly ICustomerRepository _customerRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CreateCustomerCommandHandler(ICustomerRepository customerRepository, IUnitOfWork unitOfWork)
    {
        _customerRepository = customerRepository ?? throw new ArgumentNullException(nameof(customerRepository));
        _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
    }

    public async Task<Unit> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
    {
        if (PhoneNumber.Create(request.PhoneNumber) is not PhoneNumber phoneNumber)
            throw new ArgumentException(nameof(phoneNumber));

        if (Addres.Create(request.Country, request.Line1, request.Line2, request.City, request.State, request.ZipCode)
            is not Addres addres) throw new AggregateException(nameof(addres));

        var customer = new Customer(new CustomerId(Guid.NewGuid()), request.Name, request.LastName,
            phoneNumber, request.Email, addres, true);

        await _customerRepository.AddAsync(customer);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return Unit.Value;  
    }
}