using Desafio.Tech.Dog.ApplicationService.Contracts.Messages.Turma;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Desafio.Tech.Dog.ApplicationService.Contracts.Responses.Turma
{
    public class UpdateTurmaResponse : TurmaBaseResponse
    {
        public UpdateTurmaResponse(bool success, UpdateTurmaMessage result = null, string error = "", string message = null)
        {
            Result = result;
            Success = success;
            if (!success)
                SetError(error);
        }

        [JsonPropertyName("result")]
        public UpdateTurmaMessage Result { get; set; }
    }
}
