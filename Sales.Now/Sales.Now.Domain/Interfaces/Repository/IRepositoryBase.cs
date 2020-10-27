using Sales.Now.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Now.Domain.Interfaces.Repository
{
    public interface IRepositoryBase<TEntity> where TEntity : AbstractEntity
    {
        TEntity Add(TEntity entity);
        TEntity Update(TEntity entity);
        bool Delete(TEntity entity);
        bool Delete(long id);
        TEntity GetById(long id);
        Task<TEntity> GetByIdAsync(long id);
        List<TEntity> GetAll();
        Task<List<TEntity>> GetAllAsync();
        void Dispose();
        bool Commit();
    }
}
