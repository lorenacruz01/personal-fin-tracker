using Microsoft.EntityFrameworkCore;
using PersonalFinTracker.Domain.Entities;

namespace PersonalFinTracker.Infrastructure.Persistence
{
    public class FinTrackerDbContext : DbContext
    {
        public FinTrackerDbContext(DbContextOptions<FinTrackerDbContext> options)
        : base(options)
        {
        }

        public DbSet<User> Users => Set<User>();
    }
}
