using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Core.Interfaces
{
    public interface IRepository<TEntity, TId> where TEntity : BaseEntity<TId>
    {
        Task<TEntity?> GetByIdAsync(TId id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> AddAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task<TEntity> DeleteAsync(TEntity entity);

    }
}
