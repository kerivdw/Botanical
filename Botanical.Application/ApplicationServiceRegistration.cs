using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Botanical.Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));
            services.AddValidatorsFromAssemblies(AppDomain.CurrentDomain.GetAssemblies());  

            return services;
        }

    }
}
