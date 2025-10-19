using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Core.Interfaces
{
    public class RepositoryBase<TEntity, TId, TContext> : IRepository<TEntity, TId> 
        where TEntity : BaseEntity<TId>
        where TContext : DbContext
    {
        protected readonly TContext Context;
        public RepositoryBase(TContext context)
        {
            Context = context;
        }
        public async Task<TEntity> AddAsync(TEntity entity)
        {
            entity.CreatedDate = DateTime.UtcNow;            
            await Context.AddAsync(entity);
            await Context.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> DeleteAsync(TEntity entity)
        {
            //Soft Delete
            entity.DeletedDate = DateTime.UtcNow;
            Context.Update(entity);
            await Context.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await Context.Set<TEntity>()
                .AsNoTracking()
                .Where (e => e.DeletedDate == null)
                .ToListAsync();
        }

        public async Task<TEntity?> GetByIdAsync(TId id)
        {
            return await Context.Set<TEntity>()
                .AsNoTracking()
                .FirstOrDefaultAsync(e => e.Id.Equals(id) && e.DeletedDate == null);
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            entity.UpdatedDate = DateTime.UtcNow;
            Context.Update(entity);
            await Context.SaveChangesAsync();
            return entity;

        }
    }
}
