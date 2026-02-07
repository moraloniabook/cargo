namespace TransportationSystem.Domain.Entities;

public class Payment : BaseEntity
{
    public Guid OrderId { get; set; }
    public decimal Amount { get; set; }
    public string Provider { get; set; } = string.Empty;
    public string? ReferenceId { get; set; }
    public string Status { get; set; } = "Pending";
}
