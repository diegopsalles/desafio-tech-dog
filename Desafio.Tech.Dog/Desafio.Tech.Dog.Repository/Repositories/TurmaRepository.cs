using Desafio.Tech.Dog.Domain.Contracts.Repositories;
using Desafio.Tech.Dog.Domain.Entities;
using Desafio.Tech.Dog.Repository.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Tech.Dog.Repository.Repositories
{
    public class TurmaRepository : BaseRepository<Turma, int>, ITurmaRepository
    {
        public Turma GetTurmaById(int turmaId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var turma = ctx.Turma.Include("Alunos").FirstOrDefault(t => t.Id == turmaId);

                return turma;
            }
        }

        public List<Turma> GetTurmas() 
        {
            using (var ctx = new ApplicationDbContext())
            {
                var turmas = ctx.Turma.Include("Alunos").ToList();

                return turmas;
            }
        }

    }
}
