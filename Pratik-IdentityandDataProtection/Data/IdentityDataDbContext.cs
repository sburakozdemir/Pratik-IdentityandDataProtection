using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Pratik_IdentityandDataProtection.Data
{
    public class IdentityDataDbContext:IdentityDbContext<IdentityUser>
    {
        public IdentityDataDbContext(DbContextOptions<IdentityDataDbContext> options):base(options)
        {
            
        }
        public DbSet<User> Users { get; set; }
    }
}
