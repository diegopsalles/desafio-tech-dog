using Desafio.Tech.Dog.ApplicationService.Contracts.Request.Aluno;
using Desafio.Tech.Dog.ApplicationService.Contracts.Responses.Aluno;
using Desafio.Tech.Dog.ApplicationService.Interfaces;
using Desafio.Tech.Dog.Domain.Contracts.Services;
using Desafio.Tech.Dog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Tech.Dog.ApplicationService.Services
{
    public class AlunoApplicationService : IAlunoApplicationService
    {
        private readonly IAlunoDomainService _alunoDomainService;

        public AlunoApplicationService( IAlunoDomainService alunoDomainService) => _alunoDomainService = alunoDomainService;

        public AddAlunoResponse Add(AddAlunoRequest request)
        {
            var model = new Aluno { Nome = request.AlunoMessage.Nome, DataDeNascimento = request.AlunoMessage.DataDeNascimento};

            _alunoDomainService.Create(model);

            return new AddAlunoResponse(true, model.IdAluno);
        }

        public GetAlunoByIdResponse Get(int Id)
        {
            throw new NotImplementedException();
        }

        public ListAlunoResponse List()
        {
            throw new NotImplementedException();
        }

        public UpdateAlunoResponse Update(UpdateAlunoRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
