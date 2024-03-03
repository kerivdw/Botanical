using Botanical.Application.Contracts.Persistence;
using Domain.Entities;

namespace Botanical.Persistence.Repositories
{
    public class PlantRepository(BotanicalDbContext dbContext) : BaseRepository<Plant>(dbContext), IPlantsRepository
    {
    }
}
