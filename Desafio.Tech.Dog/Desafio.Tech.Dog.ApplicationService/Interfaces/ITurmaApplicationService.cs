using Desafio.Tech.Dog.ApplicationService.Contracts.Request.Turma;
using Desafio.Tech.Dog.ApplicationService.Contracts.Responses.Turma;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Tech.Dog.ApplicationService.Interfaces
{
    public interface ITurmaApplicationService
    {
        AddTurmaResponse Add(AddTurmaRequest request);
        GetTurmaByIdResponse Update(AddTurmaRequest request);
        GetTurmaByIdResponse List();
        GetTurmaByIdResponse Get(int Id);
    }
}
