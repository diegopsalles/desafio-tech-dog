﻿using Desafio.Tech.Dog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Tech.Dog.Domain.Contracts.Repositories
{
    public interface IEscolaRepository : IBaseRepository<Escola, int>
    {
        Escola GetEscolaById(int escolaId);

        List<Escola> GetEscola();
    }
}
