using Microsoft.EntityFrameworkCore;
using PostgresIntegration.Model;

namespace PostgresIntegration.Database
{
    public class BusinessContext:DbContext
    {
        public DbSet<User> Users { get; set; }

        public BusinessContext(DbContextOptions<BusinessContext> options) :
            base(options)
        {
        }
    }
}
