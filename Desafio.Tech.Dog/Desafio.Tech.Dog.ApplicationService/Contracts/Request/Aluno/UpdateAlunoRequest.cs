using Desafio.Tech.Dog.ApplicationService.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace Desafio.Tech.Dog.ApplicationService.Contracts.Request.Aluno
{
    public class UpdateAlunoRequest
    {
        [JsonPropertyName("idAluno"), Required]
        public int IdAluno { get; set; }
        [JsonPropertyName("nome"), Required]
        public string Nome { get; set; }
        [JsonPropertyName("dataDeNascimento"), Required]
        public DateTime DataDeNascimento { get; set; }
        [JsonPropertyName("idTurma"), Required]
        public int IdTurma { get; set; }
    }

}
