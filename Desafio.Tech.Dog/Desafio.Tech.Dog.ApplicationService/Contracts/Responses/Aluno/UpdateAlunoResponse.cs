using Desafio.Tech.Dog.ApplicationService.Contracts.Messages.Aluno;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Desafio.Tech.Dog.ApplicationService.Contracts.Responses.Aluno
{
    public class UpdateAlunoResponse : AlunoBaseResponse
    {
        public UpdateAlunoResponse(bool success, string error = "", string message = null)
        {
            Message = message;
            Success = success;
            if (!success)
                SetError(error);
        }

        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
