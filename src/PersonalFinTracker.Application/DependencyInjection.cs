using Microsoft.Extensions.DependencyInjection;
using PersonalFinTracker.Application.Users;

namespace PersonalFinTracker.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<UserService>();

            return services;
        }
    }
}