using Desafio.Tech.Dog.ApplicationService.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Desafio.Tech.Dog.ApplicationService.Contracts.Messages.Turma
{
    public class ListTurmaMessage
    {
        [JsonPropertyName("idEscola")]
        public int IdTurma { get; set; }
        [JsonPropertyName("nome")]
        public string Nome { get; set; }
        [JsonPropertyName("endereco")]
        public int Capacidade { get; set; }

        [JsonPropertyName("turmas")]
        public List<AlunoModel> Alunos { get; set; }
    }
}
