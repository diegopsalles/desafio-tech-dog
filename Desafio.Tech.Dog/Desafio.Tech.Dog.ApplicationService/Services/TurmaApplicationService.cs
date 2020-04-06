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
                var escolabyId = new GetTurmaByIdMessage();
                escolabyId.IdTurma = response.IdTurma;
                escolabyId.Nome = response.Nome;
                escolabyId.Alunos = new List<AlunoModel>();

                foreach (var turma in response.Alunos)
                {
                    var alunoModel = new AlunoModel()
                    {
                        IdAluno = turma.IdAluno,
                        Nome = turma.Nome
                    };
                    escolabyId.Alunos.Add(alunoModel);
                }
                return new GetTurmaByIdResponse(true, escolabyId);
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
                    Alunos = model.Alunos.Select(turma => new AlunoModel()
                    {
                        IdAluno = turma.IdAluno,
                        Nome = turma.Nome,
                    }).ToList()
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
                model.Update(request.Nome, request.Capacidade);

                _turmaDomainService.Update(model);

                return new UpdateTurmaResponse(true, message: "Turma was updated successfully!");
            }
            else
                return new UpdateTurmaResponse(false, error: "Fail to update Turma");
        }
    }
}
