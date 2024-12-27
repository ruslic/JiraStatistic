namespace JiraStatistic.Domain
{
    /// <summary>
    /// История задачи в Jira
    /// </summary>
    public class HistoryTask: JiraTask
    {
        /// <summary>
        /// Время изменения
        /// </summary>
        public DateTime ChangedTime { get; set; }

        /// <summary>
        /// Имя пльзователя, изменившего задачу
        /// </summary>
        public string Chenger { get; set; }

        /// <summary>
        /// Список измененных полей
        /// </summary>
        public HashSet<string> ChangedFields { get; set; }
    }
}
