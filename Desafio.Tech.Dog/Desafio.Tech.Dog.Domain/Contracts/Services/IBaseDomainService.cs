using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Tech.Dog.Domain.Contracts.Services
{
    public interface IBaseDomainService <TEntity, Tkey> where TEntity : class
    {
        void Create(TEntity obj);
        void Update(TEntity obj);
        void Delete(TEntity obj);
        List<TEntity> ListAll();
        TEntity ListById(Tkey id);
    }
}
