using Domain.Entities;

namespace Botanical.Application.Contracts.Persistence
{
    public interface IPlantsRepository : IAsyncRepository<Plant>
    {
    }
}
