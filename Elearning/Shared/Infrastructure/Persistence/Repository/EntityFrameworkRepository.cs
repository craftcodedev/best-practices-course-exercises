using System;
using System.Linq;
using elearning.Shared.Infrastructure.Helper;
using elearning.Shared.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using elearning.Shared.Domain;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using elearning.Shared.Domain.Criteria;

namespace elearning.Shared.Infrastructure.Persistence.Repository
{
    public class EntityFrameworkRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly ELearningContext Db;
        protected readonly DbSet<TEntity> DbSet;
        protected readonly IServiceScopeFactory ScopeFactory;

        public EntityFrameworkRepository(ELearningContext context, IServiceScopeFactory scopeFactory)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
            ScopeFactory = scopeFactory;
        }

        public virtual void Add(TEntity obj)
        {
            DbSet.Add(obj);
        }

        public virtual TEntity Get(UUID id)
        {
            using (var scope = ScopeFactory.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<ELearningContext>();
                IQueryable<TEntity> query = dbContext.Set<TEntity>();

                return query.FirstOrDefault<TEntity>(x => (Reflection.GetObjectProperty(Reflection.GetObjectProperty(x, "Id"), "Value")).ToString() == id.Value);
            }
        }

        public virtual List<TEntity> Find(Criteria criteria)
        {
            using (var scope = ScopeFactory.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<ELearningContext>();
                IQueryable<TEntity> query = dbContext.Set<TEntity>();

                foreach (Criterion criterion in criteria.Criterion)
                {
                    query = query.Where(x => (Reflection.GetObjectProperty(Reflection.GetObjectProperty(x, StringValueObject.UppercaseFirst(criterion.Field.Value)), "Value")).ToString() == criterion.Value.Value);
                }

                query = query
                    .Skip((criteria.Limit.Value - 1) * criteria.Offset.Value)
                    .Take(criteria.Offset.Value);

                return query.ToList();
            }
        }

        public virtual void Update(TEntity obj)
        {
            DbSet.Update(obj);
        }

        public virtual void Remove(Guid id)
        {
            DbSet.Remove(DbSet.Find(id));
        }

        public void Dispose()
        {
            //Db.Dispose();
            //GC.SuppressFinalize(this);
        }

        public virtual void Save(TEntity obj)
        {
            using (var scope = ScopeFactory.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<ELearningContext>();
                dbContext.Add(obj);
                dbContext.SaveChanges();
            }
        }
    }
}