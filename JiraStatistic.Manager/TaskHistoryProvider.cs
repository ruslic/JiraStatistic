using JiraStatistic.Domain;
using JiraStatistic.Infrastructure;

namespace JiraStatistic.Manager
{
    public class TaskHistoryProvider : IGetTeamTaskHistory
    {
        private IJiraTaskRepository _jiraTaskRepository;

        public TaskHistoryProvider(IJiraTaskRepository jiraTaskRepository)
        {
            _jiraTaskRepository = jiraTaskRepository;
        }

        public async Task<List<HistoryTask>> GetTeamTaskHistory(string team, int year)
        {
            throw new NotImplementedException();
        }
    }
}
