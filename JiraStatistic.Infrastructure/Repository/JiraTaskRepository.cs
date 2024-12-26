using JiraStatistic.Infrastructure.Entities;

namespace JiraStatistic.Infrastructure
{
    public class JiraTaskRepository: JiraRepository<JiraTaskEntity>, IJiraTaskRepository
    {
        public JiraTaskRepository(JiraDbContext jiraDbContext) : base(jiraDbContext) { }
    }
}
