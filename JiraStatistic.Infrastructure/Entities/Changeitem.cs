namespace JiraStatistic.Infrastructure.Entities
{
    public class Changeitem : IHasId
    {
        public int Id { get; set; }

        public string Field { get; set; }

        public string Oldstring { get; set; }

        public string Newstring { get; set; }

        public int Groupid { get; set; }

        public Changegroup Changegroup {  get; set; }
    }
}
