using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using ZWA.Domain.Core;

namespace ZWA.Application.Core
{
    public interface ICommandFactory<TKey, TEntity> where TEntity : IBaseEntity<TKey> where TKey : struct
    {
        void Insert(TEntity entity);

        void Insert(IEnumerable<TEntity> entities);
        
        void Update(TEntity entity);

        void Update(IEnumerable<TEntity> entities);

        void SoftDelete(TEntity entity);

        void SoftDelete(IEnumerable<TEntity> entities); 

        void SoftDeleteByPredicate(Expression<Func<TEntity, bool>> predicate); 
        
        void HardDelete(TEntity entity);

        void HardDelete(IEnumerable<TEntity> entities);

        void HardDeleteByPredicate(Expression<Func<TEntity, bool>> predicate);

    }
}
