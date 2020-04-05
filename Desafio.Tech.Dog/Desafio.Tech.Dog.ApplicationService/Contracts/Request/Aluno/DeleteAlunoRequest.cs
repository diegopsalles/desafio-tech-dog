using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Desafio.Tech.Dog.ApplicationService.Contracts.Request.Aluno
{
    public class DeleteAlunoRequest
    {
        [JsonPropertyName("idAluno")]
        public int IdAluno { get; set; }
    }
}
