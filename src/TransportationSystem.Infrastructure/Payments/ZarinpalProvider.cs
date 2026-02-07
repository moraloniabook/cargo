using TransportationSystem.Application.Interfaces;

namespace TransportationSystem.Infrastructure.Payments;

public class ZarinpalProvider : IPaymentProvider
{
    public string Name => "Zarinpal";

    public Task<string> CreatePaymentAsync(decimal amount, string description, CancellationToken cancellationToken)
    {
        return Task.FromResult("ZARINPAL-REFERENCE-PLACEHOLDER");
    }

    public Task<bool> VerifyPaymentAsync(string referenceId, CancellationToken cancellationToken)
    {
        return Task.FromResult(true);
    }
}
