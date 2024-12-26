using JiraStatistic.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace JiraStatistic.MockData
{
    public static class InfrastructureHelper
    {
        public static T GetRequiredService<T>()
        {
            var provider = Provider();
            return provider.GetRequiredService<T>();
        }

        private static IServiceProvider Provider()
        {
            var services = new ServiceCollection();
            services.AddScoped(typeof(IJiraRepository<>), typeof(JiraRepository<>));
            services.AddScoped<IJiraTaskRepository, JiraTaskRepository>();
            services.AddDbContext<JiraDbContext>(j => j.UseInMemoryDatabase("JiraStatistic.Infrastructure.Test"));

            return services.BuildServiceProvider();
        }
    }
}
