using IdentityService.Context;
using IdentityService.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.Runtime.CompilerServices;

namespace IdentityService.Configuration.Identity
{
    public static class IdentityExtention
    {
        public static IServiceCollection AddIdentity(this IServiceCollection services)
        {
            _ = services.AddIdentity<User, IdentityRole>(options =>
            {
                //For password
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 1;

                //Confimation User
                options.SignIn.RequireConfirmedEmail = false;
                options.SignIn.RequireConfirmedPhoneNumber = false;
                //For User
                options.User.RequireUniqueEmail = true;

            }
            ).AddRoleManager<RoleManager<IdentityRole>>()
            .AddEntityFrameworkStores<AppDbContext>()
            .AddUserManager<UserManager<User>>()
            .AddDefaultTokenProviders()
            .AddRoles<IdentityRole>();


            return services;
        }



    }
}
