using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Desafio.Tech.Dog.ApplicationService.Contracts.Responses.Turma
{
    public class AddTurmaResponse
    {
        [JsonPropertyName("idTurma")]
        public int IdTurma { get; set; }
    }
}
