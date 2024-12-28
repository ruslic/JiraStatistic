namespace JiraStatistic.Infrastructure.Entities
{
    public class JiraIssue : IHasId
    {
        public int Id { get; set; }

        public int Issuenum { get; set; }

        public string Summary { get; set; }

        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }

        public int ProjectId {  get; set; }

        public Project Project { get; set; }

        public int IssuestatusId { get; set; }

        public Issuestatus Issuestatus {  get; set; }
    }
}
