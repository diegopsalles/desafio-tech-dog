using Desafio.Tech.Dog.ApplicationService.Contracts.Request.Escola;
using Desafio.Tech.Dog.ApplicationService.Contracts.Responses.Escola;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Tech.Dog.ApplicationService.Interfaces
{
    public interface IEscolaApplicationService
    {
        AddEscolaResponse Add(AddEscolaRequest request);
        EscolaResponse Update(AddEscolaRequest request);
        EscolaResponse List();
        EscolaResponse Get(int Id);
    }
}
