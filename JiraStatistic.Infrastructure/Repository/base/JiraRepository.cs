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

        public IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate, FindOptions? findOptions = null)
        {
            throw new NotImplementedException();
        }

        public TEntity FindOne(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetAll(FindOptions? findOptions = null)
        {
            throw new NotImplementedException();
        }
    }
}
