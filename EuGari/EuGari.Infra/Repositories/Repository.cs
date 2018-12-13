using EuGari.Domain;
using EuGari.Domain.Contracts.Reporitories;
using EuGari.Infra.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EuGari.Infra.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly MyDataContext _ctx;

        public Repository(MyDataContext context)
        {
            _ctx = context;
        }
        public void Add(TEntity entity)
        {
            _ctx.Set<TEntity>().Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            _ctx.Set<TEntity>().AddRange(entities);
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _ctx.Set<TEntity>().Where(predicate);
        }

        public TEntity Get(int id)
        {
            return _ctx.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _ctx.Set<TEntity>().ToList();
        }

        public void Remove(TEntity entity)
        {
            _ctx.Set<TEntity>().Remove(entity);
        }

        public void Remove(IEnumerable<TEntity> entities)
        {
            _ctx.Set<TEntity>().RemoveRange(entities);
        }
    }
}
