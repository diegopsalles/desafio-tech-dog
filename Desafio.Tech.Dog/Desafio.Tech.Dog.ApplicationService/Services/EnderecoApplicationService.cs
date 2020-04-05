using Desafio.Tech.Dog.ApplicationService.Contracts.Messages.Endereco;
using Desafio.Tech.Dog.ApplicationService.Contracts.Request.Endereco;
using Desafio.Tech.Dog.ApplicationService.Contracts.Responses.Endereco;
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
    public class EnderecoApplicationService : IEnderecoApplicationService
    {
        private readonly IEnderecoDomainService _enderecoDomainService;

        public EnderecoApplicationService(IEnderecoDomainService enderecoDomainService) => _enderecoDomainService = enderecoDomainService;
        
        public AddEnderecoResponse Add(AddEnderecoRequest request)
        {
            var model = new Endereco();

            model.Add(request.EnderecoMessage.Logradouro, request.EnderecoMessage.Complemento,request.EnderecoMessage.Bairro,
                request.EnderecoMessage.Cidade,request.EnderecoMessage.Estado);

            _enderecoDomainService.Create(model);

            return new AddEnderecoResponse(true, model.IdEndereco);
        }

        public DeleteEnderecoResponse Delete(DeleteEnderecoRequest request)
        {
            var model = _enderecoDomainService.ListById(request.IdEndereco);

            if (model != null && model.IdEndereco > 0)
            {
                _enderecoDomainService.Delete(model);
                return new DeleteEnderecoResponse(true, message: "Endereco was deleted successfully!");
            }
            else
                return new DeleteEnderecoResponse(false, error: "Fail to delete Endereco!");
        }
        public GetEnderecoByIdResponse Get(GetEnderecoByIdRequest request)
        {
            var response = _enderecoDomainService.ListById(request.IdEndereco);

            if (response != null && response.IdEndereco > 0)
            {
                var enderecobyId = new GetEnderecoByIdMessage
                {
                    IdEndereco = response.IdEndereco,
                    Logradouro = response.Logradouro,
                    Complemento = response.Complemento,
                    Bairro = response.Bairro,
                    Cidade = response.Cidade,
                    Estado = response.Estado,
                    Escola = new EscolaModel()
                    {
                        IdEscola = response.Escola.IdEscola,
                        Nome = response.Escola.Nome
                    }
                };
                return new GetEnderecoByIdResponse(true, enderecobyId);
            }
            else
                return new GetEnderecoByIdResponse(false);
        }

        public ListEnderecoResponse List()
        {
            var lstModel = _enderecoDomainService.ListAll();

            if (lstModel != null && lstModel.Count > 0)
            {
                List<ListEnderecoMessage> lstEndereco = lstModel.Select(model => new ListEnderecoMessage
                {
                    IdEndereco = model.IdEndereco,
                    Logradouro = model.Logradouro,
                    Complemento = model.Complemento,
                    Bairro = model.Bairro,
                    Cidade = model.Cidade,
                    Estado = model.Estado,
                    Escola = new EscolaModel()
                    {
                        IdEscola = model.Escola.IdEscola,
                        Nome = model.Escola.Nome
                    }
                }).ToList();
                return new ListEnderecoResponse(true, lstEndereco);
            }
            else
                return new ListEnderecoResponse(false);
        }

        public UpdateEnderecoResponse Update(UpdateEnderecoRequest request)
        {
            var model = _enderecoDomainService.ListById(request.IdEndereco);

            if (model != null && model.IdEndereco > 0)
            {
                model.Update(request.Logradouro, request.Complemento,
                    request.Bairro,
                    request.Cidade,
                    request.Estado);

                _enderecoDomainService.Update(model);

                return new UpdateEnderecoResponse(true, message: "Endereco was updated successfully!");
            }
            else
                return new UpdateEnderecoResponse(false, error: "Fail to update Endereco");
        }
    }
}
