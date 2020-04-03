using Desafio.Tech.Dog.ApplicationService.Contracts.Messages.Aluno;
using Desafio.Tech.Dog.ApplicationService.Contracts.Request.Aluno;
using Desafio.Tech.Dog.ApplicationService.Contracts.Responses.Aluno;
using Desafio.Tech.Dog.ApplicationService.Interfaces;
using Desafio.Tech.Dog.Domain.Contracts.Services;
using Desafio.Tech.Dog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
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
            var lstModel = _alunoDomainService.ListAll();
            
            if(lstModel != null && lstModel.Count > 0)
            {
                var lstAluno = lstModel.Select(model => new ListAlunoMessage
                {
                    IdAluno = model.IdAluno,
                    Nome = model.Nome,
                    DataDeNascimento = model.DataDeNascimento,
                    IdTurma = model.Turma
                }).ToList();
                return new ListAlunoResponse(true, lstAluno);
            }
        }

        public UpdateAlunoResponse Update(UpdateAlunoRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
