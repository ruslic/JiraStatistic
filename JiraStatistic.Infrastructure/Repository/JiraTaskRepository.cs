using JiraStatistic.Infrastructure.Entities;

namespace JiraStatistic.Infrastructure
{
    internal class JiraTaskRepository: JiraRepository<JiraTaskEntity>, IJiraTaskRepository
    {
        public JiraTaskRepository(JiraDbContext jiraDbContext) : base(jiraDbContext) { }
    }
}
