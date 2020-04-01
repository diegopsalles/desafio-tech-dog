using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Desafio.Tech.Dog.ApplicationService.Contracts.Responses.Aluno
{
    public class AddAlunoResponse
    {
        [JsonPropertyName("idAluno")]
        public int IdAluno { get; set; }
    }
}
