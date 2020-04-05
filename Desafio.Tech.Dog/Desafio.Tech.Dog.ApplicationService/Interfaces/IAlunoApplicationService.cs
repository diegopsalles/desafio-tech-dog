using Desafio.Tech.Dog.ApplicationService.Contracts.Request.Aluno;
using Desafio.Tech.Dog.ApplicationService.Contracts.Responses.Aluno;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Tech.Dog.ApplicationService.Interfaces
{
    public interface IAlunoApplicationService
    {
        AddAlunoResponse Add(AddAlunoRequest request);
        UpdateAlunoResponse Update(UpdateAlunoRequest request);
        ListAlunoResponse List();
        GetAlunoByIdResponse Get(GetAlunoByIdRequest request);
        DeleteAlunoResponse Delete(DeleteAlunoRequest request);
    }
}
