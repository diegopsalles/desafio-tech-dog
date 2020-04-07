using Desafio.Tech.Dog.Domain.Contracts.Repositories;
using Desafio.Tech.Dog.Domain.Contracts.Services;
using Desafio.Tech.Dog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Tech.Dog.Domain.Service
{
    public class EscolaDomainService : BaseDomainService<Escola, int>, IEscolaDomainService
    {
        private readonly IEscolaRepository _escolaRepository;
        public EscolaDomainService(IEscolaRepository escolaRepository) : base(escolaRepository) => _escolaRepository = escolaRepository;

        public void Create(Escola escola) => _escolaRepository.Insert(escola);
        public void Delete(Escola obj) => _escolaRepository.Delete(obj);
        public List<Escola> ListAll() => _escolaRepository.GetEscola();
        public Escola ListById(int id) => _escolaRepository.GetEscolaById(id);
        public void Update(Escola obj) => _escolaRepository.Update(obj);

    }
}
