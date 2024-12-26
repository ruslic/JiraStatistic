namespace JiraStatistic.Infrastructure.Entities
{
    public class JiraTaskEntity : IHasId
    {
        public int Id { get; set; }
        public string Tag { get; set; }
    }
}
