using JiraStatistic.Infrastructure.Entities;
using System.Linq.Expressions;

namespace JiraStatistic.Infrastructure
{
    public interface IJiraRepository<TEntity> where TEntity : IHasId
    {
        Task<IQueryable<TEntity>> GetAllAsync(FindOptions? findOptions = null);

        Task<TEntity> FindOneAsync(Expression<Func<TEntity, bool>> predicate);

        Task<IQueryable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate, FindOptions? findOptions = null);
    }
}
