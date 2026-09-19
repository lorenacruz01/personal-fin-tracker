using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PersonalFinTracker.Application.Interfaces;
using PersonalFinTracker.Infrastructure.Persistence;
using PersonalFinTracker.Infrastructure.Repositories;

namespace PersonalFinTracker.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<FinTrackerDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"))
            );

            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}