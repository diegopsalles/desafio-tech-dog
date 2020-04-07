using Desafio.Tech.Dog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Tech.Dog.Domain.Contracts.Repositories
{
    public interface ITurmaRepository : IBaseRepository<Turma, int>
    {
        Turma GetTurmaById(int turmaId);

        List<Turma> GetTurmas();
    }
}
