using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Tech.Dog.ApplicationService.Contracts.Responses.Turma
{
    public class DeleteTurmaResponse : TurmaBaseResponse
    {
        public DeleteTurmaResponse(bool success, string message = "", string error = "")
        {
            Success = success;
            Message = message;
            if (!success)
                SetError(error);
        }
    }
}
