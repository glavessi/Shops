using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shops.Data.EF.DAL
{

    //Base repository to be used across all entities repos
    public interface IBaseRepository<TEntity> : IDisposable
    {
        Task<IList<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(int[] id);
        Task<TEntity> InsertAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task<bool> DeleteAsync(int id);
        Task<int> CommitChanges();
    }
}
