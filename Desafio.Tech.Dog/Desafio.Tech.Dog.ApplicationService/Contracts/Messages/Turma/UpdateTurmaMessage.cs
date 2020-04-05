using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Desafio.Tech.Dog.ApplicationService.Contracts.Messages.Turma
{
    public class UpdateTurmaMessage
    {
        [JsonPropertyName("nome")]
        public string Nome { get; set; }
        [JsonPropertyName("capacidade")]
        public int Capacidade { get; set; }
    }
}
