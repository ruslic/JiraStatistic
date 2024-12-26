using JiraStatistic.Infrastructure;
using JiraStatistic.MockData;

namespace JiraStatistic.Infrestructure.Test
{
    public class JiraTaskRepository
    {
        private readonly IJiraTaskRepository _repository;
        public JiraTaskRepository() 
        {
            _repository = InfrastructureHelper.GetRequiredService<IJiraTaskRepository>() ?? throw new ArgumentNullException(nameof(IJiraTaskRepository));
        }

        [Fact]
        public void Test1()
        {

        }
    }
}