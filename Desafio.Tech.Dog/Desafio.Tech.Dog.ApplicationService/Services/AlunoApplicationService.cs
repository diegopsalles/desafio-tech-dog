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

        public AlunoApplicationService( IAlunoDomainService alunoDomainService) => _alunoDomainService = alunoDomainService;

        public AddAlunoResponse Add(AddAlunoRequest request)
        {
            var model = new Aluno();
            
            model.Add(request.AlunoMessage.Nome,request.AlunoMessage.DataDeNascimento);

            _alunoDomainService.Create(model);

            return new AddAlunoResponse(true, model.IdAluno);
        }

        public DeleteAlunoResponse Delete(DeleteAlunoRequest request)
        {
            var model =  _alunoDomainService.ListById(request.IdAluno);

            if (model != null && model.IdAluno > 0)
            {
                _alunoDomainService.Delete(model);
                return new DeleteAlunoResponse(true, message: "Aluno was deleted successfully!");
            }
            else
                return new DeleteAlunoResponse(false, error: "Fail to delete Aluno!");
        }

        public GetAlunoByIdResponse Get(GetAlunoByIdRequest request)
        {
            var response =  _alunoDomainService.ListById(request.IdAluno);

            if (response != null && response.IdAluno > 0)
            {
                var alunobyId = new GetAlunoByIdMessage
                {
                    IdAluno = response.IdAluno,
                    Nome = response.Nome,
                    DataDeNascimento = response.DataDeNascimento,
                    IdTurma = new TurmaModel() 
                    { 
                        IdTurma = response.Turma.IdTurma ,
                        Nome = response.Turma.Nome ,
                        Capacidade = response.Turma.Capacidade 
                    }
                };
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
                List<ListAlunoMessage> lstAluno = lstModel.Select(model => new ListAlunoMessage
                {
                    IdAluno = model.IdAluno,
                    Nome = model.Nome,
                    DataDeNascimento = model.DataDeNascimento,
                    IdTurma = new TurmaModel()
                    {
                        IdTurma = model.Turma.IdTurma,
                        Nome = model.Turma.Nome,
                        Capacidade = model.Turma.Capacidade
                    }
                }).ToList();
                return new ListAlunoResponse(true, lstAluno);
            }
            else
                return new ListAlunoResponse(false);
        }

        public UpdateAlunoResponse Update(UpdateAlunoRequest request)
        {
            var model = _alunoDomainService.ListById(request.IdAluno);

            if (model != null && model.IdAluno > 0)
            {
                model.Update(request.Nome,request.DataDeNascimento);
                
                _alunoDomainService.Update(model);

                return new UpdateAlunoResponse(true, message: "Aluno was updated successfully!");
            }
            else
                return new UpdateAlunoResponse(false, error: "Fail to update Aluno");
        }
    }
}
