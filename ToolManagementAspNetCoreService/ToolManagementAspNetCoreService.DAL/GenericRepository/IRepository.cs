using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ToolManagementAspNetCoreService.DAL.GenericRepository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> All();
        Task<IEnumerable<TEntity>> FindbyID(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> GetById(int id);
        Task<bool> Add(TEntity entity);
        Task<bool> Delete(int id);
        Task<bool> Edit(TEntity entity);
        Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> Get(Expression<Func<TEntity, bool>> predicate);
    }
}
