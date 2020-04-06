using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace Desafio.Tech.Dog.ApplicationService.Contracts.Messages.Aluno
{
    public class AddAlunoMessage
    {
        [JsonPropertyName("nome")]
        public string Nome { get; set; }
        [JsonPropertyName("dataDeNascimento")]
        public DateTime DataDeNascimento { get; set; }
        [JsonPropertyName("idTurma"), Required]
        public int IdTurma { get; set; }
    }
}
