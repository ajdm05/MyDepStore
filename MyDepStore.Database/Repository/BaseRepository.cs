using MyDepStore.Database.Model;
using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace MyDepStore.Database.Repository
{
    public abstract class BaseRepository<TEntity> where TEntity : class
    {
        public BaseRepository(MyDepStoreContext context)
        {
            this.Context = context;   
        }

        public MyDepStoreContext Context { get; protected set; }

        public abstract IQueryable<TEntity> All();

        public virtual IQueryable<TEntity> Filter(Expression<Func<TEntity, bool>> predicate)
        {
            return this.All().Where(predicate);
        }

        public virtual TEntity First(Expression<Func<TEntity, bool>> predicate)
        {
            return this.Filter(predicate).First();
        }

        public virtual TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return this.Filter(predicate).FirstOrDefault();
        }

        public virtual TEntity Create(TEntity entity)
        {
            var entry = this.Context.Entry(entity);
            entry.State = EntityState.Added;
            return entity;
        }

        public virtual TEntity Update(TEntity entity)
        {
            var entry = this.Context.Entry(entity);
            entry.State = EntityState.Modified;
            return entity;
        }

        public virtual TEntity Delete(TEntity entity)
        {
            var entry = this.Context.Entry(entity); ;
            entry.State = EntityState.Deleted;
            return entity;
        }

        public virtual void SaveChanges()
        {
            this.Context.SaveChanges();
        }

        protected abstract TEntity MapNewValuesToOld(TEntity oldentity, TEntity newEntity);
    }
}
