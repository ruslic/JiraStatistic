namespace JiraStatistic.Infrastructure.Entities
{
    public class Issuestatus : IHasId
    {
        public int Id { get; set; }

        public string Pname { get; set; }
    }
}
