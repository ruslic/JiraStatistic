namespace JiraStatistic.Infrastructure.Entities
{
    public class Changegroup : IHasId
    {
        public int Id { get; set; }

        public DateTime Created { get; set; }

        public int Issueid { get; set; }

        public JiraIssue JiraIssue { get; set; }
    }
}
