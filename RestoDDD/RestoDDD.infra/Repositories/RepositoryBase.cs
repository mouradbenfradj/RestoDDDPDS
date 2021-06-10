using RestoDDD.Domaine.Interfaces.Repositories;
using RestoDDD.infra.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace RestoDDD.infra.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected RestoContext Db = new RestoContext();

        public bool Add(TEntity obj)
        {
            Db.Set<TEntity>().Add(obj);
            if (Db.SaveChanges() > 0)
            {
                return true;
            }
            else
                return false;
        }

        public TEntity GetById(int id)
        {
            return Db.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Db.Set<TEntity>().ToList();
        }

        public bool Update(TEntity obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            if (Db.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Remove(TEntity obj)
        {
            var objj = Db.Set<TEntity>().Find(obj);
            //Db.Entry(obj2).State = EntityState.Deleted;
            Db.Set<TEntity>().Remove(objj);
            if (Db.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    Db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
