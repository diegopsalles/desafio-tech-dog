using Desafio.Tech.Dog.ApplicationService.Contracts.Messages.Turma;
using Desafio.Tech.Dog.ApplicationService.Contracts.Request.Turma;
using Desafio.Tech.Dog.ApplicationService.Contracts.Responses.Turma;
using Desafio.Tech.Dog.ApplicationService.Interfaces;
using Desafio.Tech.Dog.ApplicationService.Models;
using Desafio.Tech.Dog.Domain.Contracts.Services;
using Desafio.Tech.Dog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Desafio.Tech.Dog.ApplicationService.Services
{
    public class TurmaApplicationService : ITurmaApplicationService
    {
        private readonly ITurmaDomainService _turmaDomainService;

        public TurmaApplicationService(ITurmaDomainService turmaDomainService) => _turmaDomainService = turmaDomainService;
        public AddTurmaResponse Add(AddTurmaRequest request)
        {
            var model = new Turma();

            model.Add(request.TurmaMessage.Nome, request.TurmaMessage.Capacidade);

            _turmaDomainService.Create(model);

            return new AddTurmaResponse(true, model.IdTurma);
        }

        public DeleteTurmaResponse Delete(DeleteTurmaRquest request)
        {
            var model = _turmaDomainService.ListById(request.IdTurma);

            if (model != null && model.IdTurma > 0)
            {
                _turmaDomainService.Delete(model);
                return new DeleteTurmaResponse(true, message: "Turma was deleted successfully!");
            }
            else
                return new DeleteTurmaResponse(false, error: "Fail to delete Turma!");
        }

        public GetTurmaByIdResponse Get(GetTurmaByIdRequest request)
        {
            var response = _turmaDomainService.ListById(request.IdTurma);

            if (response != null && response.IdTurma > 0)
            {
                var turmabyId = new GetTurmaByIdMessage
                {
                    IdTurma = response.IdTurma,
                    Nome = response.Nome,
                    Capacidade = response.Capacidade,
                    Alunos = new List<AlunoModel>()
                    {
                        IdAluno = response.Alunos.IdAluno,
                        Nome = response.Alunos.Nome,
                        DataDeNascimento = response.Alunos.DataDeNascimento
                    },
                };
                return new GetTurmaByIdResponse(true, turmabyId);
            }
            else
                return new GetTurmaByIdResponse(false);
        }

        public ListTurmaResponse List()
        {
            var lstModel = _turmaDomainService.ListAll();

            if (lstModel != null && lstModel.Count > 0)
            {
                List<ListTurmaMessage> lstEscola = lstModel.Select(model => new ListTurmaMessage
                {
                    IdTurma = model.IdTurma,
                    Nome = model.Nome,
                    Capacidade = model.Capacidade,
                    Alunos = new List<AlunoModel>()
                    {
                        IdAluno= model.Alunos.IdAluno,
                        Nome = model.Alunos.Nome,
                        DataDeNascimento = model.Alunos.DataDeNascimento
                    }
                }).ToList();
                return new ListTurmaResponse(true, lstEscola);
            }
            else
                return new ListTurmaResponse(false);
        }

        public UpdateTurmaResponse Update(UpdateTurmaRequest request)
        {
            var model = _turmaDomainService.ListById(request.IdTurma);

            if (model != null && model.IdTurma > 0)
            {
                model.Update(model.Nome, model.Capacidade);

                _turmaDomainService.Update(model);

                return new UpdateTurmaResponse(true, message: "Turma was updated successfully!");
            }
            else
                return new UpdateTurmaResponse(false, error: "Fail to update Turma");
        }
    }
}
