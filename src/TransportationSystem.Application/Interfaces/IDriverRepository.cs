using TransportationSystem.Domain.Entities;

namespace TransportationSystem.Application.Interfaces;

public interface IDriverRepository
{
    Task<Driver?> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    Task<IReadOnlyList<Driver>> ListAsync(CancellationToken cancellationToken);
    Task AddAsync(Driver driver, CancellationToken cancellationToken);
    Task UpdateAsync(Driver driver, CancellationToken cancellationToken);
    Task DeleteAsync(Driver driver, CancellationToken cancellationToken);
}
