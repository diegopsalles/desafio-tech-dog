using Desafio.Tech.Dog.ApplicationService.Contracts.Messages.Aluno;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Tech.Dog.ApplicationService.Contracts.Responses.Aluno
{
    public class DeleteAlunoResponse : AlunoBaseResponse
    {
        public DeleteAlunoResponse(bool success,string message ="", string error = "")
        {
            Success = success;
            Message = message;
            if (!success)
                SetError(error);
        }
    }
}
