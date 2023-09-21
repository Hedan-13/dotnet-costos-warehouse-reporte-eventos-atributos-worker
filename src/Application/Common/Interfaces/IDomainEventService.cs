using CostosWarehouse.ReporteEventosAtributos.Worker.Domain.Common;
using System.Threading.Tasks;

namespace CostosWarehouse.ReporteEventosAtributos.Worker.Application.Common.Interfaces;

public interface IDomainEventService
{
    Task Publish(DomainEvent domainEvent);
}
