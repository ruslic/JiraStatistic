using JiraStatistic.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace JiraStatistic.Infrastructure
{
    public class JiraDbContext: DbContext
    {
        public DbSet<JiraTaskEntity> JiraTasks { get; set; }

        public JiraDbContext(DbContextOptions<JiraDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
