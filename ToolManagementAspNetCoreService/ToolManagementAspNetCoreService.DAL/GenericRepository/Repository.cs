using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ToolManagementAspNetCoreService.Domain;

namespace ToolManagementAspNetCoreService.DAL.GenericRepository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        internal TaskManagementDBContext _context;
        internal DbSet<TEntity> dbSet;

        public Repository(TaskManagementDBContext context)
        {
            this._context = context;
            this.dbSet = _context.Set<TEntity>();
        }
        public virtual async Task<TEntity> GetById(int id)
        {
            return await dbSet.FindAsync(id);
        }
        public virtual async Task<bool> Add(TEntity entity)
        {
            await dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
            return true;
        }
        public virtual async Task<bool> Delete(int id)
        {
            var entityToDelete = dbSet.Find(id);
            if (entityToDelete != null)
            {
                if (_context.Entry(entityToDelete).State == EntityState.Detached)
                {
                    dbSet.Attach(entityToDelete);
                }
                dbSet.Remove(entityToDelete);
                await _context.SaveChangesAsync();
            }

            return true;
        }
        public virtual async Task<IEnumerable<TEntity>> All()
        {
            return await dbSet.ToListAsync();
        }
        public async Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return await dbSet.Where(predicate).ToListAsync();
        }
        public virtual async Task<bool> Edit(TEntity entity)
        {
            dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return true;
        }
        public IEnumerable<TEntity> Include(params Expression<Func<TEntity, object>>[] includes)
        {
            DbSet<TEntity> dbSet = _context.Set<TEntity>();

            IEnumerable<TEntity>? query = null;
            foreach (var include in includes)
            {
                query = dbSet.Include(include);
            }

            return query ?? dbSet;
        }
        public virtual async Task<IEnumerable<TEntity>> FindbyID(Expression<Func<TEntity, bool>> predicate)
        {
            return await _context.Set<TEntity>().Where(predicate).ToListAsync();
        }
        public async Task<TEntity> Get(Expression<Func<TEntity, bool>> predicate)
        {
            return await _context.Set<TEntity>().Where(predicate).FirstOrDefaultAsync();
        }
    }
}
