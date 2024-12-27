namespace JiraStatistic.Domain
{
    /// <summary>
    /// Задача в Jira
    /// </summary>
    public class JiraTask
    {
        /// <summary>
        /// Тэг задачи
        /// </summary>
        public string Tag { get; set; }

        /// <summary>
        /// Название команды. но которой висит задача
        /// </summary>
        public string Team { get; set; }

        /// <summary>
        /// Cтатус задачи
        /// </summary>
        public TaskStatus TaskStatus { get; set; }

        /// <summary>
        /// Заголовок задачи
        /// </summary>
        public string Title { get; set; }
    }
}
