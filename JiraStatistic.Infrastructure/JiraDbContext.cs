using JiraStatistic.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
