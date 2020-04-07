using Desafio.Tech.Dog.ApplicationService.Contracts.Messages.Aluno;
using Desafio.Tech.Dog.ApplicationService.Contracts.Request.Aluno;
using Desafio.Tech.Dog.ApplicationService.Contracts.Responses.Aluno;
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
    public class AlunoApplicationService : IAlunoApplicationService
    {
        private readonly IAlunoDomainService _alunoDomainService;

        public AlunoApplicationService(IAlunoDomainService alunoDomainService) => _alunoDomainService = alunoDomainService;

        public AddAlunoResponse Add(AddAlunoRequest request)
        {
            var model = new Aluno();

            model.Add(request.AlunoMessage.Nome, request.AlunoMessage.DataDeNascimento, request.AlunoMessage.IdTurma);

            _alunoDomainService.Create(model);

            return new AddAlunoResponse(true, model.Id);
        }

        public DeleteAlunoResponse Delete(DeleteAlunoRequest request)
        {
            var model = _alunoDomainService.ListById(request.IdAluno);

            if (model != null && model.Id > 0)
            {
                _alunoDomainService.Delete(model);
                return new DeleteAlunoResponse(true, message: "Aluno was deleted successfully!");
            }
            else
                return new DeleteAlunoResponse(false, error: "Fail to delete Aluno!");
        }

        public GetAlunoByIdResponse Get(GetAlunoByIdRequest request)
        {
            var response = _alunoDomainService.ListById(request.IdAluno);

            if (response != null && response.Id > 0)
            {
                var alunobyId = new GetAlunoByIdMessage
                {
                    IdAluno = response.Id,
                    Nome = response.Nome,
                    DataDeNascimento = response.DataDeNascimento,
                    IdTurma = response.TurmaId,
                };
                //if (response.Turma != null)
                //{
                //    alunobyId.IdTurma = new TurmaModel()
                //    {
                //        IdTurma = response.Turma.IdTurma,
                //        Nome = response.Turma.Nome,
                //        Capacidade = response.Turma.Capacidade
                //    };
                //}
                return new GetAlunoByIdResponse(true, alunobyId);
            }
            else
                return new GetAlunoByIdResponse(false);
        }

        public ListAlunoResponse List()
        {
            var lstModel = _alunoDomainService.ListAll();

            if (lstModel != null && lstModel.Count > 0)
            {
                List<ListAlunoMessage> lstAluno = new List<ListAlunoMessage>();

                lstModel.ForEach(model =>
                {
                    ListAlunoMessage aluno = new ListAlunoMessage();
                    aluno.IdAluno = model.Id;
                    aluno.Nome = model.Nome;
                    aluno.DataDeNascimento = model.DataDeNascimento;
                    aluno.IdTurma = model.TurmaId;
                    //if (model.Turma != null)
                    //{
                    //    aluno.IdTurma = new TurmaModel()
                    //    {
                    //        IdTurma = model.Turma.IdTurma,
                    //        Nome = model.Turma.Nome,
                    //        Capacidade = model.Turma.Capacidade
                    //    };
                    //}
                    lstAluno.Add(aluno);
                });

                return new ListAlunoResponse(true, lstAluno);
            }
            else
                return new ListAlunoResponse(false);
        }

        public UpdateAlunoResponse Update(UpdateAlunoRequest request)
        {
            var model = _alunoDomainService.ListById(request.IdAluno);

            if (model != null && model.Id > 0)
            {
                model.Update(request.Nome, request.DataDeNascimento, request.IdTurma);//, request.Turma.IdTurma, request.Turma.Nome, request.Turma.Capacidade);

                _alunoDomainService.Update(model);

                return new UpdateAlunoResponse(true, message: "Aluno was updated successfully!");
            }
            else
                return new UpdateAlunoResponse(false, error: "Fail to update Aluno");
        }
    }
}
