using Botanical.Application.Contracts.Persistence;
using Botanical.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Botanical.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BotanicalDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("BotanicalConnectionString")));

            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));

            services.AddScoped<IPlantsRepository, PlantRepository>();

            return services;

        }
    }
}
