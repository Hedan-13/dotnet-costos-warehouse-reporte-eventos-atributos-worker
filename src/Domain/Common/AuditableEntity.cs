using System;

namespace CostosWarehouse.ReporteEventosAtributos.Worker.Domain.Common;

public record struct AuditableEntity(DateTime Created, string CreatedBy, DateTime? LastModified, string LastModifiedBy) { }