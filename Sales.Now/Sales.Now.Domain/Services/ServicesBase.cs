using Sales.Now.Domain.DTO;
using Sales.Now.Domain.Interfaces.Repository;
using Sales.Now.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Now.Domain.Services
{
    public class ServicesBase<TEntity> : IServicesBase<TEntity> where TEntity : AbstractEntity
    {
        private readonly IRepositoryBase<TEntity> _repositoryBase;

        public ServicesBase(IRepositoryBase<TEntity> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }

        public TEntity Add(TEntity entity)
        {
            return _repositoryBase.Add(entity);
        }

        public bool Commit()
        {
            return _repositoryBase.Commit();
        }

        public bool Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(long id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(long id)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public TEntity Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
