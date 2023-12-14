using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using IdentityService.Identity;

namespace ApplicationContext
{
    public class ApplicationContext : IdentityDbContext<User>
    {

    }
}
