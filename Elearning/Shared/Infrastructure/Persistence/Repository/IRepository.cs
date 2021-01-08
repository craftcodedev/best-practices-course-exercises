using System;
using System.Collections.Generic;
using elearning.Shared.Domain;
using elearning.Shared.Domain.Criteria;

namespace elearning.Shared.Infrastructure.Persistence.Repository
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity obj);
        TEntity Get(UUID id);
        List<TEntity> Find(Criteria criteria);
        void Update(TEntity obj);
        void Remove(Guid id);
    }
}