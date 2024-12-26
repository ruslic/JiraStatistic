using JiraStatistic.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace JiraStatistic.Infrastructure
{
    internal class JiraDbContext: DbContext
    {
        public DbSet<JiraTaskEntity> JiraTasks { get; set; }

        public JiraDbContext(DbContextOptions<JiraDbContext> options) : base(options)
        {
        }
    }
}
