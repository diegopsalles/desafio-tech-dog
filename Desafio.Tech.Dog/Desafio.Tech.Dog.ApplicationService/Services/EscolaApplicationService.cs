
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

            return new AddEscolaResponse(true, model.Id);
        }

        public DeleteEscolaResponse Delete(DeleteEscolaRequest request)
        {
            var model = _escolaDomainService.ListById(request.IdEscola);

            if (model != null && model.Id > 0)
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

            if (response != null && response.Id > 0)
            {
                var escolabyId = new GetEscolaByIdMessage();
                escolabyId.IdEscola = response.Id;
                escolabyId.Nome = response.Nome;

                if (response.Endereco != null)
                {
                    escolabyId.Endereco = new EnderecoModel()
                    {
                        IdEndereco = response.Endereco.Id,
                        Logradouro = response.Endereco.Logradouro,
                        Complemento = response.Endereco.Complemento,
                        Bairro = response.Endereco.Bairro,
                        Cidade = response.Endereco.Cidade,
                        Estado = response.Endereco.Estado,
                    };
                }
                if (response.Turmas != null && response.Turmas.Count() > 0)
                {
                    escolabyId.Turmas = new List<TurmaModel>();

                    foreach (var turma in response.Turmas)
                    {
                        var turmaModel = new TurmaModel()
                        {
                            IdTurma = turma.Id,
                            Nome = turma.Nome,
                            Capacidade = turma.Capacidade
                        };
                        escolabyId.Turmas.Add(turmaModel);
                    }
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
                List<ListEscolaMessage> lstEscola = new List<ListEscolaMessage>();

                lstModel.ForEach(model =>
                {
                    ListEscolaMessage escola = new ListEscolaMessage();

                    escola.IdEscola = model.Id;
                    escola.Nome = model.Nome;
                    if (model.Endereco != null)
                    {
                        escola.Endereco = new EnderecoModel()
                        {
                            IdEndereco = model.Endereco.Id,
                            Logradouro = model.Endereco.Logradouro,
                            Complemento = model.Endereco.Complemento,
                            Bairro = model.Endereco.Bairro,
                            Cidade = model.Endereco.Cidade,
                            Estado = model.Endereco.Estado,
                        };
                    }
                    if (model.Turmas != null && model.Turmas.Count > 0)
                    {
                        escola.Turmas = new List<TurmaModel>();
                        escola.Turmas = model.Turmas.Select(turma => new TurmaModel()
                        {
                            IdTurma = turma.Id,
                            Nome = turma.Nome,
                            Capacidade = turma.Capacidade
                        }).ToList();
                    }
                    lstEscola.Add(escola);
                });
                return new ListEscolaResponse(true, lstEscola);
            }
            else
                return new ListEscolaResponse(false);
        }
        public UpdateEscolaResponse Update(UpdateEscolaRequest request)
        {
            var model = _escolaDomainService.ListById(request.IdEscola);

            if (model != null && model.Id > 0)
            {
                model.Update(request.Nome);

                _escolaDomainService.Update(model);

                return new UpdateEscolaResponse(true, message: "Escola was updated successfully!");
            }
            else
                return new UpdateEscolaResponse(false, error: "Fail to update Escola");
        }
    }
}
