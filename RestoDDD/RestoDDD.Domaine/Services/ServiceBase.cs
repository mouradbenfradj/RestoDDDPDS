using RestoDDD.Domaine.Interfaces.Repositories;
using RestoDDD.Domaine.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace RestoDDD.Domaine.Services
{
    public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public bool Add(TEntity obj)
        {
          return  _repository.Add(obj);
        }

        public TEntity GetById(int id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public bool Update(TEntity obj)
        {
            return _repository.Update(obj);
        }

        public bool Remove(TEntity obj)
        {
            return _repository.Remove(obj);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }
    }
}
