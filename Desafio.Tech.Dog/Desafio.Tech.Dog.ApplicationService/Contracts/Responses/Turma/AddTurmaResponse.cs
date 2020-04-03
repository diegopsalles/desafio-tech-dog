using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Desafio.Tech.Dog.ApplicationService.Contracts.Responses.Turma
{
    public class AddTurmaResponse : TurmaBaseResponse
    {
        public AddTurmaResponse(bool success, int id = 0, string error = "")
        {
            IdTurma = id;
            Success = success;
            if (!success)
                SetError(error);
        }
        [JsonPropertyName("idTurma")]
        public int IdTurma { get; set; }
    }
}
