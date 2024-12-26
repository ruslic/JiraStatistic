using JiraStatistic.Infrastructure.Entities;
using System.Linq.Expressions;

namespace JiraStatistic.Infrastructure
{
    public interface IJiraRepository<TEntity> where TEntity : IHasId
    {
        IQueryable<TEntity> GetAll(FindOptions? findOptions = null);

        TEntity FindOne(Expression<Func<TEntity, bool>> predicate);

        IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate, FindOptions? findOptions = null);
    }
}
