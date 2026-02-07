using TransportationSystem.Domain.Enums;

namespace TransportationSystem.Domain.Entities;

public class Order : BaseEntity
{
    public Guid CustomerId { get; set; }
    public Guid? DriverId { get; set; }
    public string PickupAddress { get; set; } = string.Empty;
    public string DropoffAddress { get; set; } = string.Empty;
    public DateTimeOffset? ScheduledAt { get; set; }
    public OrderStatus Status { get; set; } = OrderStatus.Draft;
    public PaymentMethod PaymentMethod { get; set; } = PaymentMethod.Online;
    public decimal Price { get; set; }
    public string? Notes { get; set; }
}
