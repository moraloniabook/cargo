namespace TransportationSystem.Application.Interfaces;

public interface IPaymentProvider
{
    string Name { get; }
    Task<string> CreatePaymentAsync(decimal amount, string description, CancellationToken cancellationToken);
    Task<bool> VerifyPaymentAsync(string referenceId, CancellationToken cancellationToken);
}
