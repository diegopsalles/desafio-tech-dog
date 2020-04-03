using Desafio.Tech.Dog.ApplicationService.Contracts.Request.Endereco;
using Desafio.Tech.Dog.ApplicationService.Contracts.Responses.Endereco;
using Desafio.Tech.Dog.ApplicationService.Interfaces;
using Desafio.Tech.Dog.Domain.Contracts.Services;
using Desafio.Tech.Dog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Tech.Dog.ApplicationService.Services
{
    public class EnderecoApplicationService : IEnderecoApplicationService
    {
        private readonly IEnderecoDomainService _enderecoDomainService;

        public EnderecoApplicationService(IEnderecoDomainService enderecoDomainService) => _enderecoDomainService = enderecoDomainService;
        
        public AddEnderecoResponse Add(AddEnderecoRequest request)
        {
            var model = new Endereco 
            { 
                Logradouro = request.EnderecoMessage.Logradouro , 
                Complemento = request.EnderecoMessage.Complemento , 
                Bairro = request.EnderecoMessage.Bairro , 
                Cidade = request.EnderecoMessage.Cidade ,
                Estado = request.EnderecoMessage.Estado
            };

            _enderecoDomainService.Create(model);

            return new AddEnderecoResponse(true, model.IdEndereco);
        }

        public EnderecoResponse Get(int Id)
        {
            throw new NotImplementedException();
        }

        public EnderecoResponse List()
        {
            throw new NotImplementedException();
        }

        public EnderecoResponse Update(AddEnderecoRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
