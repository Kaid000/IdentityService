using IdentityService.Context;
using Microsoft.EntityFrameworkCore;

namespace IdentityService.Configuration.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistenceInfrastructure(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            return services;
        }
    }
}
