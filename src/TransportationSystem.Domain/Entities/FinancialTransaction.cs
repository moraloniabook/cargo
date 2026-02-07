using TransportationSystem.Domain.Enums;

namespace TransportationSystem.Domain.Entities;

public class FinancialTransaction : BaseEntity
{
    public Guid? CustomerId { get; set; }
    public Guid? DriverId { get; set; }
    public Guid? OrderId { get; set; }
    public FinancialEntryType EntryType { get; set; }
    public decimal Amount { get; set; }
    public string Description { get; set; } = string.Empty;
}
