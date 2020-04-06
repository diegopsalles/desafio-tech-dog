
using Desafio.Tech.Dog.ApplicationService.Contracts.Messages.Escola;
using Desafio.Tech.Dog.ApplicationService.Contracts.Request.Escola;
using Desafio.Tech.Dog.ApplicationService.Contracts.Responses.Escola;
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
    public class EscolaApplicationService : IEscolaApplicationService
    {
        private readonly IEscolaDomainService _escolaDomainService;

        public EscolaApplicationService(IEscolaDomainService escolaDomainService) => _escolaDomainService = escolaDomainService;
        public AddEscolaResponse Add(AddEscolaRequest request)
        {
            var model = new Escola();

            model.Add(request.EscolaMessage.Nome);

            _escolaDomainService.Create(model);

            return new AddEscolaResponse(true, model.IdEscola);
        }

        public DeleteEscolaResponse Delete(DeleteEscolaRequest request)
        {
            var model = _escolaDomainService.ListById(request.IdEscola);

            if (model != null && model.IdEscola > 0)
            {
                _escolaDomainService.Delete(model);
                return new DeleteEscolaResponse(true, message: "Escola was deleted successfully!");
            }
            else
                return new DeleteEscolaResponse(false, error: "Fail to delete Escola!");
        }

        public GetEscolaByIdResponse Get(GetEscolaByIdRequest request)
        {
            var response = _escolaDomainService.ListById(request.IdEscola);

            if (response != null && response.IdEscola > 0)
            {
                var escolabyId = new GetEscolaByIdMessage();
                escolabyId.IdEscola = response.IdEscola;
                escolabyId.Nome = response.Nome;
                escolabyId.Endereco = new EnderecoModel()
                {
                    IdEndereco = response.Endereco.IdEndereco,
                    Logradouro = response.Endereco.Logradouro,
                    Complemento = response.Endereco.Complemento,
                    Bairro = response.Endereco.Bairro,
                    Cidade = response.Endereco.Cidade,
                    Estado = response.Endereco.Estado,
                };
                escolabyId.Turmas = new List<TurmaModel>();
            
                foreach (var turma in response.Turmas)
                {
                    var turmaModel = new TurmaModel()
                    {
                        IdTurma = turma.IdTurma,
                        Nome = turma.Nome,
                        Capacidade = turma.Capacidade
                    };
                    escolabyId.Turmas.Add(turmaModel);
                }

                return new GetEscolaByIdResponse(true, escolabyId);
            }
            else
                return new GetEscolaByIdResponse(false);
        }

        public ListEscolaResponse List()
        {
            var lstModel = _escolaDomainService.ListAll();

            if (lstModel != null && lstModel.Count > 0)
            {
                List<ListEscolaMessage> lstEscola = lstModel.Select(model => new ListEscolaMessage
                {
                    IdEscola = model.IdEscola,
                    Nome = model.Nome,
                    Endereco = new EnderecoModel()
                    {
                        IdEndereco = model.Endereco.IdEndereco,
                        Logradouro = model.Endereco.Logradouro,
                        Complemento = model.Endereco.Complemento,
                        Bairro = model.Endereco.Bairro,
                        Cidade = model.Endereco.Cidade,
                        Estado = model.Endereco.Estado,
                    },
                    Turmas = model.Turmas.Select(turma => new TurmaModel()
                    {
                        IdTurma = turma.IdTurma,
                        Nome = turma.Nome,
                        Capacidade = turma.Capacidade
                    }).ToList()
                }).ToList();
                return new ListEscolaResponse(true, lstEscola);
            }
            else
                return new ListEscolaResponse(false);
        }
        public UpdateEscolaResponse Update(UpdateEscolaRequest request)
        {
            var model = _escolaDomainService.ListById(request.IdEscola);

            if (model != null && model.IdEscola > 0)
            {
                model.Update(model.Nome);

                _escolaDomainService.Update(model);

                return new UpdateEscolaResponse(true, message: "Escola was updated successfully!");
            }
            else
                return new UpdateEscolaResponse(false, error: "Fail to update Escola");
        }
    }
}
            