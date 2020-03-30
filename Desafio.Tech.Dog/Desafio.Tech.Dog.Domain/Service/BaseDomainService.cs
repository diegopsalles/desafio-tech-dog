using Desafio.Tech.Dog.Domain.Contracts.Repositories;
using Desafio.Tech.Dog.Domain.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Tech.Dog.Domain.Service
{
    public class BaseDomainService<TEntity, TKey> : IBaseDomainService<TEntity, TKey> where TEntity : class
    {
        private readonly IBaseRepository<TEntity, TKey> _baseRepository;

        public BaseDomainService(IBaseRepository<TEntity, TKey> baseRepository) => _baseRepository = baseRepository;
        public void Create(TEntity obj) => this._baseRepository.Insert(obj);
    
        public void Delete(TEntity obj) => this._baseRepository.Delete(obj);

        public List<TEntity> ListAll() => this.ListAll();

        public TEntity ListById(TKey id) => this.ListById(id);

        public void Update(TEntity obj) => this.Update(obj);
    }
}
