
using Desafio.Tech.Dog.ApplicationService.Contracts.Request.Escola;
using Desafio.Tech.Dog.ApplicationService.Contracts.Responses.Escola;
using Desafio.Tech.Dog.ApplicationService.Interfaces;
using Desafio.Tech.Dog.Domain.Contracts.Services;
using Desafio.Tech.Dog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Tech.Dog.ApplicationService.Services
{
    public class EscolaApplicationService : IEscolaApplicationService
    {
        private readonly IEscolaDomainService _escolaDomainService;

        public EscolaApplicationService(IEscolaDomainService escolaDomainService) => _escolaDomainService = escolaDomainService;
        public AddEscolaResponse Add(AddEscolaRequest request)
        {
            var model = new Escola
            {
                Nome = request.EscolaMessage.Nome,
            };

            _escolaDomainService.Create(model);

            return new AddEscolaResponse(true, model.IdEscola);
        }

        public GetEscolaByIdResponse Get(int Id)
        {
            throw new NotImplementedException();
        }

        public GetEscolaByIdResponse List()
        {
            throw new NotImplementedException();
        }

        public GetEscolaByIdResponse Update(AddEscolaRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
