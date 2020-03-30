using Desafio.Tech.Dog.Domain.Contracts.Repositories;
using Desafio.Tech.Dog.Domain.Contracts.Services;
using Desafio.Tech.Dog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Tech.Dog.Domain.Service
{
    public class EnderecoDomainService : BaseDomainService<Endereco, int>, IEnderecoDomainService
    {
        private readonly IEnderecoRepository _enderecoRepository;
        public EnderecoDomainService(IEnderecoRepository enderecoRepository) : base(enderecoRepository) => _enderecoRepository = enderecoRepository;

        public void Create(Endereco endereco) => _enderecoRepository.Insert(endereco);
        public void Delete(Endereco obj) => _enderecoRepository.Delete(obj);
        public List<Endereco> ListAll() => _enderecoRepository.GetAll();
        public Endereco ListById(int id) => _enderecoRepository.GetById(id);
        public void Update(Endereco obj) => _enderecoRepository.Update(obj);
    }
}
