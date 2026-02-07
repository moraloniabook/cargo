using TransportationSystem.Domain.Enums;

namespace TransportationSystem.Domain.Entities;

public class Customer : BaseEntity
{
    public string FullName { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string? Email { get; set; }
    public string PreferredLanguage { get; set; } = "fa-IR";
    public bool IsActive { get; set; } = true;
    public decimal Balance { get; set; }
}
