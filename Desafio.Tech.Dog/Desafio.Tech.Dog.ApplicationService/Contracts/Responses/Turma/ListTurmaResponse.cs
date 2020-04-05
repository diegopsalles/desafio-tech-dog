using Desafio.Tech.Dog.ApplicationService.Contracts.Messages.Turma;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Desafio.Tech.Dog.ApplicationService.Contracts.Responses.Turma
{
    public class ListTurmaResponse : TurmaBaseResponse
    {
        public ListTurmaResponse(bool success, List<ListTurmaMessage> result = null, string error = "")
        {
            Result = result;
            Success = success;
            if (!success)
                SetError(error);
        }

        [JsonPropertyName("result")]
        public List<ListTurmaMessage> Result { get; set; }
    }
}
