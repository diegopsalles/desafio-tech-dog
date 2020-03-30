using Desafio.Tech.Dog.Domain.Contracts.Repositories;
using Desafio.Tech.Dog.Domain.Contracts.Services;
using Desafio.Tech.Dog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Tech.Dog.Domain.Service
{
    public class AlunoDomainService : BaseDomainService<Aluno, int>, IAlunoDomainService
    {
        private readonly IAlunoRepository _alunoRepository;
        public AlunoDomainService(IAlunoRepository alunoRepository) : base(alunoRepository) => _alunoRepository = alunoRepository;

        public void Create(Aluno aluno) => _alunoRepository.Insert(aluno);
        public void Delete(Aluno obj) => _alunoRepository.Delete(obj);
        public List<Aluno> ListAll() => _alunoRepository.GetAll();
        public Aluno ListById(int id) => _alunoRepository.GetById(id);
        public void Update(Aluno obj) => _alunoRepository.Update(obj);
    }
}
