using Desafio.Tech.Dog.ApplicationService.Models;
using System;
using System.Text.Json.Serialization;

namespace Desafio.Tech.Dog.ApplicationService.Contracts.Messages.Aluno
{
    public class UpdateAlunoMessage
    {
        [JsonPropertyName("nome")]
        public string Nome { get; set; }
        [JsonPropertyName("dataDeNascimento")]
        public DateTime DataDeNascimento { get; set; }
        [JsonPropertyName("idTurma")]
        public TurmaModel IdTurma { get; set; }
    }
}
