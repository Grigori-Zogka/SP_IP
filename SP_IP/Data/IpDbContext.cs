using Microsoft.EntityFrameworkCore;

namespace SP_IP.Data
{//class set usp the DB connection details
    public class IpDbContext: DbContext
    {
        public IpDbContext(DbContextOptions<IpDbContext> options)
           : base(options)
        {
        }

        public DbSet<IpModel> IpModels { get; set; }

    }
}
