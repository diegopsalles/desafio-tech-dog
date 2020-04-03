using Desafio.Tech.Dog.ApplicationService.Contracts.Request.Turma;
using Desafio.Tech.Dog.ApplicationService.Contracts.Responses.Turma;
using Desafio.Tech.Dog.ApplicationService.Interfaces;
using Desafio.Tech.Dog.Domain.Contracts.Services;
using Desafio.Tech.Dog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Tech.Dog.ApplicationService.Services
{
    public class TurmaApplicationService : ITurmaApplicationService
    {
        private readonly ITurmaDomainService _turmaDomainService;

        public TurmaApplicationService(ITurmaDomainService turmaDomainService) => _turmaDomainService = turmaDomainService;
        public AddTurmaResponse Add(AddTurmaRequest request)
        {
            var model = new Turma
            {
                Nome = request.TurmaMessage.Nome,
                Capacidade = request.TurmaMessage.Capacidade,
            };

            _turmaDomainService.Create(model);

            return new AddTurmaResponse(true, model.IdTurma);
        }

        public TurmaResponse Get(int Id)
        {
            throw new NotImplementedException();
        }

        public TurmaResponse List()
        {
            throw new NotImplementedException();
        }

        public TurmaResponse Update(AddTurmaRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
