using Desafio.Tech.Dog.ApplicationService.Contracts.Messages.Turma;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Desafio.Tech.Dog.ApplicationService.Contracts.Request.Turma
{
    public class AddTurmaRequest
    {
        [JsonPropertyName("turmaMessage")]
        public AddTurmaMessage TurmaMessage { get; set; }
    }
}
