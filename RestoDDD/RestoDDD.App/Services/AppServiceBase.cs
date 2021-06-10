using AutoMapper;
using RestoDDD.Application.Interfaces;
using RestoDDD.Domaine.Interfaces.Services;
using System.Collections.Generic;
namespace RestoDDD.Application.Services
{
    public class AppServiceBase<TEntity,TEntity_DTO> : IAppServiceBase<TEntity_DTO>
        where TEntity_DTO : class
        where TEntity : class
        
    {
        private readonly IServiceBase<TEntity> _serviceBase;

        public AppServiceBase(IServiceBase<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;
        }



        public bool Add(TEntity_DTO obj)
        {
            var obj_TDO = Mapper.Map<TEntity_DTO, TEntity>(obj);
            return _serviceBase.Add(obj_TDO);
        }

        public TEntity_DTO GetById(int id)
        {
            var entityAdapter = Mapper.Map<TEntity, TEntity_DTO>(_serviceBase.GetById(id));
            return entityAdapter;
        }

        public IEnumerable<TEntity_DTO> GetAll()
        {
            var entityAdapter = Mapper.Map<IEnumerable<TEntity>, IEnumerable<TEntity_DTO>>(_serviceBase.GetAll());
            return entityAdapter;
        }

        public bool Update(TEntity_DTO obj)
        {
            var obj_TDO = Mapper.Map<TEntity_DTO, TEntity>(obj);
            return _serviceBase.Update(obj_TDO);
        }

        public bool Remove(TEntity_DTO obj)
        {
            var obj_TDO = Mapper.Map<TEntity_DTO, TEntity>(obj);
            return _serviceBase.Remove(obj_TDO);
        }

        public void Dispose()
        {
            _serviceBase.Dispose();
        }
    }
}
