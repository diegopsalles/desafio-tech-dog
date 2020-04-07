using Desafio.Tech.Dog.Domain.Contracts.Repositories;
using Desafio.Tech.Dog.Domain.Contracts.Services;
using Desafio.Tech.Dog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Tech.Dog.Domain.Service
{
    public class TurmaDomainService : BaseDomainService<Turma, int>, ITurmaDomainService
    {
        private readonly ITurmaRepository _turmaRepository;

        public TurmaDomainService(ITurmaRepository turmaRepository) : base(turmaRepository) => _turmaRepository = turmaRepository;

        public void Create(Turma turma) => _turmaRepository.Insert(turma);
        public void Delete(Turma obj) => _turmaRepository.Delete(obj);
        public List<Turma> ListAll() => _turmaRepository.GetTurmas();

        public Turma ListById(int id) => _turmaRepository.GetTurmaById(id);
        public void Update(Turma obj) => _turmaRepository.Update(obj);
    }
}
