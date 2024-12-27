using JiraStatistic.Domain;

namespace JiraStatistic.Manager
{
    public interface IGetTeamTaskHistory
    {
        Task<List<HistoryTask>> GetTeamTaskHistory(string team, int year);
    }
}
