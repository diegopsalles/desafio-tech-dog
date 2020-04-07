using System;
using System.Collections.Generic;
using Desafio.Tech.Dog.Domain.Entities;
using System.Text;
using System.Text.Json.Serialization;
using Desafio.Tech.Dog.ApplicationService.Models;

namespace Desafio.Tech.Dog.ApplicationService.Contracts.Messages.Aluno
{
    public class ListAlunoMessage
    {
        [JsonPropertyName("idAluno")]
        public int IdAluno { get; set; }
        [JsonPropertyName("nome")]
        public string Nome { get; set; }
        [JsonPropertyName("dataDeNascimento")]
        public DateTime DataDeNascimento { get; set; }
        [JsonPropertyName("idTurma")]
        public int IdTurma { get; set; }

    }
}
