using RestoDDD.Application.Interfaces;
using RestoDDD.Domaine.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoDDD.Application.Services
{
    public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _serviceBase;

        public AppServiceBase(IServiceBase<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;
        }



        public bool Add(TEntity obj)
        {
         return   _serviceBase.Add(obj);
        }

        public TEntity GetById(int id)
        {
            return _serviceBase.GetById(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _serviceBase.GetAll();
        }

        public bool Update(TEntity obj)
        {
             return _serviceBase.Update(obj);
        }

        public bool Remove(int id)
        {
         return  _serviceBase.Remove(int);
        }

        public void Dispose()
        {
            _serviceBase.Dispose();
        }
    }
}
