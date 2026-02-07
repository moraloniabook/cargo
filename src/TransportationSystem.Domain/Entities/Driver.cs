using TransportationSystem.Domain.Enums;

namespace TransportationSystem.Domain.Entities;

public class Driver : BaseEntity
{
    public string FullName { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public VehicleType VehicleType { get; set; }
    public decimal CommissionRate { get; set; }
    public bool IsActive { get; set; } = true;
    public decimal Balance { get; set; }
}
