using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreIdentity.Data
{
    public class AspNetCoreIdentityContext : IdentityDbContext
    {
        public AspNetCoreIdentityContext(DbContextOptions options)
            : base(options)
        {
        }
    }
}
