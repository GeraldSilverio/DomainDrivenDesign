using MediatR;

namespace DomainDrivenDesign.Domain.Primitives;

public record DomainEvent(Guid Id) : INotification
{
    private readonly List<DomainEvent> _domainEvents = new();

    public ICollection<DomainEvent> GetDomainEvents() => _domainEvents;

    protected void Raise(DomainEvent domainEvent)
    {
        _domainEvents.Add(domainEvent);
    }
}