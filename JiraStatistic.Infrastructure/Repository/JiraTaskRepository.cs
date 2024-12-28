using JiraStatistic.Infrastructure.Entities;

namespace JiraStatistic.Infrastructure
{
    public class JiraTaskRepository: JiraRepository<JiraIssue>, IJiraTaskRepository
    {
        public JiraTaskRepository(JiraDbContext jiraDbContext) : base(jiraDbContext) { }
    }
}
