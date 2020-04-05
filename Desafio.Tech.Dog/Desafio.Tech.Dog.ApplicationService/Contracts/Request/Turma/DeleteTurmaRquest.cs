using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Desafio.Tech.Dog.ApplicationService.Contracts.Request.Turma
{
    public class DeleteTurmaRquest
    {
        [JsonPropertyName("idTurma")]
        public int IdTurma { get; set; }
    }
}
