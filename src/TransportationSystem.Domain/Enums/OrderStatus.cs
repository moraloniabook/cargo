namespace TransportationSystem.Domain.Enums;

public enum OrderStatus
{
    Draft = 0,
    PendingAssignment = 1,
    Assigned = 2,
    PickedUp = 3,
    InTransit = 4,
    Delivered = 5,
    Cancelled = 6
}
