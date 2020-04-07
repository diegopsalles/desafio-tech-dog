using Desafio.Tech.Dog.Domain.Contracts.Repositories;
using Desafio.Tech.Dog.Domain.Entities;
using Desafio.Tech.Dog.Repository.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Desafio.Tech.Dog.Repository.Repositories
{
    public class EscolaRepository : BaseRepository<Escola, int>, IEscolaRepository
    {
        public Escola GetEscolaById(int escolaId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var escola = ctx.Escola.Include("Endereco").Include("Turmas").FirstOrDefault(t => t.Id == escolaId);

                return escola;
            }
        }

        public List<Escola> GetEscola()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var escolas = ctx.Escola.Include("Turmas").Include("Endereco").ToList();

                return escolas;
            }
        }
    }
}
