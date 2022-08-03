using Microsoft.Extensions.Logging;
using Shops.BLL.MapperService;
using Shops.Data.EF.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shops.BLL.Services
{
    public class BaseService<TRepository, TEntity> : AutoMapperService, IBaseService<TEntity> where TRepository : IBaseRepository<TEntity> where TEntity : class
    {        
        protected readonly IBaseRepository<TEntity> Repository;        
        protected readonly ILogger Logger;

        public BaseService(TRepository repo, ILogger log)
        {
            Repository = repo;
            Logger = log;            
        }        

        public Task<bool> DeleteAsync(int id)
        {
            return Repository.DeleteAsync(id);
        }

        public Task<IList<TEntity>> GetAllAsync()
        {
            return Repository.GetAllAsync();
        }

        public Task<TEntity> GetByIdAsync(int[] id)
        {
            return Repository.GetByIdAsync(id);
        }

        public Task<TEntity> InsertAsync(TEntity entity)
        {
            return Repository.InsertAsync(entity);
        }

        public Task<TEntity> UpdateAsync(TEntity entity)
        {
            return Repository.UpdateAsync(entity);
        }        
    }
}
