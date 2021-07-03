using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubLockerAPI.Data.DataAccess.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
      
        IQueryable<TEntity> GetAll();
        Task<bool> Add(TEntity model);
        Task<TEntity> GetById(object Id);
        Task<bool> Modify(TEntity entity);
        Task<bool> DeleteById(object Id);
          
    }
    
}
