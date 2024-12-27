using JiraStatistic.Infrastructure.Entities;
using System.Linq.Expressions;

namespace JiraStatistic.Infrastructure
{
    public class JiraRepository<TEntity> : IJiraRepository<TEntity> where TEntity : IHasId
    {
        private readonly JiraDbContext _dbContext;

        public JiraRepository(JiraDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IQueryable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate, FindOptions? findOptions = null)
        {
            throw new NotImplementedException();
        }

        public async Task<TEntity> FindOneAsync(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task<IQueryable<TEntity>> GetAllAsync(FindOptions? findOptions = null)
        {
            throw new NotImplementedException();
        }
    }
}
