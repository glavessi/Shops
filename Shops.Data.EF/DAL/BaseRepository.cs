using Microsoft.EntityFrameworkCore;
using Shops.Data.EF.Data;
using Shops.Data.EF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shops.Data.EF.DAL
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {        
        protected readonly ChallengeDBContext _Context;

        public BaseRepository(ChallengeDBContext context)
        {
            _Context = context;
        }

        public async Task<int> CommitChanges()
        {
            return await _Context.SaveChangesAsync();
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var entity = await _Context.Set<TEntity>().FindAsync(id);
            if (entity == null)
            {
                throw new Exception($"{nameof(id)} could not be found.");
            }

            try
            {
                _Context.Set<TEntity>().Remove(entity);
                int deleted = await CommitChanges();

                if (deleted > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw new Exception($"Couldn't delete the registry: {ex.Message}");
            }
        }

        public async Task<IList<TEntity>> GetAllAsync()
        {
            try
            {
                return await _Context.Set<TEntity>().AsNoTracking().ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Couldn't retrieve registries: {ex.Message}");
            }
        }

        public async Task<TEntity> GetByIdAsync(int[] id)
        {
            try
            {
                return await _Context.Set<TEntity>().FindAsync(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Couldn't find registry with id={id.ToString()}: {ex.Message}");
            }
        }

        public async Task<TEntity> InsertAsync(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            try
            {
                await _Context.Set<TEntity>().AddAsync(entity);
                int saved = await CommitChanges();

                if (saved > 0)
                    return entity;
                else 
                    return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(entity)} could not be saved: {ex.Message}");
            }
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            try
            {
                _Context.Set<TEntity>().Update(entity);
                int updated = await CommitChanges();

                if (updated > 0)
                    return entity;
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(entity)} could not be updated: {ex.Message}");
            }
        }      
    }
}
