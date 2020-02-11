using System;
using Filmes.Application.Interfaces;
using Filmes.Domain.Interfaces.Services;

namespace Filmes.Application
{
    public class AppServiceBase : IDisposable, IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _serviceBase;

        public AppServiceBase(IServiceBase<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;
        }

        public void Add(TEntity entity)
        {
            _serviceBase.Add(entity);
        }

        public void Dispose()
        {
            _serviceBase.Dispose();
        }

        public System.Collections.Generic.IEnumerable<TEntity> GetAll()
        {
            _serviceBase.GetAll();
        }

        public TEntity GetById(Guid id)
        {
            _serviceBase.GetById(id);
        }

        public void Remove(TEntity entity)
        {
            _serviceBase.Remove(entity);
        }

        public void Update(TEntity entity)
        {
            _serviceBase.Update(entity);
        }
    }
}
