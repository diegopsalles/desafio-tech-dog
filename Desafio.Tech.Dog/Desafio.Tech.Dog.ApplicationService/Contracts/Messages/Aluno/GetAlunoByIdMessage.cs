using Desafio.Tech.Dog.ApplicationService.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Desafio.Tech.Dog.ApplicationService.Contracts.Messages.Aluno
{
    public class GetAlunoByIdMessage
    {
        [JsonPropertyName("idAluno")]
        public int IdAluno { get; set; }
        [JsonPropertyName("nome")]
        public string Nome { get; set; }
        [JsonPropertyName("dataDeNascimento")]
        public DateTime DataDeNascimento { get; set; }
        [JsonPropertyName("idTurma")]
        public int IdTurma { get; set; }
        //[JsonPropertyName("idTurma")]
        //public TurmaModel IdTurma { get; set; }
    }
}
