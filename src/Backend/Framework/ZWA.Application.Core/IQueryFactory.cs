using System;
using System.Linq;
using System.Linq.Expressions;
using ZWA.Domain.Core;

namespace ZWA.Application.Core
{
    public interface IQueryFactory<TKey, TEntity> where TEntity : IBaseEntity<TKey> where TKey : struct
    {
        IQueryable<TEntity> InitQuery(Expression<Func<TEntity, bool>> predicate = null);

        IQueryable<TEntity> InitIncludableQuery(Expression<Func<TEntity, bool>> predicate = null, params Expression<Func<TEntity, object>>[] includeProperties);
    }
}
