using Desafio.Tech.Dog.ApplicationService.Contracts.Messages.Aluno;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Desafio.Tech.Dog.ApplicationService.Contracts.Responses.Aluno
{
    public class UpdateAlunoResponse : AlunoBaseResponse
    {
        public UpdateAlunoResponse(bool success, UpdateAlunoMessage result = null, string error = "", string message = null)
        {
            Result = result;
            Success = success;
            if (!success)
                SetError(error);
        }

        [JsonPropertyName("result")]
        public UpdateAlunoMessage Result { get; set; }
    }
}
