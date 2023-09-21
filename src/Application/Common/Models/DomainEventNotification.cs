using CostosWarehouse.ReporteEventosAtributos.Worker.Domain.Common;
using MediatR;

namespace CostosWarehouse.ReporteEventosAtributos.Worker.Application.Common.Models;

public class DomainEventNotification<TDomainEvent> : INotification where TDomainEvent : DomainEvent
{
    public DomainEventNotification(TDomainEvent domainEvent)
    {
        DomainEvent = domainEvent;
    }

    public TDomainEvent DomainEvent { get; }
}
