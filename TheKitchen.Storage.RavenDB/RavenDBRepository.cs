using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Raven.Client.Embedded;
using StaticVoid.Core.Repository;
using TheKitchen.Model.Models;

namespace TheKitchen.Storage.RavenDB
{
    public class RavenDBRepository<TEntity> : IRepository<TEntity> where TEntity : IEntity
    {
        public List<TEntity> Data = new List<TEntity>();

        public RavenDBRepository()
        {
            var documentStore = new EmbeddableDocumentStore { DataDirectory = "path/to/database/directory" };
            documentStore.Initialize();
        }

        public void Create(TEntity entity)
        {
            Data.Add(entity);
        }

        public void Update(TEntity entity)
        {
            var update = GetById(entity.ID);

            // Use reflection to update this object?
            //DbEntityEntry entityEntry = dataContext.Entry(entity);
            //if (entityEntry.State == EntityState.Detached)
            //{
            //    dataContext.Set<T>().Attach(entity);
            //    entityEntry.State = EntityState.Modified;
            //}
        }

        public void Delete(TEntity entity)
        {
            Data.Remove(entity);
        }

        public IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> filter = null)
        {
            IQueryable<TEntity> query = Data.OfType<TEntity>().AsQueryable();

            if (filter != null)
                query = query.Where(filter);

            return query;
        }

        public IQueryable<TEntity> GetAll()
        {
            return Data.AsQueryable();
        }

        public TEntity GetById(int id)
        {
            return Data.Where(p => p.ID == id).FirstOrDefault();
        }


        public TEntity GetBy(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includes)
        {
            return Data.AsQueryable().Where(predicate).FirstOrDefault();
        }

        public void Dispose()
        {
        }
    }
}
